using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class FieldInsBase : GameStruct
    {

        protected override void InitSubStructures()
        {

        }

        public Int32 Handle
        {
            get => RInt32(Address + 0x8);
            set => WInt32(Address + 0x8, value);
        }
    }
}
