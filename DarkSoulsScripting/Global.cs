using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class Global
    {
        //DSR 1.03
        //TODO:1310
        public static IntPtr Address => RIntPtr((0x1378560, 0, 0x141D19958));


        public static byte AreaID
        {
            //DSR
            get { return RByte(Address + 0xB); }
            set { WByte(Address + 0xB, value); }
        }

        public static byte BlockID
        {
            //DSR
            get { return RByte(Address + 0xA); }
            set { WByte(Address + 0xA, value); }
        }

        public static bool IsAliveMotion
        {
            //DSR
            get { return RBool(Address + 0x24); }
            set { WBool(Address + 0x1C, value); }
        }

        public static bool IsReviveWait
        {
            //DSR
            get { return RBool(Address + 0x27); }
            set { WBool(Address + 0x1F, value); }
        }
    }
}
