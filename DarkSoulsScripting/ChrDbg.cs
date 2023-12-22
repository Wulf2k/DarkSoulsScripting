using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class ChrDbg
    {
        //DSR 1.03, all funcs updated.

        //DSR1310
        public static IntPtr Address => Hook.RIntPtr(0x141c77e88); //WorldChrManDbgImp


        public static bool AllDrawHit
        {
            get => RBool(Address + 0x39);
            set => WBool(Address + 0x39, value);
        }
        public static bool NewKnockBackMode
        {
            get { return RBool(Address + 0xDC); }
            set { WBool(Address + 0xDC, value); }
        }

        public static bool PlayerNoDead
        {
            //DSR1310
            get { return RBool((0x13784D2, 0, 0x141c77e59)); }
            set => WBool((0x13784D2, 0, 0x141c77e59), value);
        }

        public static bool PlayerExterminate
        {
            //DSR1310
            get { return RBool((0x13784D3, 0, 0x141c77e5a)); }
            set { WBool((0x13784D3, 0, 0x141c77e5a), value); }
        }

        public static bool AllNoStaminaConsume
        {
            //DSR1310
            get { return RBool((0x13784E4, 0, 0x141c77e5b)); }
            set { WBool((0x13784E4, 0, 0x141c77e5b), value); }
        }

        public static bool AllNoMPConsume
        {
            //DSR1310
            get { return RBool((0x13784E5, 0, 0x141c77e5c)); }
            set { WBool((0x13784E5, 0, 0x141c77e5c), value); }
        }

        public static bool AllNoArrowConsume
        {
            //DSR1310
            get { return RBool((0x13784E6, 0, 0x141c77e5d)); }
            set { WBool((0x13784E6, 0, 0x141c77e5d), value); }
        }

        public static bool AllNoMagicQtyConsume
        {
            //DSR1310
            get { return RBool((0x1376EE7, 0, 0x141c77e5e)); }
            set { WBool((0x1376EE7, 0, 0x141c77e5e), value); }
        }

        public static bool PlayerHide
        {
            //DSR1310
            get { return RBool((0x13784e7, 0, 0x141c77e5f)); }
            set { WBool((0x13784e7, 0, 0x141c77e5f), value); }
        }

        public static bool PlayerSilence
        {
            //DSR1310
            get { return RBool((0x13784E8, 0, 0x141c77e60)); }
            set { WBool((0x13784E8, 0, 0x141c77e60), value); }
        }

        public static bool AllNoDead
        {
            //DSR1310
            get { return RBool((0x13784e9, 0, 0x141c77e61)); }
            set { WBool((0x13784e9, 0, 0x141c77e61), value); }
        }

        public static bool AllNoDamage
        {
            //DSR1310
            get { return RBool((0x13784EA, 0, 0x141c77e62)); }
            set { WBool((0x13784EA, 0, 0x141c77e62), value); }
        }

        public static bool AllNoHit
        {
            //DSR1310
            get { return RBool((0x13784EB, 0, 0x141c77e63)); }
            set { WBool((0x13784EB, 0, 0x141c77e63), value); }
        }

        public static bool AllNoAttack
        {
            //DSR1310
            get { return RBool((0x13784EC, 0, 0x141c77e64)); }
            set { WBool((0x13784EC, 0, 0x141c77e64), value); }
        }

        public static bool AllNoMove
        {
            //DSR1310
            get { return RBool((0x13784ED, 0, 0x141c77e65)); }
            set { WBool((0x13784ED, 0, 0x141c77e65), value); }
        }

        public static bool AllNoUpdateAI
        {
            //DSR1310
            get { return RBool((0x13784EE, 0, 0x141c77e66)); }
            set { WBool((0x13784EE, 0, 0x141d151d6), value); }
        }
        public static bool AllOmissionMode
        {
            //DSR1310
            get { return RBool((0x13784EE, 0, 0x141c77e68)); }
            set { WBool((0x13784EE, 0, 0x141c77e68), value); }
        }
        public static bool PlayerReload
        {
            //DSR1310
            get { return RBool((0x13784EE, 0, 0x141c77e6b)); }
            set { WBool((0x13784EE, 0, 0x141c77e6b), value); }
        }
        public static bool ShowCompass
        {
            //DSR1310
            get => RBool(0x141c7a061);
            set => WBool(0x141c7a061, value);
        }
        public static bool ShowAltimeter
        {
            //DSR1310
            get => RBool(0x141c7a062);
            set => WBool(0x141c7a062, value);
        }
        public static bool ShowHeading
        {
            //DSR1310
            get => RBool(0x141c7a063);
            set => WBool(0x141c7a063, value);
        }
    }
}
