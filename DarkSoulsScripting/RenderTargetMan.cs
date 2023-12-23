using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class RenderTargetMan
    {
        //DSR1310
        public static IntPtr Address => RIntPtr(0x141c6d598);

        public static uint VelocityMapFilter
        {
            get => RUInt32(Address + 0x264);
            set => WUInt32(Address + 0x264, value);
        }
       

    }
}
