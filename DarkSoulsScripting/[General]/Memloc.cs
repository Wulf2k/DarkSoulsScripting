using DarkSoulsScripting.Injection.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsScripting
{
    public struct Memloc
    {
        public IntPtr Address
        {
            get
            {
                switch (Hook.DARKSOULS.Version)
                {
                    case DarkSoulsVersion.LatestRelease: return addrSteamRelease;
                    case DarkSoulsVersion.Debug: return addrSteamDebug;
                    case DarkSoulsVersion.Remaster: return addrSteamRemaster;
                    default: return addr_Zero;
                }
            }
        }

        private readonly IntPtr addrSteamRelease;
        private readonly IntPtr addrSteamDebug;
        private readonly IntPtr addrSteamRemaster;

        private static readonly IntPtr addr_Zero = IntPtr.Zero;

        public Memloc(Int64 addrSteamRelease, Int64 addrSteamDebug, Int64 addrSteamRemaster)
        {
            this.addrSteamRelease = new IntPtr(addrSteamRelease);
            this.addrSteamDebug = new IntPtr(addrSteamDebug);
            this.addrSteamRemaster = new IntPtr(addrSteamRemaster);
        }

        public Memloc(IntPtr addrSteamRelease, IntPtr addrSteamDebug, IntPtr addrSteamRemaster)
        {
            this.addrSteamRelease = addrSteamRelease;
            this.addrSteamDebug = addrSteamDebug;
            this.addrSteamRemaster = addrSteamRemaster;
        }

        public Memloc(Int64 addrSteamRemaster)
        {
            this.addrSteamRelease = IntPtr.Zero;
            this.addrSteamDebug = IntPtr.Zero;
            this.addrSteamRemaster = new IntPtr(addrSteamRemaster);
        }

        public Memloc(IntPtr addrSteamRemaster)
        {
            this.addrSteamRelease = IntPtr.Zero;
            this.addrSteamDebug = IntPtr.Zero;
            this.addrSteamRemaster = addrSteamRemaster;
        }

        //public static implicit operator Memloc(int releaseAddress) => new Memloc(releaseAddress, 0, 0);
        //public static implicit operator Memloc(uint releaseAddress) => new Memloc(releaseAddress, 0, 0);
        public static implicit operator Memloc(int remasterAddress) => new Memloc(0, 0, remasterAddress);
        public static implicit operator Memloc(uint remasterAddress) => new Memloc(0, 0, remasterAddress);
        public static implicit operator Memloc(Int64 remasterAddress) => new Memloc(0, 0, remasterAddress);
        public static implicit operator Memloc(IntPtr remasterAddress) => new Memloc(IntPtr.Zero, IntPtr.Zero, remasterAddress);

        public static implicit operator Memloc((Int64 Release, Int64 Debug, Int64 Remaster) addr) => new Memloc(addr.Release, addr.Debug, addr.Remaster);
        public static implicit operator Memloc((IntPtr Release, IntPtr Debug, IntPtr Remaster) addr) => new Memloc(addr.Release, addr.Debug, addr.Remaster);

        public static implicit operator int(Memloc m) => m.Address.ToInt32();
        public static implicit operator uint(Memloc m) => (uint)m.Address;
        public static implicit operator long(Memloc m) => m.Address.ToInt64();
        public static implicit operator IntPtr(Memloc m) => m.Address;
    }
}
