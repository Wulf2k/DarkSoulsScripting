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
        
        public static IntPtr Address => RIntPtr(0x141D151F8);

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
    }
}
