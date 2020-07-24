using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class PadMan
    {
        public static IntPtr Address => RIntPtr(0x141d06eb0);

        public static IntPtr PadDevicePtr => RIntPtr(Address + 0x10);
        public static byte dpad => RByte(RIntPtr(RIntPtr(PadDevicePtr + 0x8) + 0x50) + 0x18);


    }
}
