using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class MenuMan
    {
        //DSR 1.03

        public static IntPtr Address => RIntPtr(0x141D26168);

        public static MenuGenDlg GenDlg { get; private set; } = null;

        static MenuMan()
        {
            GenDlg = new MenuGenDlg() { AddressReadFunc = () => RIntPtr(Address + 0xA38) };
        
        }

        public static bool DrawLayoutOnCursor
        {
            get { return RBool(Address + 0x2C); }
            set { WBool(Address + 0x2C, value); }
        }
        public static bool DrawLayoutOnlyLast
        {
            get { return RBool(Address + 0x2D); }
            set { WBool(Address + 0x2D, value); }
        }
        public static bool DrawLayoutDispPos
        {
            get { return RBool(Address + 0x2E); }
            set { WBool(Address + 0x2E, value); }
        }
        public static bool DrawLayoutOnlyRegistered
        {
            get { return RBool(Address + 0x2F); }
            set { WBool(Address + 0x2F, value); }
        }
        public static Int32 GenDialogState
        {
            get { return RInt32(Address + 0x74); }
            set { WInt32(Address + 0x74, value); }
        }
        public static Int32 TextEffect
        {
            get { return RInt32(Address + 0x104); }
            set { WInt32(Address + 0x104, value); }
        }

    }
}
