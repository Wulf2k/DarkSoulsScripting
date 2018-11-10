using System;
using DarkSoulsScripting.Injection;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class GameMan
    {
        //public static IntPtr Address => RIntPtr(0x13784A0);

        //DSR 1.03
        public static IntPtr Address => RIntPtr((0x13784A0, 0, 0x141D10E18));

        //TODO: ADD MORE STUFF
        //All uncommented offsets updated for 1.03

        public static byte WarpNextStageKick
        {
            //Updated for DSR
            get => RByte(Address + 0x19);
            set => WByte(Address + 0x19, value);
        }

        public static byte SetMapUid_Area
        {
            //Updated for DSR
            get => RByte(Address + 0x1E);
            set => WByte(Address + 0x1E, value);
        }

        public static byte SetMapUid_World
        {
            //Updated for DSR
            get => RByte(Address + 0x1F);
            set => WByte(Address + 0x1F, value);
        }

        public static int SetMapUid_Point
        {
            //Updated for DSR
            get => RInt32(Address + 0x20);
            set => WInt32(Address + 0x20, value);
        }

        public static int SetMiniBlockIndex
        {
            //Updated for DSR
            get => RInt32(Address + 0x2C);
            set => WInt32(Address + 0x2C, value);
        }

        public static byte SetSummonedPos
        {
            //1.03
            get => RByte(Address + 0x30);
            set => WByte(Address + 0x30, value);
        }

        public static int SaveSlot
        {
            //Updated for DSR
            get => RInt32(Address + 0xAA0);
            set => WInt32(Address + 0xAA0, value);
        }

        /*
        public static float SosSignPosX
        {
            get => RFloat(Address + 0xA80);
            set => WFloat(Address + 0xA80, value);
        }

        public static float SosSignPosY
        {
            get => RFloat(Address + 0xA84);
            set => WFloat(Address + 0xA84, value);
        }

        public static float SosSignPosZ
        {
            get => RFloat(Address + 0xA88);
            set => WFloat(Address + 0xA88, value);
        }

        public static byte SosSignAreaID
        {
            get => RByte(Address + 0xA92);
            set => WByte(Address + 0xA92, value);
        }

        public static byte SosSignWorldID
        {
            get => RByte(Address + 0xA93);
            set => WByte(Address + 0xA93, value);
        }

        public static byte SosSignWarp
        {
            get => RByte(Address + 0xB00);
            set => WByte(Address + 0xB00, value);
        }
        */
        public static int BonfireID
        {
            //1.03
            get => RInt32(Address + 0xB34);
            set => WInt32(Address + 0xB34, value);
        }

        public static bool bSaveRequest_Profile
        {
            //1.03
            get => RBool(Address + 0xB3F);
            set => WBool(Address + 0xB3F, value);
        }
        /*
        public static bool TutorialBegin
        {
            get => RBool(Address + 0xB0C);
            set => WBool(Address + 0xB0C, value);
        }

        public static byte TutorialSummonedPos
        {
            get => RByte(Address + 0xB0E);
            set => WByte(Address + 0xB0E, value);
        }

        public static bool TriggerSaveA
        {
            //Updated for DSR  (Added 0x30)
            get => RBool(Address + 0xB3F);
            set => WBool(Address + 0xB3F, value);
        }

        public static bool TriggerSaveB
        {
            get => RBool(Address + 0xB10);
            set => WBool(Address + 0xB10, value);
        }

        public static bool TriggerSaveC
        {
            get => RBool(Address + 0xB11);
            set => WBool(Address + 0xB11, value);
        }

        public static void TriggerSave()
        {
            TriggerSaveA = true;
        }
        */
        public static bool bRequestToEnding
        {
            //1.03
            get => RBool(Address + 0xB48);
            set => WBool(Address + 0xB48, value);
        }

        public static bool SaveMode
        {
            //1.03
            get => RBool(Address + 0xB70);
            set => WBool(Address + 0xB70, value);
        }

        public static bool IsFpsDisconnection
        {
            //1.03
            get => RBool(Address + 0xB7C);
            set => WBool(Address + 0xB7C, value);
        }

        public static bool IsOnlineMode
        {
            //1.03
            get => RBool(Address + 0xB7D);
            set => WBool(Address + 0xB7D, value);
        }

        public static bool IsTitleStart
        {
            //1.03
            get => RBool(Address + 0xB7E);
            set => WBool(Address + 0xB7E, value);
        }

        public static bool ChecksumUpdateEnabled
        {
            //1.03
            get => RBool(Address + 0xB95);
            set => WBool(Address + 0xB95, value);
        }

        public static bool IsNoInput
        {
            //1.03
            get => RBool(Address + 0xB97);
            set => WBool(Address + 0xB97, value);
        }
        /*

        public static int ClearMyWorldState_1
        {
            get => RInt32(Address + 0xBCC);
            set => WInt32(Address + 0xBCC, value);
        }

        public static int ClearMyWorldState_2
        {
            get => RInt32(Address + 0xBD0);
            set => WInt32(Address + 0xBD0, value);
        }

        public static int ClearMyWorldState_3
        {
            get => RInt32(Address + 0xBDC);
            set => WInt32(Address + 0xBDC, value);
        }

        public static int ClearMyWorldState_4
        {
            get => RInt32(Address + 0xBE0);
            set => WInt32(Address + 0xBE0, value);
        }

        public static int InvasionType
        {
            get => RInt32(Address + 0xBE4);
            set => WInt32(Address + 0xBE4, value);
        }

        /*
            +0x0BEC Pointer              Unknown
                +0x0004 GetWhiteGhostCount
                +0x0014 HavePartyMember
                +0x007C IsGameClient
        */

        public static bool IsDisableAllAreaEne
        {
            //1.03
            get => RBool(Address + 0xD3F);
            set => WBool(Address + 0xD3F, value);
        }

        public static bool IsDisableAllAreaEvent
        {
            //1.03
            get => RBool(Address + 0xD40);
            set => WBool(Address + 0xD40, value);
        }

        public static bool IsDisableAllAreaMap
        {
            //1.03
            get => RBool(Address + 0xD41);
            set => WBool(Address + 0xD41, value);
        }

        public static bool IsDisableAllAreaObj
        {
            //1.03
            get => RBool(Address + 0xD42);
            set => WBool(Address + 0xD42, value);
        }

        public static bool IsEnableAllAreaObj
        {
            //1.03
            get => RBool(Address + 0xD43);
            set => WBool(Address + 0xD43, value);
        }

        public static bool IsEnableAllAreaObjBreak
        {
            //1.03
            get => RBool(Address + 0xD44);
            set => WBool(Address + 0xD44, value);
        }

        public static bool IsDisableAllAreaHiHit
        {
            //1.03
            get => RBool(Address + 0xD45);
            set => WBool(Address + 0xD45, value);
        }

        public static bool IsEnableAllAreaLoHit
        {
            //1.03
            get => RBool(Address + 0xD46);
            set => WBool(Address + 0xD46, value);
        }

        public static bool IsDisableAllAreaSFX
        {
            //1.03
            get => RBool(Address + 0xD47);
            set => WBool(Address + 0xD47, value);
        }

        public static bool IsDisableAllAreaSound
        {
            //1.03
            get => RBool(Address + 0xD48);
            set => WBool(Address + 0xD48, value);
        }

        public static bool IsObjBreakRecordMode
        {
            //1.03
            get => RBool(Address + 0xD49);
            set => WBool(Address + 0xD49, value);
        }

        public static bool IsAutoMapWarpMode
        {
            //1.03
            get => RBool(Address + 0xD4A);
            set => WBool(Address + 0xD3A, value);
        }

        public static bool IsChrNpcWanderTest
        {
            //1.03
            get => RBool(Address + 0xD4B);
            set => WBool(Address + 0xD4B, value);
        }

        public static bool IsDbgChrAllDead
        {
            //1.03
            get => RBool(Address + 0xD4C);
            set => WBool(Address + 0xD4C, value);
        }
        
        public static float LastStandPosX
        {
            get => RFloat(Address + 0xBA0);
            set => WFloat(Address + 0xBA0, value);
        }

        public static float LastStandPosY
        {
            get => RFloat(Address + 0xBA4);
            set => WFloat(Address + 0xBA4, value);
        }

        public static float LastStandPosZ
        {
            get => RFloat(Address + 0xBA8);
            set => WFloat(Address + 0xBA8, value);
        }

        public static float LastStandAngle
        {
            get => RFloat(Address + 0xBAC);
            set => WFloat(Address + 0xBAC, value);
        }

    }
}
