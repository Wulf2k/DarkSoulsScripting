using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public class EntityLocalPlayerMapInfo
    {
		public int Address
        {
            get => AddressReadFunc();
        }
        public Func<int> AddressReadFunc;
		public EntityLocalPlayerMapInfo(int addr)
		{
            int addrDeref = addr;
            AddressReadFunc = () => addr;
		}
        public EntityLocalPlayerMapInfo(Func<int> addrReadFunc)
        {
            AddressReadFunc = addrReadFunc;
        }

        public int BonfireID
        {
            get => Hook.RInt32(Address + 0x04);
            set => Hook.WInt32(Address + 0x04, value);
        }

        public float LastStandPosX
        {
            get => Hook.RFloat(Address + 0x70);
            set => Hook.WFloat(Address + 0x70, value);
        }

        public float LastStandPosY
        {
            get => Hook.RFloat(Address + 0x74);
            set => Hook.WFloat(Address + 0x74, value);
        }

        public float LastStandPosZ
        {
            get => Hook.RFloat(Address + 0x78);
            set => Hook.WFloat(Address + 0x78, value);
        }
    }
}
