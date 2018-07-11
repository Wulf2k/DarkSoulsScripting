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
        public static bool AllNoMagicQtyConsume
        {
            get { return RBool(0x1376EE7); }
            set { WBool(0x1376EE7, value); }
        }

        public static bool PlayerNoDead
        {
            //DSR
            get { return RBool((0x13784D2, 0, 0x141d01fd9)); }
            set { WBool((0x13784D2, 0, 0x141d01fd9), value); }
        }

        public static bool PlayerExterminate
        {
            //DSR
            get { return RBool((0x13784D3, 0, 0x141d01fDB)); }
            set { WBool((0x13784D3, 0, 0x141d01fDB), value); }
        }

        public static bool AllNoStaminaConsume
        {
            get { return RBool(0x13784E4); }
            set { WBool(0x13784E4, value); }
        }

        public static bool AllNoMPConsume
        {
            get { return RBool(0x13784E5); }
            set { WBool(0x13784E5, value); }
        }

        public static bool AllNoArrowConsume
        {
            get { return RBool(0x13784E6); }
            set { WBool(0x13784E6, value); }
        }

        public static bool PlayerHide
        {
            //DSR
            get { return RBool((0x13784e7, 0, 0x141d01fdf)); }
            set { WBool((0x13784e7, 0, 0x141d01fdf), value); }
        }

        public static bool PlayerSilence
        {
            //DSR
            get { return RBool((0x13784E8, 0, 0x141d01fe0)); }
            set { WBool((0x13784E8, 0, 0x141d01fe0), value); }
        }

        public static bool AllNoDead
        {
            //DSR
            get { return RBool((0x13784e9, 0, 0x141d01fe1)); }
            set { WBool((0x13784e9, 0, 0x141d01fe1), value); }
        }

        public static bool AllNoDamage
        {
            //DSR
            get { return RBool((0x13784EA, 0, 0x141d01fe2)); }
            set { WBool((0x13784EA, 0, 0x141d01fe2), value); }
        }

        public static bool AllNoHit
        {
            //DSR
            get { return RBool((0x13784EB, 0, 0x141d01fe3)); }
            set { WBool((0x13784EB, 0, 0x141d01fe3), value); }
        }

        public static bool AllNoAttack
        {
            //DSR
            get { return RBool((0x13784EC, 0, 0x141d01fe4)); }
            set { WBool((0x13784EC, 0, 0x141d01fe4), value); }
        }

        public static bool AllNoMove
        {
            //DSR
            get { return RBool((0x13784ED, 0, 0x141d01fe5)); }
            set { WBool((0x13784ED, 0, 0x141d01fe5), value); }
        }

        public static bool AllNoUpdateAI
        {
            //DSR
            get { return RBool((0x13784EE, 0, 0x141d01fe6)); }
            set { WBool(0x13784EE, value); }
        }

        public static bool DisplayMiniCompass
        {
            get { return RBool(0x137851B); }
            set { WBool(0x137851B, value); }
        }

        public static bool DisplayHeightMarker
        {
            get { return RBool(0x1378524); }
            set { WBool(0x1378524, value); }
        }

        public static bool DisplayCompass
        {
            get { return RBool(0x1378525); }
            set { WBool(0x1378525, value); }
        }
    }
}
