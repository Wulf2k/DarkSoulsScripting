using static Iced.Intel.AssemblerRegisters;
using Iced.Intel;
using static DarkSoulsScripting.Hook;
using DarkSoulsScripting.Injection.Structures;
using System.IO;
using System;
using System.Numerics;
using System.Drawing;
using System.Collections.Generic;
using System.Threading;

namespace DarkSoulsScripting
{
    public class EzDrawHook
    {
        static EzDrawHook()
        {

        }
        public static class ObjMgr
        {
            public static List<EzObj> ObjList;

            static ObjMgr()
            {
                ObjList = new List<EzObj>();

                Console.WriteLine($@"ObjPtr: {objptr.ToString("X")}");
            }
            public static void Add(EzObj Obj)
            {
                var t = new Thread(() => DelayedAdd(Obj));
                t.Start();
                
            }
            static void DelayedAdd(EzObj Obj)
            {
                Thread.Sleep(33);
                ObjList.Add(Obj);
                WIntPtr(objptr + (ObjList.Count - 1) * 0x8, Obj.codeptr);
            }
            public static void Remove(EzObj Obj)
            {
                int objPos = ObjList.IndexOf(Obj);
                ObjList.RemoveAt(Obj.objId);

                for (int x = objPos; x <= ObjList.Count; x++)
                {
                    WIntPtr(objptr + x * 8, RIntPtr(objptr + (x + 1) * 8));
                }

                Obj.codeptr_.Release();
                Obj.valptr_.Release();

                Obj.codeptr_ = null;
                Obj.valptr_ = null;

                Obj.codeptr = IntPtr.Zero;
                Obj.valptr = IntPtr.Zero;

                Obj = null;

            }
        }

        public class EzObj
        {
            public int objId;

            public SafeRemoteHandle codeptr_;
            public SafeRemoteHandle valptr_;
            public IntPtr codeptr;
            public IntPtr valptr;
            public IntPtr EzDraw_DrawFunc;
            public ulong obj_r8 = 0;
            public ulong obj_rdx = 0;

            public EzObj()
            {

                codeptr_ = new SafeRemoteHandle(0x1000);
                valptr_ = new SafeRemoteHandle(0x1000);

                codeptr = codeptr_.GetHandle();
                valptr = valptr_.GetHandle();

                obj_r8 = (ulong)valptr + 0x130;
                obj_rdx = (ulong)valptr + 0x90;

                UseColor1 = true;
                UseColor2 = true;
                IgnoreCulling = true;

                Color1 = Color.Red;
                Color2 = Color.Blue;

                TexStartOffsetX = 0;
                TexStartOffsetY = 0;
                TexShowPortionX = 1.0f;
                TexShowPortionY = 1.0f;

                objId = ObjMgr.ObjList.Count;
                ObjMgr.Add(this);
            }
            public uint Flags
            {
                get { return RUInt32(valptr + 0x10); }
                set { WUInt32(valptr + 0x10, value); }
            }
            public uint TexHandle
            {
                get { return RUInt32(valptr + 0x14); }
                set { WUInt32(valptr + 0x14, value); }
            }
            public uint State
            {
                get { return RUInt32(valptr + 0x18); }
                set { WUInt32(valptr + 0x18, value); }
            }


            public bool UseColor1
            {
                get { return RBit(valptr + 0x10, 3); }
                set { WBit(valptr + 0x10, 3, value); } 
            }
            public bool UseColor2
            {
                get { return RBit(valptr + 0x10, 2); }
                set { WBit(valptr + 0x10, 2, value); }
            }

            public bool IgnoreCulling
            {
                get { return RBit(valptr + 0x18, 6); }
                set { WBit(valptr + 0x18, 6, value); }
            }

            public bool UseWireFrame
            {
                get { return RBit(valptr + 0x1c, 4) && (RByte(valptr + 0x1c) > 0); }
                set
                {
                    WByte(valptr + 0x1c, value ? (byte)1 : (byte)0);
                    WBit(valptr + 0x10, 4, value);
                }
            }

