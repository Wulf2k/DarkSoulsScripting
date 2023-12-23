using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

using Iced.Intel;
using DarkSoulsScripting.Injection.Structures;
using static Iced.Intel.AssemblerRegisters;
using DarkSoulsScripting.Injection.DLL;
using System.IO;

namespace DarkSoulsScripting
{
    public static class WorldChrMan
    {
        public const int CHR_STRUCT_SIZE = 0x5F8;

        public static Player LocalPlayer { get; private set; } = null;
        public static List<WorldBlockChr> LoadedWorldBlockChrs = null;


        public static IntPtr Address => RIntPtr(0x141c77e50); //DSR1310


        static WorldChrMan()
        {
            LocalPlayer = new Player() { AddressReadFunc = () => LocalPlayerPtr };
            LoadedWorldBlockChrs = new List<WorldBlockChr>();
            for (int x = 0; x < numLoadedWorldBlockChrs; x++)
            {
                IntPtr addr = RIntPtr(LoadedWorldBlockChrStart + x * 8);
                LoadedWorldBlockChrs.Add(new WorldBlockChr() { AddressReadFunc = () => addr });
            }
                

        }

        

        
        public static Int32 numWorldBlockChrs => RInt32(Address + 0x28);
        public static IntPtr WorldBlockChrPtr => RIntPtr(Address + 0x30);
        public static IntPtr LocalPlayerPtr => RIntPtr(Address + 0x68);
        public static Int32 numLoadedWorldBlockChrs => RInt32(Address + 0xA0);
        public static IntPtr LoadedWorldBlockChrStart => Address + 0xA8;




        public static List<Enemy> GetEnemies()
        {
            var result = new List<Enemy>();

            foreach (WorldBlockChr wbc in LoadedWorldBlockChrs)
            {
                //Console.WriteLine(wbc.Address.ToString("X"));
                if (wbc.ChrCount > 0)
                    foreach (Enemy nme in wbc.GetEnemies())
                        result.Add(nme);
            }
            return result;
        }
        public static Enemy GetEnemyByName(string name)
        {
            foreach (var e in GetEnemies())
            {
                if (e.GetName() == name)
                    return e;
            }
            return null;
        }

        public static EnemyPtrAccessor EnemyPtr = new EnemyPtrAccessor();

        public class EnemyPtrAccessor
        {
            public IntPtr this[int index]
            {
                //DSR
                get => RIntPtr(ChrsBegin + (index * IntPtr.Size));
                set => WIntPtr(ChrsBegin + (index * IntPtr.Size), value);
            }
        }

        public static IntPtr ChrsBegin
        {
            //DSR
            get => RIntPtr(RIntPtr(0x141c823a0) + IntPtr.Size);  //DSR1310
            set => WIntPtr(RIntPtr(0x141c823a0) + IntPtr.Size, value);  //DSR1310
        }

        public static IntPtr ChrsEnd
        {
            //DSR
            get => RIntPtr(RIntPtr(0x141c823a0) + IntPtr.Size * 2);  //DSR1310
            set => WIntPtr(RIntPtr(0x141c823a0) + IntPtr.Size * 2, value);  //DSR1310
        }

        public static IntPtr GetChrFromHandle(Int32 Handle)
        {
            //Console.WriteLine($@"Handle: {Handle}");
            ulong FuncAddr = 0x1403714b0;  //DSR1310, WorldChrMan_GetPlayerInsFromHandle

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
