using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class MsbMan
    {
        public static IntPtr Address => RIntPtr(0x141D1AE98);
        public static int numMsbs => RInt32(Address + 0xc);
        public static IntPtr ArrayPtr = RIntPtr(Address + 0x10);

        public static MsbResCap[] MSBs { get; private set; } = null;

        static MsbMan()
        {
            MSBs = new MsbResCap[numMsbs];
            for (int x = 0; x < numMsbs; x++)
            {
                IntPtr addr = RIntPtr(ArrayPtr + x * IntPtr.Size);
                MSBs[x] = new MsbResCap() { AddressReadFunc = () => addr };
            }

        }

    }
}
