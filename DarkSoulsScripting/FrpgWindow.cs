using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class FrpgWindow
    {
        //DSR 1.03
        public static IntPtr Address => RIntPtr(0x141d06ef8);
        
        public static int Width
        {
            get => RInt32(Address + 0x34);
            set => WInt32(Address + 0x34, value);
        }

        public static int Height
        {
            get => RInt32(Address + 0x38);
            set => WInt32(Address + 0x38, value);
        }

        public static bool LockMouseToWindow
        {
            get => RBool(Address + 0x6C);
            set => WBool(Address + 0x6C, value);
        }
    }
}
