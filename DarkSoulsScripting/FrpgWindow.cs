using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class FrpgWindow
    {
        //DSR 1.03
        public static IntPtr Address => RIntPtr(0x141d06ef8);

        public static Vector2 WindowSize
        {
            get => new Vector2(RInt32(Address + 0x34), RInt32(Address + 0x38));
        }

        public static Vector2 DisplaySize
        {
            get => new Vector2(RInt32(Address + 0x50), RInt32(Address + 0x54));
        }

        public static bool LockMouseToWindow
        {
            get => RBool(Address + 0x6C);
            set => WBool(Address + 0x6C, value);
        }
    }
}