            public Color Color1
            {
                get
                {
                    Vector4 col = RVector4(valptr + 0x20);
                    return Color.FromArgb((int)col.X, (int)col.Y, (int)col.Z, (int)col.W);
                }
                set
                {
                    WFloat(valptr + 0x20, (float)value.R / (float)255);
                    WFloat(valptr + 0x24, (float)value.G / (float)255);
                    WFloat(valptr + 0x28, (float)value.B / (float)255);
                    WFloat(valptr + 0x2c, (float)value.A / (float)255);
                }
            }
            public Color Color2
            {
                get
                {
                    Vector4 col = RVector4(valptr + 0x30);
                    return Color.FromArgb((int)col.X, (int)col.Y, (int)col.Z, (int)col.W);
                }
                set
                {
                    WFloat(valptr + 0x30, (float)value.R / (float)255);
                    WFloat(valptr + 0x34, (float)value.G / (float)255);
                    WFloat(valptr + 0x38, (float)value.B / (float)255);
                    WFloat(valptr + 0x3c, (float)value.A / (float)255);
                }
            }

            public uint TexStartOffsetX
            {
                get { return RUInt32(valptr + 0x120); }
                set { WUInt32(valptr + 0x120, value); }
            }
            public uint TexStartOffsetY
            {
                get { return RUInt32(valptr + 0x124); }
                set { WUInt32(valptr + 0x124, value); }
            }
            public float TexShowPortionX
            {
                get { return RFloat(valptr + 0x128); }
                set { WFloat(valptr + 0x128, value); }
            }
            public float TexShowPortionY
            {
                get { return RFloat(valptr + 0x12c); }
                set { WFloat(valptr + 0x12c, value); }
            }



