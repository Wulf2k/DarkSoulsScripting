using System;
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

    public static class Game
    {
        //DSR 1.03
        public static Func<IntPtr> AddressReadFunction = () => RIntPtr(0x141D278F0);
        public static IntPtr Address => AddressReadFunction();

        public static IntPtr LocalPlayerStatsPtr
        {
            //Updated for DSR
            get { return RIntPtr(Address + 0x10); }
            set { WIntPtr(Address + 0x10, value); }
        }

        public static IntPtr OptionsPtr
        {
            //Updated for DSR
            get { return RIntPtr(Address + 0x58); }
            set { WIntPtr(Address + 0x58, value); }
        }

        public static IntPtr TendencyPtr
        {
            get { return RIntPtr(Address + 0x38); }
            set { WIntPtr(Address + 0x38, value); }
        }

        public static PlayerStats LocalPlayerStats = null;
        public static GameOptions Options = null;
        public static GameTendency Tendency = null;

        static Game()
        {
            LocalPlayerStats = new PlayerStats() { AddressReadFunc = () => LocalPlayerStatsPtr };
            Options = new GameOptions() { AddressReadFunc = () => OptionsPtr };
            Tendency = new GameTendency() { AddressReadFunc = () => TendencyPtr };
        }

        public static int ClearCount
        {
            //Updated for DSR
            get { return RInt32(Address + 0x78); }
            set { WInt32(Address + 0x78, value); }
        }

        public static ClearState ClearState
        {
            //Updated for DSR
            get { return (ClearState)RInt32(Address + 0x7C); }
            set { WInt32(Address + 0x7C, (int)value); }
        }

        public static int FullRecover
        {
            //Updated for DSR
            get { return RInt32(Address + 0x80); }
            set { WInt32(Address + 0x80, value); }
        }

        public static int ItemComplete
        {
            //Updated for DSR
            get { return RInt32(Address + 0x84); }
            set { WInt32(Address + 0x84, value); }
        }

        public static int RescueWhite
        {
            //Updated for DSR
            get { return RInt32(Address + 0x88); }
            set { WInt32(Address + 0x88, value); }
        }

        //[sic] lol
        public static int KillBlack
        {
            //Updated for DSR
            get { return RInt32(Address + 0x8C); }
            set { WInt32(Address + 0x8C, value); }
        }

        public static int TrueDeath
        {
            //Updated for DSR
            get { return RInt32(Address + 0x90); }
            set { WInt32(Address + 0x90, value); }
        }

        public static int TrueDeathNum
        {
            //Updated for DSR
            get { return RInt32(Address + 0x94); }
            set { WInt32(Address + 0x94, value); }
        }

        public static int DeathNum
        {
            //Updated for DSR
            get { return RInt32(Address + 0x98); }
            set { WInt32(Address + 0x98, value); }
        }

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

        public static int DeathState
        {
            get { return RInt32(Address + 0x78); }
            set { WInt32(Address + 0x78, value); }
        }
    }
}
