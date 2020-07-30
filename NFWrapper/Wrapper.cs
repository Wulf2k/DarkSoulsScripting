using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DarkSoulsScripting;
using DarkSoulsScripting.Injection.DLL;
using DarkSoulsScripting.Injection.Structures;
using Iced.Intel;
using static Iced.Intel.AssemblerRegisters;
using RGiesecke.DllExport;

namespace NFWrapper
{
    public static partial class Wrapper
    {
        [DllExport]
        public static void Nightfall(int processID)
        {
            while (!Hook.DARKSOULS.Attached)
                Hook.DARKSOULS.TryAttachToDarkSouls(processID);

            WaitFrpgSysInit();
            WaitForBoot();
            WaitForTitle();

            EzDrawHook.Hook();
            EzDrawHook.SetHook(1);

            InitBleedBar();

            while (Hook.DARKSOULS.Attached)
            {
                DisplayBleedBar();
                Thread.Sleep(16);
            }

            Nightfall(processID);
        }

        
        private static void WaitForBoot()
        {
            while (Hook.RUInt32(0x141d06ef8) == 0)
            { }
        }

        static void SetNoLogo()
        {
            Output($"Setting NoLogo\n");
            Hook.WByte(0x14070c599, 1);
        }

        static void WaitForTitle()
        {
            Output("Waiting for titlescreen\n");
            bool loop = true;
            while (loop && (Hook.RInt32(0x140000000) == 0x905a4d))
            {
                loop = (Hook.RInt32(Hook.RIntPtr(Hook.RIntPtr(Hook.RIntPtr(Hook.RIntPtr(Hook.RIntPtr(0x141c04e28) + 0x8) + 0x20) + 0x58) + 0x20) + 0x10) < 0xB);
                Thread.Sleep(33);
            }
            Output("Reached titlescreen\n");
        }

        static void WaitFrpgSysInit()
        {
            while ((Hook.RIntPtr(0x141C04E28) == IntPtr.Zero) && (Hook.RInt32(0x140000000) == 0x905a4d)) { }
        }

        static void Output(object t)
        {
            Console.WriteLine(t);
        }

        public static IntPtr GetPlayerInsFromHandle(Int32 Handle)
        {
            //Console.WriteLine($@"Handle: {Handle}");
            ulong FuncAddr = 0x140371e30;

            SafeRemoteHandle codeptr_ = new SafeRemoteHandle(0x1000);
            SafeRemoteHandle valptr_ = new SafeRemoteHandle(0x10);
            IntPtr codeptr = codeptr_.GetHandle();
            IntPtr valptr = valptr_.GetHandle();

            var c = new Assembler(64);
            c.push(rax);
            c.push(rbx);
            c.push(rcx);
            c.push(rdx);
            c.push(rbp);
            c.push(rsi);
            c.push(rdi);
            c.push(r8);
            c.push(r9);
            c.push(r10);
            c.push(r11);
            c.push(r12);
            c.push(r13);
            c.push(r14);
            c.push(r15);
            c.pushfq();
            c.sub(rsp, 0x100);

            c.mov(rbx, (ulong)valptr);
            c.mov(__qword_ptr[rbx], 0);
            c.mov(__qword_ptr[rbx + 8], 0);
            c.xor(rbx, rbx);


            c.mov(rcx, (ulong)WorldChrMan.Address);
            c.mov(rdx, Handle);


            c.call(FuncAddr);

            c.mov(rbx, (ulong)valptr);
            c.mov(__qword_ptr[rbx], rax);
            c.mov(__qword_ptr[rbx + 8], 1);


            c.add(rsp, 0x100);
            c.popfq();
            c.pop(r8);
            c.pop(r9);
            c.pop(r10);
            c.pop(r11);
            c.pop(r12);
            c.pop(r13);
            c.pop(r14);
            c.pop(r15);
            c.pop(rdi);
            c.pop(rsi);
            c.pop(rbp);
            c.pop(rdx);
            c.pop(rcx);
            c.pop(rbx);
            c.pop(rax);
            c.ret();

            var stream = new MemoryStream();
            c.Assemble(new StreamCodeWriter(stream), (ulong)codeptr);
            Hook.WBytes(codeptr, stream.ToArray());

            //Console.WriteLine(codeptr.ToString("X"));
            uint MAX_WAIT = 1000;
            var threadHandle = new SafeRemoteThreadHandle(codeptr_);
            if (!threadHandle.IsClosed & !threadHandle.IsInvalid)
            {
                Kernel32.WaitForSingleObject(threadHandle.GetHandle(), MAX_WAIT);
            }

            UInt64 result = Hook.RUInt64(valptr);
            threadHandle.Close();
            threadHandle.Dispose();
            threadHandle = null;

            return (IntPtr)result;
        }
    }
}
