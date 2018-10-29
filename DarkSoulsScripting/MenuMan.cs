using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DarkSoulsScripting
{
    public class MenuMan
    {
        //DSR 1.03

        public static IntPtr Address => Hook.RIntPtr(0x141D26168);

        public static bool DrawLayoutOnCursor
        {
            get { return Hook.RBool(Address + 0x2C); }
            set { Hook.WBool(Address + 0x2C, value); }
        }
        public static bool DrawLayoutOnlyLast
        {
            get { return Hook.RBool(Address + 0x2D); }
            set { Hook.WBool(Address + 0x2D, value); }
        }
        public static bool DrawLayoutDispPos
        {
            get { return Hook.RBool(Address + 0x2E); }
            set { Hook.WBool(Address + 0x2E, value); }
        }
        public static bool DrawLayoutOnlyRegistered
        {
            get { return Hook.RBool(Address + 0x2F); }
            set { Hook.WBool(Address + 0x2F, value); }
        }

    }
}
