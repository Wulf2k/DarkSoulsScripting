using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.Win32.SafeHandles;

namespace DarkSoulsScripting.Injection.Structures
{
    public class SafeRemoteThreadHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public readonly SafeRemoteHandle Func;
        public SafeRemoteThreadHandle(SafeRemoteHandle func) : base(true)
        {
            this.Func = func;
            Hook.DARKSOULS.OnDetach += DARKSOULS_OnDetach;
            Alloc();
        }
        private void Alloc()
        {
            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();
            IntPtr funcHandle = Func.GetHandle();
            /*if ((Int64)funcHandle < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return;
            }*/
            
            IntPtr remoteThread = Kernel.CreateRemoteThread(dsHandle, IntPtr.Zero, 0, funcHandle, IntPtr.Zero, 0, IntPtr.Zero);
            Console.WriteLine(remoteThread);
            SetHandle(remoteThread);
        }
        public IntPtr GetHandle()
        {
            if (IsClosed || IsInvalid) // || handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                Alloc();
            }
            return handle;
        }
        private void DARKSOULS_OnDetach()
        {
            SetHandleAsInvalid();
        }
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            Hook.DARKSOULS.OnDetach -= DARKSOULS_OnDetach;

            /*if (handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return false;
            }*/

            return Kernel.CloseHandle(handle);
        }

    }
}
