using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class MouseMan
    {
        //DSR 1.03
        public static IntPtr Address => RIntPtr(0x141d06ee8);

        public static bool LClick
        {
            get => RBool(Address + 0x12);
            set => WBool(Address + 0x12, value);
        }
        public static float SecsLClickHeld
        {
            get => RFloat(Address + 0x14);
            set => WFloat(Address + 0x14, value);
        }
        public static bool RClick
        {
            get => RBool(Address + 0x1A);
            set => WBool(Address + 0x1A, value);
        }
        public static float SecsRClickHeld
        {
            get => RFloat(Address + 0x1C);
            set => WFloat(Address + 0x1C, value);
        }
        public static bool MClick
        {
            get => RBool(Address + 0x22);
            set => WBool(Address + 0x22, value);
        }
        public static float SecsMClickHeld
        {
            get => RFloat(Address + 0x24);
            set => WFloat(Address + 0x24, value);
        }
        public static int X
        {
            get => RInt32(Address + 0x28);
            set => WInt32(Address + 0x28, value);

        }
        public static int Y
        {
            get => RInt32(Address + 0x2C);
            set => WInt32(Address + 0x2C, value);

        }
        public static int MWheel
        {
            get => RInt32(Address + 0x3C);
            set => WInt32(Address + 0x3C, value);

        }

    }
}
