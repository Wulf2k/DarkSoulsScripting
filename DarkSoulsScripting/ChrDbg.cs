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


        public static IntPtr Address => Hook.RIntPtr(0x141D151F8);


        public static bool AllDrawHit
        {
            get { return RBool(Address + 0x39); }
            set { WBool(Address + 0x39, value); }
        }
        public static bool NewKnockBackMode
        {
            get { return RBool(Address + 0xDC); }
            set { WBool(Address + 0xDC, value); }
        }

        public static bool PlayerNoDead
        {
            //DSR
            get { return RBool((0x13784D2, 0, 0x141d151c9)); }
            set { WBool((0x13784D2, 0, 0x141d151c9), value); }
        }

        public static bool PlayerExterminate
        {
            //DSR
            get { return RBool((0x13784D3, 0, 0x141d151ca)); }
            set { WBool((0x13784D3, 0, 0x141d151ca), value); }
        }

        public static bool AllNoStaminaConsume
        {
            //DSR
            get { return RBool((0x13784E4, 0, 0x141D151cb)); }
            set { WBool((0x13784E4, 0, 0x141D151cb), value); }
        }

        public static bool AllNoMPConsume
        {
            //DSR
            get { return RBool((0x13784E5, 0, 0x141D151cc)); }
            set { WBool((0x13784E5, 0, 0x141D151cc), value); }
        }

        public static bool AllNoArrowConsume
        {
            //DSR
            get { return RBool((0x13784E6, 0, 0x141d151cd)); }
            set { WBool((0x13784E6, 0, 0x141d151cd), value); }
        }

        public static bool AllNoMagicQtyConsume
        {
            //DSR
            get { return RBool((0x1376EE7, 0, 0x141d151ce)); }
            set { WBool((0x1376EE7, 0, 0x141d151ce), value); }
        }

        public static bool PlayerHide
        {
            //DSR
            get { return RBool((0x13784e7, 0, 0x141d151cf)); }
            set { WBool((0x13784e7, 0, 0x141d151cf), value); }
        }

        public static bool PlayerSilence
        {
            //DSR
            get { return RBool((0x13784E8, 0, 0x141d151d0)); }
            set { WBool((0x13784E8, 0, 0x141d151d0), value); }
        }

        public static bool AllNoDead
        {
            //DSR
            get { return RBool((0x13784e9, 0, 0x141d151d1)); }
            set { WBool((0x13784e9, 0, 0x141d151d1), value); }
        }

        public static bool AllNoDamage
        {
            //DSR
            get { return RBool((0x13784EA, 0, 0x141d151d2)); }
            set { WBool((0x13784EA, 0, 0x141d151d2), value); }
        }

        public static bool AllNoHit
        {
            //DSR
            get { return RBool((0x13784EB, 0, 0x141d151d3)); }
            set { WBool((0x13784EB, 0, 0x141d151d3), value); }
        }

        public static bool AllNoAttack
        {
            //DSR
            get { return RBool((0x13784EC, 0, 0x141d151d4)); }
            set { WBool((0x13784EC, 0, 0x141d151d4), value); }
        }

        public static bool AllNoMove
        {
            //DSR
            get { return RBool((0x13784ED, 0, 0x141d151d5)); }
            set { WBool((0x13784ED, 0, 0x141d151d5), value); }
        }

        public static bool AllNoUpdateAI
        {
            //DSR
            get { return RBool((0x13784EE, 0, 0x141d151d6)); }
            set { WBool((0x13784EE, 0, 0x141d151d6), value); }
        }
        public static bool AllOmmissionMode
        {
            //DSR
            get { return RBool((0x13784EE, 0, 0x141d151d8)); }
            set { WBool((0x13784EE, 0, 0x141d151d8), value); }
        }
        public static bool PlayerReload
        {
            //DSR
            get { return RBool((0x13784EE, 0, 0x141d151db)); }
            set { WBool((0x13784EE, 0, 0x141d151db), value); }
        }
        public static bool ShowCompass
        {
            //DSR
            get => RBool(0x141D173D1);
            set => WBool(0x141D173D1, value);
        }
        public static bool ShowAltimeter
        {
            //DSR
            get => RBool(0x141D173D2);
            set => WBool(0x141D173D2, value);
        }
        public static bool ShowHeading
        {
            //DSR
            get => RBool(0x141D173D3);
            set => WBool(0x141D173D3, value);
        }
    }
}
