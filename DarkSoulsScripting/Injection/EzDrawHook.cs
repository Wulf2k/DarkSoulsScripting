using static Iced.Intel.AssemblerRegisters;
using Iced.Intel;
using static DarkSoulsScripting.Hook;
using DarkSoulsScripting.Injection.Structures;
using System.IO;
using System;

namespace DarkSoulsScripting
{
    public class EzDrawHook
    {
        static EzDrawHook()
        {

        }
        public static class ObjMgr
        {
            public static int objcount;

            static ObjMgr()
            {
                objcount = 0;
            }
        }

        public class Box
        {
            public IntPtr codeptr;
            public IntPtr boxptr;

            public Box()
            {
                SafeRemoteHandle codeptr_ = new SafeRemoteHandle(0x1000);
                SafeRemoteHandle boxptr_ = new SafeRemoteHandle(0x1000);

                codeptr = codeptr_.GetHandle();
                boxptr = boxptr_.GetHandle();

                TexHandle = 0;
                Color1R = 1;
                Color1G = 0;
                Color1B = 0;
                Color1A = 1;

                Flags = 0x37;
                State = 7;

                InitCode();
            }
            public uint Flags
            {
                get { return RUInt32(boxptr + 0x10); }
                set { WUInt32(boxptr + 0x10, value); }
            }
            public uint TexHandle
            {
                get { return RUInt32(boxptr + 0x14); }
                set { WUInt32(boxptr + 0x14, value); }
            }
            public uint State
            {
                get { return RUInt32(boxptr + 0x18); }
                set { WUInt32(boxptr + 0x18, value); }
            }
            public float Color1R
            {
                get { return RFloat(boxptr + 0x20); }
                set { WFloat(boxptr + 0x20, value); }
            }
            public float Color1G
            {
                get { return RFloat(boxptr + 0x24); }
                set { WFloat(boxptr + 0x24, value); }
            }
            public float Color1B
            {
                get { return RFloat(boxptr + 0x28); }
                set { WFloat(boxptr + 0x28, value); }
            }
            public float Color1A
            {
                get { return RFloat(boxptr + 0x2c); }
                set { WFloat(boxptr + 0x2c, value); }
            }
            public float Color2R
            {
                get { return RFloat(boxptr + 0x30); }
                set { WFloat(boxptr + 0x30, value); }
            }
            public float Color2G
            {
                get { return RFloat(boxptr + 0x34); }
                set { WFloat(boxptr + 0x34, value); }
            }
            public float Color2B
            {
                get { return RFloat(boxptr + 0x38); }
                set { WFloat(boxptr + 0x38, value); }
            }
            public float Color2A
            {
                get { return RFloat(boxptr + 0x3c); }
                set { WFloat(boxptr + 0x3c, value); }
            }
            public float XPos
            {
                get { return RFloat(boxptr + 0x90); }
                set { WFloat(boxptr + 0x90, value); }
            }
            public float YPos
            {
                get { return RFloat(boxptr + 0x94); }
                set { WFloat(boxptr + 0x94, value); }
            }
            public float Width
            {
                get { return RFloat(boxptr + 0xb0); }
                set { WFloat(boxptr + 0xb0, value); }
            }
            public float Height
            {
                get { return RFloat(boxptr + 0xc0); }
                set { WFloat(boxptr + 0xc0, value); }
            }


            private void InitCode()
            {
                IntPtr HgManPtr = HgMan.Address;
                IntPtr EzDrawPtr = RIntPtr(HgManPtr + 0x60);
                IntPtr EzDrawStatePtr = RIntPtr(EzDrawPtr + 0x48);
                IntPtr EzDraw_DrawBox = (IntPtr)0x1401d69e0;

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

                c.mov(rcx, (ulong)EzDrawPtr);
                c.mov(r12, (ulong)EzDrawStatePtr);

                c.movaps(xmm0, __[(ulong)boxptr + 0x10]);
                c.movaps(__[r12 + 0x10], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x20]);
                c.movaps(__[r12 + 0x20], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x30]);
                c.movaps(__[r12 + 0x30], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x40]);
                c.movaps(__[r12 + 0x40], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x50]);
                c.movaps(__[r12 + 0x50], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x60]);
                c.movaps(__[r12 + 0x60], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x70]);
                c.movaps(__[r12 + 0x70], xmm0);

                c.movaps(xmm0, __[(ulong)boxptr + 0x80]);
                c.movaps(__[r12 + 0x80], xmm0);

                c.lea(rdx, __[(ulong)boxptr + 0x90]);

                c.movaps(xmm0, __[(ulong)boxptr + 0x90]);  //pos
                c.movaps(xmm1, __[(ulong)boxptr + 0xa0]);
                c.movaps(xmm2, __[(ulong)boxptr + 0xb0]);  //width
                c.movaps(xmm3, __[(ulong)boxptr + 0xc0]);  //height
                c.movaps(xmm4, __[(ulong)boxptr + 0xd0]);
                c.movaps(xmm5, __[(ulong)boxptr + 0xe0]);
                c.movaps(xmm6, __[(ulong)boxptr + 0xf0]);
                c.movaps(xmm7, __[(ulong)boxptr + 0x100]);
                c.movaps(xmm8, __[(ulong)boxptr + 0x110]);

                c.sub(rsp, 0x78);
                c.mov(__qword_ptr[rsp + 0x28], 0);
                c.mov(__qword_ptr[rsp + 0x30], 0x0);
                c.mov(__qword_ptr[rsp + 0x38], 0x3f800000);
                c.mov(__qword_ptr[rsp + 0x40], 0x3f800000);
                c.add(rsp, 8);

                c.call((ulong)EzDraw_DrawBox);

                c.add(rsp, 0x70);



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
                WBytes(codeptr, stream.ToArray());
            }

        }


        //public static IntPtr boxVals;
        public static IntPtr objptr;

        public static void SetHook(bool state)
        {
            WBool(0x141d173d2, state);
        }
        public static void SetHook(byte state)
        {
            SetHook(state != 0);
        }

        public static void Hook()
        {
            SafeRemoteHandle codeptr_ = new SafeRemoteHandle(0x1000);
            SafeRemoteHandle objptr_ = new SafeRemoteHandle(0x1000);

            IntPtr hookptr = (IntPtr)0x1403D08AD;
            IntPtr returnptr = (IntPtr)0x1403d0b57;
            IntPtr codeptr = codeptr_.GetHandle();
            objptr = objptr_.GetHandle();

            for (int x = 0; x < (objptr_.Size / 8); x++)
                WUInt64(objptr + 8 * x, 0);

            var c = new Assembler(64);

            Label startloop = c.CreateLabel();
            Label endloop = c.CreateLabel();

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
            c.sub(rsp, 0x108);

            c.mov(rsi, (ulong)objptr);

            c.Label(ref startloop);

            c.xor(r8, r8);
            c.cmp(__[rsi],r8);
            c.je(endloop);  //if out of code pointers, end loop

            c.call(__qword_ptr[rsi]);
            c.add(rsi, 8);
            c.jmp(startloop);

            c.Label(ref endloop);

            c.add(rsp, 0x108);
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

            c.jmp((ulong)returnptr);

            var stream = new MemoryStream();
            c.Assemble(new StreamCodeWriter(stream), (ulong)codeptr);
            WBytes(codeptr, stream.ToArray());

            c = new Assembler(64);
            c.PreferVex = false;
            c.jmp((ulong)codeptr);

            stream = new MemoryStream();
            c.Assemble(new StreamCodeWriter(stream), (ulong)hookptr);
            WBytes(hookptr, stream.ToArray());

        }
    }
}
