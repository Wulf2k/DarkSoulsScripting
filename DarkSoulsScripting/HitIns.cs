using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class HitIns : FieldInsBase
    {
        public MsbResCap Msb{ get; private set; } = null;
        

        protected override void InitSubStructures()
        {
            Msb = new MsbResCap() { AddressReadFunc = () => MsbResCapPtr };
        }

        public IntPtr MsbResCapPtr => RIntPtr(Address + 0x10);
    }
}
