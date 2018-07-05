using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsScripting
{
    public class PlayerStats : GameStruct
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

        public int HP
        {
            //Updated for DSR
            get { return Hook.RInt32(IntPtr.Add(Address, 0x14)); }
            set { Hook.WInt32(IntPtr.Add(Address, 0x14), value); }
        }

        public int MaxHPBase
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x18); }
            set { Hook.WInt32(Address + 0x18, value); }
        }

        public int MaxHP
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x1C); }
            set { Hook.WInt32(Address + 0x1C, value); }
        }

        public int MP
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x20); }
            set { Hook.WInt32(Address + 0x20, value); }
        }

        public int MaxMPBase
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x24); }
            set { Hook.WInt32(Address + 0x24, value); }
        }

        public int MaxMP
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x28); }
            set { Hook.WInt32(Address + 0x28, value); }
        }

        public int Stamina
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x2C); }
            set { Hook.WInt32(Address + 0x2C, value); }
        }

        public int MaxStaminaBase
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x30); }
            set { Hook.WInt32(Address + 0x30, value); }
        }

        public int MaxStamina
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x38); }
            set { Hook.WInt32(Address + 0x38, value); }
        }

        public int VIT
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x10); }
            set { Hook.WInt32(Address + 0x10, value); }
        }

        public int ATN
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x48); }
            set { Hook.WInt32(Address + 0x48, value); }
        }

        public int END
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x50); }
            set { Hook.WInt32(Address + 0x50, value); }
        }

        public int STR
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x58); }
            set { Hook.WInt32(Address + 0x58, value); }
        }

        public int DEX
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x60); }
            set { Hook.WInt32(Address + 0x60, value); }
        }

        public int INT
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x68); }
            set { Hook.WInt32(Address + 0x68, value); }
        }

        public int FTH
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x70); }
            set { Hook.WInt32(Address + 0x70, value); }
        }

        public int RES
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x88); }
            set { Hook.WInt32(Address + 0x88, value); }
        }

        public int Humanity
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0x84); }
            set { Hook.WInt32(Address + 0x84, value); }
        }

        public short Gender //oh no i did the thing REEEEEEEEEEEEEEEE
        {
            //Updated for DSR
            get { return Hook.RInt16(Address + 0xcA); }
            set { Hook.WInt16(Address + 0xcA, value); }
        }

        public short DebugShopLevel
        {
            //Updated for DSR
            get { return Hook.RInt16(Address + 0xcc); }
            set { Hook.WInt16(Address + 0xcc, value); }
        }

        public byte StartingClass
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0xce); }
            set { Hook.WByte(Address + 0xce, value); }
        }

        public byte Physique
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0xcf); }
            set { Hook.WByte(Address + 0xcf, value); }
        }

        public byte StartingGift
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0xd0); }
            set { Hook.WByte(Address + 0xd0, value); }
        }

        public int MultiplayCount
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xd4); }
            set { Hook.WInt32(Address + 0xd4, value); }
        }

        public int CoOpSuccessCount
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xd8); }
            set { Hook.WInt32(Address + 0xd8, value); }
        }

        public int ThiefInvadePlaySuccessCount
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xdc); }
            set { Hook.WInt32(Address + 0xdc, value); }
        }

        public int PlayerRankS
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xe0); }
            set { Hook.WInt32(Address + 0xe0, value); }
        }

        public int PlayerRankA
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xe4); }
            set { Hook.WInt32(Address + 0xe4, value); }
        }

        public int PlayerRankB
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xe8); }
            set { Hook.WInt32(Address + 0xe8, value); }
        }

        public int PlayerRankC
        {
            //Updated for DSR
            get { return Hook.RInt32(Address + 0xec); }
            set { Hook.WInt32(Address + 0xec, value); }
        }

        public byte DevotionWarriorOfSunlight
        {
            get { return Hook.RByte(Address + 0xe5); }
            set { Hook.WByte(Address + 0xe5, value); }
        }

        public byte DevotionDarkwraith
        {
            get { return Hook.RByte(Address + 0xe6); }
            set { Hook.WByte(Address + 0xe6, value); }
        }

        public byte DevotionDragon
        {
            get { return Hook.RByte(Address + 0xe7); }
            set { Hook.WByte(Address + 0xe7, value); }
        }

        public byte DevotionGravelord
        {
            get { return Hook.RByte(Address + 0xe8); }
            set { Hook.WByte(Address + 0xe8, value); }
        }

        public byte DevotionForest
        {
            get { return Hook.RByte(Address + 0xe9); }
            set { Hook.WByte(Address + 0xe9, value); }
        }

        public byte DevotionDarkmoon
        {
            get { return Hook.RByte(Address + 0xea); }
            set { Hook.WByte(Address + 0xea, value); }
        }

        public byte DevotionChaos
        {
            get { return Hook.RByte(Address + 0xeb); }
            set { Hook.WByte(Address + 0xeb, value); }
        }

        public int Indictments
        {
            get { return Hook.RInt32(Address + 0xec); }
            set { Hook.WInt32(Address + 0xec, value); }
        }

        public float DebugBlockClearBonus
        {
            get { return Hook.RFloat(Address + 0xf0); }
            set { Hook.WFloat(Address + 0xf0, value); }
        }

        public int EggSouls
        {
            get { return Hook.RInt32(Address + 0xf4); }
            set { Hook.WInt32(Address + 0xf4, value); }
        }

        public int PoisonResist
        {
            get { return Hook.RInt32(Address + 0xf8); }
            set { Hook.WInt32(Address + 0xf8, value); }
        }

        public int BleedResist
        {
            get { return Hook.RInt32(Address + 0xfc); }
            set { Hook.WInt32(Address + 0xfc, value); }
        }

        public int ToxicResist
        {
            get { return Hook.RInt32(Address + 0x100); }
            set { Hook.WInt32(Address + 0x100, value); }
        }

        public int CurseResist
        {
            get { return Hook.RInt32(Address + 0x104); }
            set { Hook.WInt32(Address + 0x104, value); }
        }

        public byte DebugClearItem
        {
            get { return Hook.RByte(Address + 0x108); }
            set { Hook.WByte(Address + 0x108, value); }
        }

        public byte DebugResvSoulSteam
        {
            get { return Hook.RByte(Address + 0x109); }
            set { Hook.WByte(Address + 0x109, value); }
        }

        public byte DebugResvSoulPenalty
        {
            get { return Hook.RByte(Address + 0x10a); }
            set { Hook.WByte(Address + 0x10a, value); }
        }

        //public COVENANT Covenant
        public byte Covenant
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x113); }
            set { Hook.WInt32(Address + 0x113, value); }
        }

        public byte AppearanceFaceType
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x114); }
            set { Hook.WByte(Address + 0x114, value); }
        }

        public byte AppearanceHairType
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x115); }
            set { Hook.WByte(Address + 0x115, value); }
        }

        public byte AppearanceHairAndEyesColor
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x116); }
            set { Hook.WByte(Address + 0x116, value); }
        }

        public byte CurseLevel
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x117); }
            set { Hook.WByte(Address + 0x117, value); }
        }

        public byte InvadeType
        {
            //Updated for DSR
            get { return Hook.RByte(Address + 0x118); }
            set { Hook.WByte(Address + 0x118, value); }
        }

        public int EquipLeftHand1Index
        {
            get { return Hook.RInt32(Address + 0x1D4); }
            set { Hook.WInt32(Address + 0x1D4, value); }
        }

        public int EquipRightHand1Index
        {
            get { return Hook.RInt32(Address + 0x1D8); }
            set { Hook.WInt32(Address + 0x1D8, value); }
        }

        public int EquipLeftHand2Index
        {
            get { return Hook.RInt32(Address + 0x1DC); }
            set { Hook.WInt32(Address + 0x1DC, value); }
        }

        public int EquipRightHand2Index
        {
            get { return Hook.RInt32(Address + 0x1E0); }
            set { Hook.WInt32(Address + 0x1E0, value); }
        }

        public int EquipArrow1Index
        {
            get { return Hook.RInt32(Address + 0x1E4); }
            set { Hook.WInt32(Address + 0x1E4, value); }
        }

        public int EquipBolt1Index
        {
            get { return Hook.RInt32(Address + 0x1E8); }
            set { Hook.WInt32(Address + 0x1E8, value); }
        }

        public int EquipArrow2Index
        {
            get { return Hook.RInt32(Address + 0x1EC); }
            set { Hook.WInt32(Address + 0x1EC, value); }
        }

        public int EquipBolt2Index
        {
            get { return Hook.RInt32(Address + 0x1F0); }
            set { Hook.WInt32(Address + 0x1F0, value); }
        }

        public int EquipHeadIndex
        {
            get { return Hook.RInt32(Address + 0x1F4); }
            set { Hook.WInt32(Address + 0x1F4, value); }
        }

        public int EquipChestIndex
        {
            get { return Hook.RInt32(Address + 0x1F8); }
            set { Hook.WInt32(Address + 0x1F8, value); }
        }

        public int EquipArmsIndex
        {
            get { return Hook.RInt32(Address + 0x1FC); }
            set { Hook.WInt32(Address + 0x1FC, value); }
        }

        public int EquipLegsIndex
        {
            get { return Hook.RInt32(Address + 0x200); }
            set { Hook.WInt32(Address + 0x200, value); }
        }

        public int EquipRing1Index
        {
            get { return Hook.RInt32(Address + 0x208); }
            set { Hook.WInt32(Address + 0x208, value); }
        }

        public int EquipRing2Index
        {
            get { return Hook.RInt32(Address + 0x20C); }
            set { Hook.WInt32(Address + 0x20C, value); }
        }

        public int EquipItem1Index
        {
            get { return Hook.RInt32(Address + 0x210); }
            set { Hook.WInt32(Address + 0x210, value); }
        }

        public int EquipItem2Index
        {
            get { return Hook.RInt32(Address + 0x214); }
            set { Hook.WInt32(Address + 0x214, value); }
        }

        public int EquipItem3Index
        {
            get { return Hook.RInt32(Address + 0x218); }
            set { Hook.WInt32(Address + 0x218, value); }
        }

        public int EquipItem4Index
        {
            get { return Hook.RInt32(Address + 0x21C); }
            set { Hook.WInt32(Address + 0x21C, value); }
        }

        public int EquipItem5Index
        {
            get { return Hook.RInt32(Address + 0x220); }
            set { Hook.WInt32(Address + 0x220, value); }
        }

        public WeaponHoldStyle EquipHoldStyle
        {
            get { return (WeaponHoldStyle)Hook.RInt32(Address + 0x230); }
            set { Hook.WInt32(Address + 0x230, (int)value); }
        }

        public int EquipWeaponSlotL
        {
            get { return Hook.RInt32(Address + 0x234); }
            set { Hook.WInt32(Address + 0x234, value); }
        }

        public int EquipWeaponSlotR
        {
            get { return Hook.RInt32(Address + 0x238); }
            set { Hook.WInt32(Address + 0x238, value); }
        }

        //TODO: GAP

        public int EquipLeftHand1
        {
            get { return Hook.RInt32(Address + 0x24C); }
            set { Hook.WInt32(Address + 0x24C, value); }
        }

        public int EquipRightHand1
        {
            get { return Hook.RInt32(Address + 0x250); }
            set { Hook.WInt32(Address + 0x250, value); }
        }

        public int EquipLeftHand2
        {
            get { return Hook.RInt32(Address + 0x254); }
            set { Hook.WInt32(Address + 0x254, value); }
        }

        public int EquipRightHand2
        {
            get { return Hook.RInt32(Address + 0x258); }
            set { Hook.WInt32(Address + 0x258, value); }
        }

        public int EquipArrow1
        {
            get { return Hook.RInt32(Address + 0x25C); }
            set { Hook.WInt32(Address + 0x25C, value); }
        }

        public int EquipBolt1
        {
            get { return Hook.RInt32(Address + 0x260); }
            set { Hook.WInt32(Address + 0x260, value); }
        }

        public int EquipArrow2
        {
            get { return Hook.RInt32(Address + 0x264); }
            set { Hook.WInt32(Address + 0x264, value); }
        }

        public int EquipBolt2
        {
            get { return Hook.RInt32(Address + 0x268); }
            set { Hook.WInt32(Address + 0x268, value); }
        }

        public int EquipHead
        {
            get { return Hook.RInt32(Address + 0x26C); }
            set { Hook.WInt32(Address + 0x26C, value); }
        }

        public int EquipChest
        {
            get { return Hook.RInt32(Address + 0x270); }
            set { Hook.WInt32(Address + 0x270, value); }
        }

        public int EquipArms
        {
            get { return Hook.RInt32(Address + 0x274); }
            set { Hook.WInt32(Address + 0x274, value); }
        }

        public int EquipLegs
        {
            get { return Hook.RInt32(Address + 0x278); }
            set { Hook.WInt32(Address + 0x278, value); }
        }

        public int EquipRing1
        {
            get { return Hook.RInt32(Address + 0x280); }
            set { Hook.WInt32(Address + 0x280, value); }
        }

        public int EquipRing2
        {
            get { return Hook.RInt32(Address + 0x284); }
            set { Hook.WInt32(Address + 0x284, value); }
        }

        public int EquipItem1
        {
            get { return Hook.RInt32(Address + 0x288); }
            set { Hook.WInt32(Address + 0x288, value); }
        }

        public int EquipItem2
        {
            get { return Hook.RInt32(Address + 0x28C); }
            set { Hook.WInt32(Address + 0x28C, value); }
        }

        public int EquipItem3
        {
            get { return Hook.RInt32(Address + 0x290); }
            set { Hook.WInt32(Address + 0x290, value); }
        }

        public int EquipItem4
        {
            get { return Hook.RInt32(Address + 0x294); }
            set { Hook.WInt32(Address + 0x294, value); }
        }

        public int EquipItem5
        {
            get { return Hook.RInt32(Address + 0x298); }
            set { Hook.WInt32(Address + 0x298, value); }
        }

        public float AppearanceScaleHead
        {
            //Updated for DSR
            get { return Hook.RFloat(Address + 0x388); }
            set { Hook.WFloat(Address + 0x388, value); }
        }

        public float AppearanceScaleChest
        {
            //Updated for DSR
            get { return Hook.RFloat(Address + 0x38C); }
            set { Hook.WFloat(Address + 0x390, value); }
        }

        public float AppearanceScaleWaist
        {
            //Updated for DSR
            get { return Hook.RFloat(Address + 0x390); }
            set { Hook.WFloat(Address + 0x390, value); }
        }

        public float AppearanceScaleArms
        {
            //Updated for DSR
            get { return Hook.RFloat(Address + 0x394); }
            set { Hook.WFloat(Address + 0x394, value); }
        }

        public float AppearanceScaleLegs
        {
            //Updated for DSR
            get { return Hook.RFloat(Address + 0x398); }
            set { Hook.WFloat(Address + 0x398, value); }
        }

        public float AppearanceHairColorR
        {
            get { return Hook.RFloat(Address + 0x380); }
            set { Hook.WFloat(Address + 0x380, value); }
        }

        public float AppearanceHairColorG
        {
            get { return Hook.RFloat(Address + 0x384); }
            set { Hook.WFloat(Address + 0x384, value); }
        }

        public float AppearanceHairColorB
        {
            get { return Hook.RFloat(Address + 0x388); }
            set { Hook.WFloat(Address + 0x388, value); }
        }

        public float AppearanceHairColorA
        {
            get { return Hook.RFloat(Address + 0x38c); }
            set { Hook.WFloat(Address + 0x38c, value); }
        }

        public float AppearanceEyeColorR
        {
            get { return Hook.RFloat(Address + 0x390); }
            set { Hook.WFloat(Address + 0x390, value); }
        }

        public float AppearanceEyeColorG
        {
            get { return Hook.RFloat(Address + 0x394); }
            set { Hook.WFloat(Address + 0x394, value); }
        }

        public float AppearanceEyeColorB
        {
            get { return Hook.RFloat(Address + 0x398); }
            set { Hook.WFloat(Address + 0x398, value); }
        }

        public float AppearanceEyeColorA
        {
            get { return Hook.RFloat(Address + 0x39c); }
            set { Hook.WFloat(Address + 0x39c, value); }
        }

        //TODO: CHECK FOR OTHER DEFENSES

        public int MagicDefense
        {
            get { return Hook.RInt32(Address + 0x43c); }
            set { Hook.WInt32(Address + 0x43c, value); }
        }

        //TODO: IS THIS THE DEMONS SOULS ITEM BURDEN OR WHAT WULF

        public float MaxItemBurden
        {
            get { return Hook.RFloat(Address + 0x44c); }
            set { Hook.WFloat(Address + 0x44c, value); }
        }

        //TODO: CONFIRM IF THESE ARE THE BUILDUPS AND NOT THE STAT SCREEN MAXIMUMS

        public float PoisonBuildup
        {
            get { return Hook.RFloat(Address + 0x49c); }
            set { Hook.WFloat(Address + 0x49c, value); }
        }

        public float ToxicBuildup
        {
            get { return Hook.RFloat(Address + 0x4a0); }
            set { Hook.WFloat(Address + 0x4a0, value); }
        }

        public float BleedBuildup
        {
            get { return Hook.RFloat(Address + 0x4a4); }
            set { Hook.WFloat(Address + 0x4a4, value); }
        }

        public float CurseBuildup
        {
            get { return Hook.RFloat(Address + 0x4a8); }
            set { Hook.WFloat(Address + 0x4a8, value); }
        }

        public float Poise
        {
            get { return Hook.RFloat(Address + 0x4ac); }
            set { Hook.WFloat(Address + 0x4ac, value); }
        }

        public int SoulLevel
        {
            //DSR
            get { return Hook.RInt32(Address + 0x90); }
            set { Hook.WInt32(Address + 0x90, value); }
        }

        public int Souls
        {
            //DSR
            get { return Hook.RInt32(Address + 0x94); }
            set { Hook.WInt32(Address + 0x94, value); }
        }

        public int PointTotal
        {
            //DSR
            get { return Hook.RInt32(Address + 0xA0); }
            set { Hook.WInt32(Address + 0xA0, value); }
        }

        public string Name
        {
            //DSR
            get { return Hook.RUnicodeStr(Address + 0xa8, MAX_STATNAME_LENGTH); }
            set { Hook.WAsciiStr(Address + 0xa8, value.Substring(0, Math.Min(value.Length, MAX_STATNAME_LENGTH))); }
        }
    }
}
