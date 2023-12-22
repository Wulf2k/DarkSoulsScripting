using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class HgMan
    {
        //DSR1310
        public static IntPtr Address => RIntPtr(0x141b68ec8);

        public static IntPtr MenuRend
        {
            get => RIntPtr(Address + 0x6e0);
            set => WIntPtr(Address + 0x6e0, value);
        }

        public static Vector2 ScreenSize
        {
            get => RVector2(RIntPtr(Address + 0x6f0));
            set => WVector2(RIntPtr(Address + 0x6f0), value);
        }

    public static float ScreenWidth
        {
            get => RFloat(RIntPtr(Address + 0x6f0));
            set => WFloat(RIntPtr(Address + 0x6f0), value);
        }
        public static float ScreenHeight
        {
            get => RFloat(RIntPtr(Address + 0x6f0) + 0x4);
            set => WFloat(RIntPtr(Address + 0x6f0) + 0x4, value);
        }

        public static byte GammaTest
        {
            get => RByte(Address + 0x760);
            set => WByte(Address + 0x760, value);
        }

    }
}
