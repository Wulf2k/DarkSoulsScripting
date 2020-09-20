using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{

    public class TexHdlResCap : ResCap
    {
        protected override void InitSubStructures()
        {

        }


        static TexHdlResCap()
        {

        }

        public UInt32 Handle => RUInt32(Address + 0x28);

    }
}
