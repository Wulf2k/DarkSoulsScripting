using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class MsgMan
    {
        //DSR 1.03

        public static IntPtr Address => RIntPtr(0x141d1b748);

        static MsgMan()
        {

        }

    }
}
