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
        public static Int32 LoadingState
        {
            get { return RInt32(Address + 0x800); }
            set { WInt32(Address + 0x800, value); }
        }
        public static Int32 DropItem_Type
        {
            get { return RInt32(Address + 0x83c); }
            set { WInt32(Address + 0x83c, value); }
        }
        public static Int32 DropItem_Id
        {
            get { return RInt32(Address + 0x840); }
            set { WInt32(Address + 0x840, value); }
        }
        public static Int32 DropItem_Durability
        {
            get { return RInt32(Address + 0x844); }
            set { WInt32(Address + 0x844, value); }
        }
        public static Int32 DropItem_Quantity
        {
            get { return RInt32(Address + 0x848); }
            set { WInt32(Address + 0x848, value); }
        }

        public static IntPtr GenDlgValuesPtr
        {
            get { return RIntPtr(Address + 0xA38); }
            set { WIntPtr(Address + 0xA38, value); }
        }


        public static Int32 LastTalkId
        {
            get { return RInt32(Address + 0xbb8); }
            set { WInt32(Address + 0xbb8, value); }
        }



        public static Int32 SaveMapNameID
        {
            get { return RInt32(Address + 0xF7C); }
            set { WInt32(Address + 0xF7C, value); }
        }



        public static Int32 BossGauge1_NameId
        {
            get { return RInt32(Address + 0x1050); }
            set { WInt32(Address + 0x1050, value); }
        }
        public static Int32 BossGauge1_Enabled
        {
            get { return RInt32(Address + 0x1054); }
            set { WInt32(Address + 0x1054, value); }
        }
        public static Int32 BossGauge1_MyDamage
        {
            get { return RInt32(Address + 0x1058); }
            set { WInt32(Address + 0x1058, value); }
        }
        public static Int32 BossGauge1_NetDamage
        {
            get { return RInt32(Address + 0x105c); }
            set { WInt32(Address + 0x105c, value); }
        }

        public static Int32 BossGauge2_NameId
        {
            get { return RInt32(Address + 0x1064); }
            set { WInt32(Address + 0x1064, value); }
        }
        public static Int32 BossGauge2_Enabled
        {
            get { return RInt32(Address + 0x1068); }
            set { WInt32(Address + 0x1068, value); }
        }
        public static Int32 BossGauge2_MyDamage
        {
            get { return RInt32(Address + 0x1068); }
            set { WInt32(Address + 0x1068, value); }
        }
        public static Int32 BossGauge2_NetDamage
        {
            get { return RInt32(Address + 0x106c); }
            set { WInt32(Address + 0x106c, value); }
        }

    }
}
