using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public static class WorldState
    {
		public static int Address => Hook.RInt32(0x13784A0);

        //TODO: ADD MORE STUFF

        public static int BonfireID
        {
            get => Hook.RInt32(Address + 0xB04);
            set => Hook.WInt32(Address + 0xB04, value);
        }

        public static float LastStandPosX
        {
            get => Hook.RFloat(Address + 0xB70);
            set => Hook.WFloat(Address + 0xB70, value);
        }

        public static float LastStandPosY
        {
            get => Hook.RFloat(Address + 0xB74);
            set => Hook.WFloat(Address + 0xB74, value);
        }

        public static float LastStandPosZ
        {
            get => Hook.RFloat(Address + 0xB78);
            set => Hook.WFloat(Address + 0xB78, value);
        }

        public static float LastStandAngle
        {
            get => Hook.RFloat(Address + 0xB7C);
            set => Hook.WFloat(Address + 0xB7C, value);
        }
    }
}