            public void InitCode()
            {
                IntPtr HgManPtr = HgMan.Address;
                IntPtr EzDrawPtr = RIntPtr(HgManPtr + 0x60);
                IntPtr EzDrawStatePtr = RIntPtr(EzDrawPtr + 0x48);
                

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

                c.movaps(xmm0, __[(ulong)valptr + 0x10]);
                c.movaps(__[r12 + 0x10], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x20]);
                c.movaps(__[r12 + 0x20], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x30]);
                c.movaps(__[r12 + 0x30], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x40]);
                c.movaps(__[r12 + 0x40], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x50]);
                c.movaps(__[r12 + 0x50], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x60]);
                c.movaps(__[r12 + 0x60], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x70]);
                c.movaps(__[r12 + 0x70], xmm0);

                c.movaps(xmm0, __[(ulong)valptr + 0x80]);
                c.movaps(__[r12 + 0x80], xmm0);

                c.lea(rdx, __[(ulong)valptr + 0x90]);

                c.movaps(xmm0, __[(ulong)valptr + 0x90]);
                c.movaps(xmm1, __[(ulong)valptr + 0xa0]);
                c.movaps(xmm2, __[(ulong)valptr + 0xb0]);
                c.movaps(xmm3, __[(ulong)valptr + 0xc0]);
                c.movaps(xmm4, __[(ulong)valptr + 0xd0]);
                c.movaps(xmm5, __[(ulong)valptr + 0xe0]);
                c.movaps(xmm6, __[(ulong)valptr + 0xf0]);
                c.movaps(xmm7, __[(ulong)valptr + 0x100]);
                c.movaps(xmm8, __[(ulong)valptr + 0x110]);

                

                c.sub(rsp, 0x78);
                c.mov(r8, (ulong)valptr + 0x120);
                c.mov(r8, __[r8]);
                c.mov(__qword_ptr[rsp + 0x28], r8);

                c.mov(r8, (ulong)valptr + 0x124);
                c.mov(r8, __[r8]);
                c.mov(__qword_ptr[rsp + 0x30], r8);

                c.mov(r8, (ulong)valptr + 0x128);
                c.mov(r8, __[r8]);
                c.mov(__qword_ptr[rsp + 0x38], r8);

                c.mov(r8, (ulong)valptr + 0x12c);
                c.mov(r8, __[r8]);
                c.mov(__qword_ptr[rsp + 0x40], r8);


                c.mov(r8, obj_r8);
                c.mov(rdx, obj_rdx);

                c.add(rsp, 8);

                c.call((ulong)EzDraw_DrawFunc);

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
            public void Cleanup()
            {
                if (objId > -1)
                {
                    ObjMgr.Remove(this);
                    objId = -1;
                }
                
            }
        }

        public class Box : EzObj
        {
            public Box()
            {
                EzDraw_DrawFunc = (IntPtr)0x1401d69e0;

                TexHandle = 0;
                Color1 = Color.Black;
                Color2 = Color.Black;

                Flags = 0x37;
                State = 7;

                InitCode();
            }
            public Vector2 Pos
            {
                get { return RVector2(valptr + 0x90); }
                set
                {
                    WVector2(valptr + 0x90, new Vector2((int)value.X + Size.X / 2, (int)value.Y + Size.Y / 2));
                }
            }
            public float Depth
            {
                get { return RFloat(valptr + 0x9c); }
                set { WFloat(valptr + 0x9c, value); }
            }
            public Vector2 Size
            {
                get { return new Vector2(RFloat(valptr + 0xb0), RFloat(valptr + 0xc0)); }
                set
                {
                    Vector2 startSize = Size;
                    WFloat(valptr + 0xb0, (int)value.X);
                    WFloat(valptr + 0xc0, (int)value.Y);

                    //adjust pos to maintain topleft positioning
                    WVector2(valptr + 0x90, new Vector2(Pos.X - (startSize.X - value.X) / 2, Pos.Y - (startSize.Y - value.Y) / 2));

                }
            }
        }
        public class Cylinder : EzObj
        {
            public Cylinder()
            {
                EzDraw_DrawFunc = (IntPtr)0x1401d6750;

                Flags = 0x3e;

                Color1 = Color.Red;
                Color2 = Color.Blue;

                Pos = new Vector3(800, 500, 0);
                Size = new Vector3(10, 10, 10);

                UseWireFrame = false;

                InitCode();
            }

            public Vector3 Size
            {
                get { return new Vector3(RFloat(valptr + 0x90), RFloat(valptr + 0xa4), RFloat(valptr + 0xb8)); }
                set
                {
                    WFloat(valptr + 0x90, (int)value.X);
                    WFloat(valptr + 0xa4, (int)value.Y);
                    WFloat(valptr + 0xb8, (int)value.Z);
                }
            }

            public Vector3 Pos
            {
                get { return new Vector3(RFloat(valptr + 0x9c), RFloat(valptr + 0xac), RFloat(valptr + 0xbc)); }
                set
                {
                    WFloat(valptr + 0x9c, (int)value.X);
                    WFloat(valptr + 0xac, (int)value.Y);
                    WFloat(valptr + 0xbc, (int)value.Z);
                }
            }
        }
        public class Text : EzObj
        {
            public Text()
            {
                EzDraw_DrawFunc = (IntPtr)0x1401d6bf0;

                TexHandle = 0;
                Stretch = new Vector2(1, 1);

                Txt = "NewString";

                UseStretch = true;
                UseFontSize = true;
                UseTextColor = true;

                TextColor = Color.White;
                Size = 14;

                InitCode();
            }

            public bool UseFontSize
            {
                get { return RBit(valptr + 0x10, 15); }
                set { WBit(valptr + 0x10, 15, value); }
            }
            public bool UseStretch
            {
                get { return RBit(valptr + 0x10, 14); }
                set { WBit(valptr + 0x10, 14, value); }
            }
            public bool UseTextColor
            {
                get { return RBit(valptr + 0x10, 13); }
                set { WBit(valptr + 0x10, 13, value); }
            }
            public Color TextColor
            {
                get { return Color.FromArgb(RInt32(valptr + 0x74)); }
                set { WInt32(valptr + 0x74, value.ToArgb()); }
            }
            public float Size
            {
                get { return RFloat(valptr + 0x78); }
                set { WFloat(valptr + 0x78, (int)value); }
            }
            public Vector2 Stretch
            {
                get { return RVector2(valptr + 0x7c); }
                set { WVector2(valptr + 0x7c, new Vector2((int)value.X, (int)value.Y)); }
            }
            public Vector2 Pos
            {
                get { return RVector2(valptr + 0x90); }
                set { WVector2(valptr + 0x90, new Vector2((int)value.X, (int)value.Y)); }
            }
            public string Txt
            {
                get { return RUnicodeStr(valptr + 0x130, 0x40); }
                set { WUnicodeStr(valptr + 0x130, value); }
            }
        }
        public class Sphere : EzObj
        {
            public Sphere()
            {
                EzDraw_DrawFunc = (IntPtr)0x1401d6640;

                Flags = 0x3e;
                State = 5;

                Color1 = Color.Blue;
                Color2 = Color.Green;

                Pos = new Vector3(800, 500, 0);
                Size = new Vector3(10, 10, 10);

                UseWireFrame = false;

                InitCode();
            }

            public Vector3 Size
            {
                get { return new Vector3(RFloat(valptr + 0x90), RFloat(valptr + 0xa4), RFloat(valptr + 0xb8)); }
                set {
                    WFloat(valptr + 0x90, (int)value.X);
                    WFloat(valptr + 0xa4, (int)value.Y);
                    WFloat(valptr + 0xb8, (int)value.Z);
                }
            }

            public Vector3 Pos
            {
                get { return new Vector3(RFloat(valptr + 0x9c), RFloat(valptr + 0xac), RFloat(valptr + 0xbc)); }
                set
                {
                    WFloat(valptr + 0x9c, (int)value.X);
                    WFloat(valptr + 0xac, (int)value.Y);
                    WFloat(valptr + 0xbc, (int)value.Z);
                }
            }
        }

        public class unkDraw : EzObj
        {
            public unkDraw()
            {
                EzDraw_DrawFunc = (IntPtr)0x1401d6980;

                Flags = 0x37;
                State = 5;

                Color1 = Color.White;
                Color2 = Color.White;

                Pos = FrpgWindow.DisplaySize * new Vector2(0.75f, 0.75f);
                Size = FrpgWindow.DisplaySize * new Vector2(0.5f, 0.5f);

                TexHandle = 0x80000011;

                UseWireFrame = false;

                InitCode();
            }
            public Vector2 Pos
            {
                get { return RVector2(valptr + 0x90); }
                set { WVector2(valptr + 0x90, value); }
            }
            public Vector2 Size
            {
                get { return new Vector2(RFloat(valptr + 0xb0), RFloat(valptr + 0xc0)); }
                set
                {
                    WFloat(valptr + 0xb0, value.X);
                    WFloat(valptr + 0xc0, value.Y);
                }
            }
        }

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
        public static void Hook2()
        {
            //shitty, flickers
            SafeRemoteHandle codeptr_ = new SafeRemoteHandle(0x1000);
            SafeRemoteHandle objptr_ = new SafeRemoteHandle(0x1000);

            IntPtr hookptr = (IntPtr)0x1411ca3f0;
            IntPtr returnptr = (IntPtr)0x1411ca400;
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
            c.sub(rsp, 0x100);

            c.mov(rsi, (ulong)objptr);

            c.Label(ref startloop);

            c.xor(r8, r8);
            c.cmp(__[rsi], r8);
            c.je(endloop);  //if out of code pointers, end loop

            c.call(__qword_ptr[rsi]);
            c.add(rsi, 8);
            c.jmp(startloop);

            c.Label(ref endloop);

            c.add(rsp, 0x100);
            c.popfq();
            c.pop(r15);
            c.pop(r14);
            c.pop(r13);
            c.pop(r12);
            c.pop(r11);
            c.pop(r10);
            c.pop(r9);
            c.pop(r8);
            c.pop(rdi);
            c.pop(rsi);
            c.pop(rbp);
            c.pop(rdx);
            c.pop(rcx);
            c.pop(rbx);
            c.pop(rax);


            //Run asm destroyed by hook
            c.mov(__[rsp + 0x10], rdx);
            c.push(rbp);
            c.push(rsi);
            c.push(rdi);
            c.push(r12);
            c.push(r13);
            c.push(r14);
            c.push(r15);


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
        public static void Hook3()
        {
            //shitty, flickers
            SafeRemoteHandle codeptr_ = new SafeRemoteHandle(0x1000);
            SafeRemoteHandle objptr_ = new SafeRemoteHandle(0x1000);

            IntPtr hookptr = (IntPtr)0x14015f060;
            IntPtr returnptr = (IntPtr)0x14015f070;
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
            c.sub(rsp, 0x100);

            c.mov(rsi, (ulong)objptr);

            c.Label(ref startloop);

            c.xor(r8, r8);
            c.xor(r9, r9);
            c.cmp(__[rsi], r8);
            c.je(endloop);  //if out of code pointers, end loop

            c.mov(r9, __[rsi]);
            c.cmp(r8, r9);
            c.je(startloop);  //skip this one if no code at dest

            c.call(__qword_ptr[rsi]);
            c.add(rsi, 8);
            c.jmp(startloop);

            c.Label(ref endloop);

            c.add(rsp, 0x100);
            c.popfq();
            c.pop(r15);
            c.pop(r14);
            c.pop(r13);
            c.pop(r12);
            c.pop(r11);
            c.pop(r10);
            c.pop(r9);
            c.pop(r8);
            c.pop(rdi);
            c.pop(rsi);
            c.pop(rbp);
            c.pop(rdx);
            c.pop(rcx);
            c.pop(rbx);
            c.pop(rax);


            //Run asm destroyed by hook
            c.mov(rax, rsp);
            c.push(rdi);
            c.push(r12);
            c.push(r13);
            c.push(r14);
            c.push(r15);
            c.sub(rsp, 0x70);


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
