#define SAFE

using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace DarkSoulsScripting.Injection
{
    static internal class Kernel
    {
        internal const int PROCESS_VM_READ = 0x10;
        internal const int TH32CS_SNAPPROCESS = 0x2;
        internal const int MEM_COMMIT = 4096;
        internal const int PAGE_READWRITE = 4;
        internal const int PAGE_EXECUTE_READWRITE = 0x40;
        internal const int PROCESS_CREATE_THREAD = (0x2);
        internal const int PROCESS_VM_OPERATION = (0x8);
        internal const int PROCESS_VM_WRITE = (0x20);
        internal const int PROCESS_ALL_ACCESS = 0x1f0fff;
        internal const int MEM_RELEASE = 0x8000;
        internal const int CREATE_SUSPENDED = 0x4;

        private static bool CheckAddress(long addr, bool isWrite)
        {
            if (addr < Hook.DARKSOULS.SafeBaseMemoryOffset)
            {
                Console.WriteLine($"Tried to {(isWrite ? "write" : "read")} from invalid memory address 0x{addr:X} (minimum safe base offset address is hardcoded to 0x{Hook.DARKSOULS.SafeBaseMemoryOffset:X8}).");
                return false;
            }
            return true;
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern uint CreateRemoteThread(IntPtr hProcess, uint lpThreadAttributes, int dwStackSize, uint lpStartAddress, uint lpParameter, int dwCreationFlags, uint lpThreadId);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern uint OpenProcess(int dwDesiredAcess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool ReadProcessMemory(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int iSize, uint lpNumberOfBytesRead);

        static internal bool ReadProcessMemory_SAFE(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int iSize, uint lpNumberOfBytesRead)
        {
            if (!CheckAddress(lpBaseAddress, false))
            {
                Array.Clear(lpBuffer, 0, iSize);
                return false;
            }

            uint dummy = 0;
            if (VirtualProtectEx(hProcess, lpBaseAddress, iSize, PAGE_READWRITE, ref dummy))
            {
                return ReadProcessMemory(hProcess, lpBaseAddress, lpBuffer, iSize, lpNumberOfBytesRead);
            }
            else
            {
                return false;
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesWritten);

        static internal bool WriteProcessMemory_SAFE(IntPtr hProcess, uint lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesWritten)
        {
            if (!CheckAddress(lpBaseAddress, true))
            {
                return false;
            }

#if SAFE
            uint dummy = 0;
            if (VirtualProtectEx(hProcess, lpBaseAddress, iSize, PAGE_READWRITE, ref dummy))
            {
#endif
                return WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, iSize, lpNumberOfBytesWritten);
#if SAFE
        }
            else
            {
                return false;
            }
#endif
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern uint VirtualAllocEx(IntPtr hProcess, uint lpAddress, int dwSize, int flAllocationType, int flProtect);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern bool VirtualFreeEx(IntPtr hProcess, uint lpAddress, int dwSize, int dwFreeType);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern bool VirtualProtectEx(IntPtr hProcess, uint lpAddress, int dwSize, int flNewProtect, ref uint lpflOldProtect);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern int WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        static internal extern bool FlushInstructionCache(IntPtr hProcess, uint lpBaseAddress, int dwSize);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, uint lpBaseAddress, uint lpBuffer, int iSize, int lpNumberOfBytesWritten);

        static internal bool WriteProcessMemory_SAFE(IntPtr hProcess, uint lpBaseAddress, uint lpBuffer, int iSize, int lpNumberOfBytesWritten)
        {
            if (!CheckAddress(lpBaseAddress, true))
            {
                return false;
            }

#if SAFE
            uint dummy = 0;
            if (VirtualProtectEx(hProcess, lpBaseAddress, iSize, PAGE_READWRITE, ref dummy))
            {
#endif
                return WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, iSize, lpNumberOfBytesWritten);
#if SAFE
        }
            else
            {
                return false;
            }
#endif
        }
    }
}
