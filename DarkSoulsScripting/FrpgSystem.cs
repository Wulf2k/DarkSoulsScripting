using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class FrpgSystem
    {
        //DSR 1.03
        public static IntPtr Address => RIntPtr(0x141c04e28);

        public static class Sys
        {
            public static IntPtr Address => RIntPtr(RIntPtr(FrpgSystem.Address + 0x8) + 0x20);
            public static int Step
            {
                get => RInt32(Address + 0x10);
                set => WInt32(Address + 0x10, value);
            }
        }
        public static class Title
        {
            public static IntPtr Address => RIntPtr(RIntPtr(Sys.Address + 0x58) + 0x20);
            public static int Step
            {
                get => RInt32(Address + 0x10);
                set => WInt32(Address + 0x10, value);
            }
        }
        public static class InGame
        {
            public static IntPtr Address => RIntPtr(Title.Address + 0xA0);
            public static int Step
            {
                get => RInt32(Address + 0x10);
                set => WInt32(Address + 0x10, value);
            }
        }
        public static class InGameStay
        {
            public static IntPtr Address => RIntPtr(InGame.Address + 0x28);
            public static int Step
            {
                get => RInt32(Address + 0x10);
                set => WInt32(Address + 0x10, value);
            }
        }
        public static class CommonMenu
        {
            public static IntPtr Address => RIntPtr(RIntPtr(InGame.Address + 0x5ae8) + 0x20);
            public static int Step
            {
                get => RInt32(Address + 0x10);
                set => WInt32(Address + 0x10, value);
            }
        }
    }
}
