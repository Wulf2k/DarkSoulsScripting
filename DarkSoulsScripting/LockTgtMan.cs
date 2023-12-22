using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class LockTgtMan
    {
        //DSR1310
        public static IntPtr Address => RIntPtr(0x141c7a138);

        public static bool IsLocked
        {
            get => RBool(Address + 0x1430);
            set => WBool(Address + 0x1430, value);
        }

    }
}
