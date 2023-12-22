using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class MapItemMan
    {
        //DSR1310
        public static IntPtr Address => Hook.RIntPtr(0x141c7a0c8);

        public static Int32 NumItemBags
        {
            get { return RInt32(Address + 0x18); }
            set { WInt32(Address + 0x18, value); }
        }

        public static IntPtr LastItemPtr
        {
            get { return RIntPtr(Address + 0x20); }
            set { WIntPtr(Address + 0x20, value); }
        }
        public static IntPtr FirstItemPtr
        {
            get { return RIntPtr(Address + 0x28); }
            set { WIntPtr(Address + 0x28, value); }
        }

        public static bool DbgDispDropItem
        {
            get { return RBool(Address + 0xC8); }
            set { WBool(Address + 0xC8, value); }
        }
    }
}
