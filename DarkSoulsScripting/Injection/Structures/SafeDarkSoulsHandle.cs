using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Collections.ObjectModel;
using System.Runtime.ConstrainedExecution;
using Microsoft.Win32.SafeHandles;

namespace DarkSoulsScripting.Injection.Structures
{

    public class SafeDarkSoulsHandle : SafeHandleZeroOrMinusOneIsInvalid
    {

        internal event OnDetachEventHandler OnDetach;
        internal delegate void OnDetachEventHandler();
        internal event OnAttachEventHandler OnAttach;
        internal delegate void OnAttachEventHandler();

        public ReadOnlyDictionary<string, List<uint>> ModuleOffsets { get; private set; }

        public readonly int SafeBaseMemoryOffset = 0x400000;

        public static readonly DarkSoulsVersion[] CompatibleVersions = new DarkSoulsVersion[] { DarkSoulsVersion.LatestRelease };
        public bool Attached
        {
            get { return (!IsClosed) && (!IsInvalid); }
        }

        public DarkSoulsVersion Version { get; private set;  }
        public string VersionDisplayName
        {
            get
            {
                switch (Version)
                {
                    case DarkSoulsVersion.None:
                        return "None";
                    case DarkSoulsVersion.LatestRelease:
                        return "Latest Steam Release";
                    case DarkSoulsVersion.SteamWorksBeta:
                        return "Steamworks December 2014 Beta (Incompatible)";
                    case DarkSoulsVersion.AncientGFWL:
                        return "Games for Windows Live Release (Incompatible)";
                }
                return Version.ToString();
                //Shut up compiler
            }
        }

        public SafeDarkSoulsHandle() : base(true)
        {
        }

        public IntPtr GetHandle()
        {
            return handle;
        }

        private uint GetIngameDllAddress(string moduleName)
        {
            uint[] modules = new uint[255];
            uint cbNeeded = 0;
            PSAPI.EnumProcessModules(Hook.DARKSOULS.GetHandle(), modules, 4 * 1024, ref cbNeeded);

            uint numModules = (uint)(cbNeeded / IntPtr.Size);


            for (int i = 0; i <= numModules - 1; i++)
            {
                var disModule = new IntPtr(modules[i]);
                System.Text.StringBuilder name = new System.Text.StringBuilder();
                PSAPI.GetModuleBaseName(Hook.DARKSOULS.GetHandle(), disModule, name, 255);

                if ((name.ToString().ToUpper().Equals(moduleName.ToUpper())))
                {
                    return modules[i];
                }

            }

            return 0;
        }

        public bool TryAttachToDarkSouls(out string errorMsg)
        {
            errorMsg = null;
            Process selectedProcess = null;
            Process[] _allProcesses = Process.GetProcesses();
            foreach (Process proc in _allProcesses)
            {
                if (selectedProcess == null && proc.MainWindowTitle.ToUpper().Equals("DARK SOULS"))
                {
                    selectedProcess = proc;
                }
                else
                {
                    proc.Dispose();
                }
            }

            if (selectedProcess != null)
            {
                SetHandle((IntPtr)Kernel.OpenProcess(Kernel.PROCESS_ALL_ACCESS, false, selectedProcess.Id));
                CheckHook();
                Dictionary<string, List<uint>> modulesInputDict = new Dictionary<string, List<uint>>();

                if (Attached)
                {
                    foreach (ProcessModule dll in selectedProcess.Modules)
                    {
                        string indexName = dll.ModuleName.ToUpper();
                        if (modulesInputDict.ContainsKey(indexName))
                        {
                            modulesInputDict[indexName].Add((uint)dll.BaseAddress);
                        }
                        else
                        {
                            modulesInputDict.Add(indexName, new uint[] { (uint)dll.BaseAddress }.ToList());
                        }
                    }
                }

                ModuleOffsets = new ReadOnlyDictionary<string, List<uint>>(modulesInputDict);
                selectedProcess.Dispose();
            }
            else
            {
                errorMsg = "Unable to find Dark Souls process.";
                return false;
            }

            if (!Attached)
            {
                errorMsg = "Found Dark Souls process but failed to attach to it.\nTry explicitly running your program (or scripting environment) as an administrator.";
                return false;
            }
            else
            {
                OnAttach?.Invoke();
                return true;
            }
        }

        private void CheckHook()
        {
            var test = Hook.RUInt32(0x400080);
            if ((Hook.RUInt32(0x400080) == 0xFC293654))
            {
                Version = DarkSoulsVersion.LatestRelease;

                uint dummy = 0;
                if (!Kernel.VirtualProtectEx(handle, 0x10CC000, 0x1DE000, Kernel.PAGE_READWRITE, ref dummy))
                {
                    throw new Exception("VirtualProtectEx Returned False");
                }

                if (!Kernel.FlushInstructionCache(handle, 0x10CC000, 0x1DE000))
                {
                    throw new Exception("FlushInstructionCache Returned False");
                }

                Kernel.WriteProcessMemory_SAFE(handle, 0xBE73FE, new byte[] { 0x20 }, 1, 0);
                Kernel.WriteProcessMemory_SAFE(handle, 0xBE719F, new byte[] { 0x20 }, 1, 0);
                Kernel.WriteProcessMemory_SAFE(handle, 0xBE722B, new byte[] { 0x20 }, 1, 0);

                ExtraFuncs.SetSaveEnable(false);
            }
            else
            {
                byte[] buffer = new byte[4];
                Kernel.ReadProcessMemory_SAFE(handle, 0x400080, buffer, 4, 0);
                uint dwBetaChk = BitConverter.ToUInt32(buffer, 0);
                if ((dwBetaChk == 0xE91B11E2U))
                {
                    Version = DarkSoulsVersion.SteamWorksBeta;
                }
                else
                {
                    Version = DarkSoulsVersion.None;
                }
            }

            if (!CompatibleVersions.Contains(Version))
            {
                Close();
            }
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            OnDetach?.Invoke();
            return Kernel.CloseHandle(handle);
        }

    }

}
