using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsScripting
{
    public class PlayerGameData : GameStruct
    {
        public const int MAX_STATNAME_LENGTH = 14;

        public AppearanceFaceDataIndexer AppearanceFaceData { get; private set; }

        public ChrAsm ChrAsm { get; set; } = null;

        public struct AppearanceFaceDataIndexer
        {
            public readonly IntPtr Address;
            public AppearanceFaceDataIndexer(IntPtr addr)
            {
                Address = addr;
            }

            public byte this[int index]
            {
                get { return Hook.RByte(Address + 0x3A0 + index); }
                set { Hook.WByte(Address + 0x3A0 + index, value); }
            }
        }

        protected override void InitSubStructures()
        {
            AppearanceFaceData = new AppearanceFaceDataIndexer(Address);
            ChrAsm = new ChrAsm() { AddressReadFunc = () => Address };
        }

        public int PlayerId
        {
            get { return Hook.RInt32(IntPtr.Add(Address, 0x10)); }
            set { Hook.WInt32(IntPtr.Add(Address, 0x10), value); }
        }

        public int HP
        {
            get { return Hook.RInt32(Address + 0x14); }
            set { Hook.WInt32(Address + 0x14, value); }
        }

        public int MaxHP
        {
            get { return Hook.RInt32(Address + 0x18); }
            set { Hook.WInt32(Address + 0x18, value); }
        }

        public int MaxHPBase
        {
            get { return Hook.RInt32(Address + 0x1c); }
            set { Hook.WInt32(Address + 0x1c, value); }
        }

        public int MP
        {
            get { return Hook.RInt32(Address + 0x20); }
            set { Hook.WInt32(Address + 0x20, value); }
        }

         public int MaxMP
        {
            get { return Hook.RInt32(Address + 0x24); }
            set { Hook.WInt32(Address + 0x24, value); }
        }

        public int MaxMPBase
        {
            get { return Hook.RInt32(Address + 0x28); }
            set { Hook.WInt32(Address + 0x28, value); }
        }

        public int Stamina
        {
            get { return Hook.RInt32(Address + 0x30); }
            set { Hook.WInt32(Address + 0x30, value); }
        }

        public int MaxStamina
        {
            get { return Hook.RInt32(Address + 0x34); }
            set { Hook.WInt32(Address + 0x34, value); }
        }

        public int MaxStaminaBase
        {
            get { return Hook.RInt32(Address + 0x38); }
            set { Hook.WInt32(Address + 0x30, value); }
        }

        public int VIT
        {
            get { return Hook.RInt32(Address + 0x40); }
            set { Hook.WInt32(Address + 0x40, value); }
        }

        public int ATN
        {
            get { return Hook.RInt32(Address + 0x48); }
            set { Hook.WInt32(Address + 0x48, value); }
        }

        public int END
        {
            get { return Hook.RInt32(Address + 0x50); }
            set { Hook.WInt32(Address + 0x50, value); }
        }

        public int STR
        {
            get { return Hook.RInt32(Address + 0x58); }
            set { Hook.WInt32(Address + 0x58, value); }
        }

        public int DEX
        {
            get { return Hook.RInt32(Address + 0x60); }
            set { Hook.WInt32(Address + 0x60, value); }
        }

        public int INT
        {
            get { return Hook.RInt32(Address + 0x68); }
            set { Hook.WInt32(Address + 0x68, value); }
        }

        public int FTH
        {
            get { return Hook.RInt32(Address + 0x70); }
            set { Hook.WInt32(Address + 0x70, value); }
        }

        public int LCK
        {
            get { return Hook.RInt32(Address + 0x78); }
            set { Hook.WInt32(Address + 0x78, value); }
        }

        public int Humanity
        {
            get { return Hook.RInt32(Address + 0x84); }
            set { Hook.WInt32(Address + 0x84, value); }
        }

        public int RES
        {
            get { return Hook.RInt32(Address + 0x88); }
            set { Hook.WInt32(Address + 0x88, value); }
        }

        public int SoulLevel
        {
            get { return Hook.RInt32(Address + 0x90); }
            set { Hook.WInt32(Address + 0x90, value); }
        }

        public int Souls
        {
            get { return Hook.RInt32(Address + 0x94); }
            set { Hook.WInt32(Address + 0x94, value); }
        }

        public int TotalSouls
        {
            get { return Hook.RInt32(Address + 0x94); }
            set { Hook.WInt32(Address + 0x94, value); }
        }

        public int PointTotal
        {
            get { return Hook.RInt32(Address + 0xA0); }
            set { Hook.WInt32(Address + 0xA0, value); }
        }

        public int ChrType
        {
            get { return Hook.RInt32(Address + 0xa4); }
            set { Hook.WInt32(Address + 0xa4, value); }
        }

        public string Name
        {
            get { return Hook.RUnicodeStr(Address + 0xa8, MAX_STATNAME_LENGTH); }
            set { Hook.WAsciiStr(Address + 0xa8, value.Substring(0, Math.Min(value.Length, MAX_STATNAME_LENGTH))); }
        }

        public short Gender
        {
            get { return Hook.RInt16(Address + 0xcA); }
            set { Hook.WInt16(Address + 0xcA, value); }
        }

        public short DebugShopLevel
        {
            get { return Hook.RInt16(Address + 0xcc); }
            set { Hook.WInt16(Address + 0xcc, value); }
        }

        public byte StartingClass
        {
            get { return Hook.RByte(Address + 0xce); }
            set { Hook.WByte(Address + 0xce, value); }
        }

        public byte Physique
        {
            get { return Hook.RByte(Address + 0xcf); }
            set { Hook.WByte(Address + 0xcf, value); }
        }

        public byte StartingGift
        {
            get { return Hook.RByte(Address + 0xd0); }
            set { Hook.WByte(Address + 0xd0, value); }
        }

        public int MultiplayCount
        {
            get { return Hook.RInt32(Address + 0xd4); }
            set { Hook.WInt32(Address + 0xd4, value); }
        }

        public int CoOpSuccessCount
        {
            get { return Hook.RInt32(Address + 0xd8); }
            set { Hook.WInt32(Address + 0xd8, value); }
        }

        public int ThiefInvadePlaySuccessCount
        {
            get { return Hook.RInt32(Address + 0xdc); }
            set { Hook.WInt32(Address + 0xdc, value); }
        }

        public int PlayerRankS
        {
            get { return Hook.RInt32(Address + 0xe0); }
            set { Hook.WInt32(Address + 0xe0, value); }
        }

        public int PlayerRankA
        {
            get { return Hook.RInt32(Address + 0xe4); }
            set { Hook.WInt32(Address + 0xe4, value); }
        }

        public int PlayerRankB
        {
            get { return Hook.RInt32(Address + 0xe8); }
            set { Hook.WInt32(Address + 0xe8, value); }
        }

        public int PlayerRankC
        {
            get { return Hook.RInt32(Address + 0xec); }
            set { Hook.WInt32(Address + 0xec, value); }
        }

        public float BlockClearBonus
        {
            get { return Hook.RFloat(Address + 0xf8); }
            set { Hook.WFloat(Address + 0xf8, value); }
        }

        public int EggSouls
        {
            get { return Hook.RInt32(Address + 0xfc); }
            set { Hook.WInt32(Address + 0xfc, value); }
        }

        public int PoisonResist
        {
            get { return Hook.RInt32(Address + 0x100); }
            set { Hook.WInt32(Address + 0x100, value); }
        }

        public int BleedResist
        {
            get { return Hook.RInt32(Address + 0x104); }
            set { Hook.WInt32(Address + 0x104, value); }
        }

        public int ToxicResist
        {
            get { return Hook.RInt32(Address + 0x108); }
            set { Hook.WInt32(Address + 0x108, value); }
        }

        public int CurseResist
        {
            get { return Hook.RInt32(Address + 0x10c); }
            set { Hook.WInt32(Address + 0x10c, value); }
        }

        public byte Covenant
        {
            get { return Hook.RByte(Address + 0x113); }
            set { Hook.WInt32(Address + 0x113, value); }
        }

        public byte AppearanceFaceType
        {
            get { return Hook.RByte(Address + 0x114); }
            set { Hook.WByte(Address + 0x114, value); }
        }

        public byte AppearanceHairType
        {
            get { return Hook.RByte(Address + 0x115); }
            set { Hook.WByte(Address + 0x115, value); }
        }

        public byte AppearanceHairAndEyesColor
        {
            get { return Hook.RByte(Address + 0x116); }
            set { Hook.WByte(Address + 0x116, value); }
        }

        public byte CurseLevel
        {
            get { return Hook.RByte(Address + 0x117); }
            set { Hook.WByte(Address + 0x117, value); }
        }

        public byte InvadeType
        {
            get { return Hook.RByte(Address + 0x118); }
            set { Hook.WByte(Address + 0x118, value); }
        }

        public float AppearanceScaleHead
        {
            get { return Hook.RFloat(Address + 0x388); }
            set { Hook.WFloat(Address + 0x388, value); }
        }

        public float AppearanceScaleChest
        {
            get { return Hook.RFloat(Address + 0x38C); }
            set { Hook.WFloat(Address + 0x390, value); }
        }

        public float AppearanceScaleWaist
        {
            get { return Hook.RFloat(Address + 0x390); }
            set { Hook.WFloat(Address + 0x390, value); }
        }

        public float AppearanceScaleArms
        {
            get { return Hook.RFloat(Address + 0x394); }
            set { Hook.WFloat(Address + 0x394, value); }
        }

        public float AppearanceScaleLegs
        {
            get { return Hook.RFloat(Address + 0x398); }
            set { Hook.WFloat(Address + 0x398, value); }
        }
    }
}
