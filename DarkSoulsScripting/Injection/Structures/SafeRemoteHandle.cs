using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.Win32.SafeHandles;

namespace DarkSoulsScripting.Injection.Structures
{
    public class SafeRemoteHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public readonly int Size;
        public SafeRemoteHandle(int size) : base(true)
        {
            this.Size = size;
            Hook.DARKSOULS.OnDetach += DARKSOULS_OnDetach;
            Alloc();
        }
        private void Alloc()
        {
            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();
            IntPtr h = (IntPtr)Kernel.VirtualAllocEx(dsHandle, IntPtr.Zero, Size, Kernel.MEM_COMMIT, Kernel.PAGE_EXECUTE_READWRITE);
            SetHandle(h);
        }
        public IntPtr GetHandle()
        {
            if (IsClosed || IsInvalid ) // || handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                Alloc();
            }
            return handle;
        }
        public bool Release()
        {
            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();
            return Kernel.VirtualFreeEx(Hook.DARKSOULS.GetHandle(), handle, 0, Kernel.MEM_RELEASE);
        }
        private void DARKSOULS_OnDetach()
        {
            SetHandleAsInvalid();
        }
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            Hook.DARKSOULS.OnDetach -= DARKSOULS_OnDetach;

            if (handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return false;
            }

            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();

            return Kernel.VirtualFreeEx(dsHandle, handle, 0, Kernel.MEM_RELEASE);
        }
        public void MemPatch(byte[] src, int? srcIndex = null, int? destOffset = null, int? numBytes = null)
        {
            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();
            /*if (dsHandle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return;
            }*/

            if ((destOffset ?? 0 + numBytes ?? src.Length) > Size)
            {
                throw new Exception("Bytes will not fit in allocated space.");
            }
            byte[] buf = new byte[numBytes ?? src.Length];
            Array.Copy(src, srcIndex ?? 0, buf, 0, numBytes ?? src.Length);
            Kernel.WriteProcessMemory_SAFE(dsHandle, (handle + (destOffset ?? 0)), buf, numBytes ?? src.Length, IntPtr.Zero);
        }

        public void MemPatch(SafeMarshalledHandle src, int? destOffset = null, int? numBytes = null)
        {
            /*if (handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return;
            }*/

            if ((destOffset ?? 0 + numBytes ?? src.Size) > Size)
            {
                throw new Exception("Bytes will not fit in allocated space.");
            }
            byte[] buf = new byte[numBytes ?? src.Size];

            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();

            Kernel.WriteProcessMemory_SAFE(dsHandle, (handle + (destOffset ?? 0)), src.GetHandle(), numBytes ?? src.Size, IntPtr.Zero);
        }

        public byte[] GetFuncReturnValue()
        {
            byte[] result = new byte[8];

            /*if (handle.ToInt64() < (Int64)Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                return result;
            }*/

            IntPtr dsHandle = Hook.DARKSOULS.GetHandle();
            if (!Kernel.ReadProcessMemory_SAFE(dsHandle, handle + DSAsmCaller.FUNC_RETURN_ADDR_OFFSET, result, IntPtr.Size, IntPtr.Zero))
            {
                //Throw New Exception("Kernel.ReadProcessMemory Fail for SafeRemoteHandle.GetFuncReturnValue()")
            }
            return result;
        }
    }
}
