using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class WorldChrManDbg
    {
        //DSR1310
        public static IntPtr Address => RIntPtr(0x141c77e88);

        public static IntPtr WorldInfoOwner
        {
            get => RIntPtr(Address + 0x10);
            set => WIntPtr(Address + 0x10, value);
        }

        public static bool AllDrawHit
        {
            get => RBool(Address + 0x39);
            set => WBool(Address + 0x39, value);
        }

        public static IntPtr DbgViewChrIns
        {
            get => RIntPtr(Address + 0xf0);
            set => WIntPtr(Address + 0xf0, value);
        }
    }
}
