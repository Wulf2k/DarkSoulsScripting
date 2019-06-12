﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public enum ClearState : int
    {
        none = 0,
        good = 1,
        bad = 2
    }

    public class GameDataMan
    {
        //All currently active offsets updated for 1.03
        //DSR 1.03
        public static Func<IntPtr> AddressReadFunction = () => RIntPtr(0x141D278F0);
        public static IntPtr Address => AddressReadFunction();

        static GameDataMan()
        {
            LocalPlayerStats = new PlayerGameData() { AddressReadFunc = () => LocalPlayerStatsPtr };
            Options = new GameOptions() { AddressReadFunc = () => GameOptionsPtr };
            PcOptions = new PCOptions() { AddressReadFunc = () => PcOptionsPtr };
            Tendency = new GameTendency() { AddressReadFunc = () => TendencyPtr };
        }

        public static PlayerGameData LocalPlayerStats = null;
        public static GameOptions Options = null;
        public static PCOptions PcOptions = null;
        public static GameTendency Tendency = null;



        public static IntPtr TrophyEquipDataPtr
        {
            
            get { return RIntPtr(Address + 0x8); }
            set { WIntPtr(Address + 0x8, value); }
        }

        public static IntPtr LocalPlayerStatsPtr
        {//PlayerGameData
            
            get { return RIntPtr(Address + 0x10); }
            set { WIntPtr(Address + 0x10, value); }
        }

        public static IntPtr GameOptionsPtr
        {
            
            get { return RIntPtr(Address + 0x58); }
            set { WIntPtr(Address + 0x58, value); }
        }
        public static IntPtr PcOptionsPtr
        {
            
            get { return RIntPtr(Address + 0x68); }
            set { WIntPtr(Address + 0x68, value); }
        }

        public static IntPtr TendencyPtr
        {//QwcData
            
            get { return RIntPtr(Address + 0x70); }
            set { WIntPtr(Address + 0x70, value); }
        }

        public static int ClearCount
        {
            
            get { return RInt32(Address + 0x78); }
            set { WInt32(Address + 0x78, value); }
        }

        public static ClearState ClearState
        {
            
            get { return (ClearState)RInt32(Address + 0x7C); }
            set { WInt32(Address + 0x7C, (int)value); }
        }

        public static int FullRecover
        {
            
            get { return RInt32(Address + 0x80); }
            set { WInt32(Address + 0x80, value); }
        }

        public static int ItemComplete
        {
            
            get { return RInt32(Address + 0x84); }
            set { WInt32(Address + 0x84, value); }
        }

        public static int RescueWhite
        {
            
            get { return RInt32(Address + 0x88); }
            set { WInt32(Address + 0x88, value); }
        }

        //[sic] lol
        public static int KillBlack
        {
            
            get { return RInt32(Address + 0x8C); }
            set { WInt32(Address + 0x8C, value); }
        }

        public static int TrueDeath
        {
            
            get { return RInt32(Address + 0x90); }
            set { WInt32(Address + 0x90, value); }
        }

        public static int TrueDeathNum
        {
            
            get { return RInt32(Address + 0x94); }
            set { WInt32(Address + 0x94, value); }
        }

        public static int DeathNum
        {
            
            get { return RInt32(Address + 0x98); }
            set { WInt32(Address + 0x98, value); }
        }

        public static int DeathState
        {
            get { return RInt32(Address + 0xb4); }
            set { WInt32(Address + 0xb4, value); }
        }
        /*
        public static int IngameTime
        {
            get { return RInt32(Address + 0x68); }
            set { WInt32(Address + 0x68, value); }
        }

        public static int LanCutPoint
        {
            get { return RInt32(Address + 0x6C); }
            set { WInt32(Address + 0x6C, value); }
        }

        public static int LanCutPointTimer
        {
            get { return RInt32(Address + 0x70); }
            set { WInt32(Address + 0x70, value); }
        }

        
        */
    }
}
