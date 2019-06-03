using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class ParamMan
    {
        //DSR 1.03

        public static IntPtr Address => RIntPtr(0x141d1b098);
        public static IntPtr ParamResCapArray => RIntPtr(Address + 0x10);
        public static int numParams => RInt32(Address + 0xC);

        //public static Param SysMsg { get; private set; } = null;


        static ParamMan()
        {
            
        }
        public static Params FindParams(string name)
        {

            for (int i = 0; i < ParamMan.numParams; i++)
            {
                IntPtr currParamResCap = RIntPtr(ParamMan.ParamResCapArray + i * IntPtr.Size);
                string currParamName = RUnicodeStr(RIntPtr(currParamResCap + 0x8), 24);

                if (name == currParamName)
                {
                    return new Params() { AddressReadFunc = () => RIntPtr(currParamResCap + 0x38) };
                }
            }
            return new Params() { AddressReadFunc = () => IntPtr.Zero };

        }
    }

    public class Params : GameStruct
    {
        protected override void InitSubStructures()
        {

        }


        public IntPtr getOffset(int id)
        {
            int numEntries;
            int paramid;
            numEntries = RInt16(Address + 0xA);
            for (int i = 0; i < numEntries; i++)
            {
                paramid = RInt32(Address + 0x30 + i * 0xC);

                if (id == paramid)
                {
                    return Address + RInt32(Address + 0x34 + i * 0xC );
                }
            }
            return IntPtr.Zero;
        }
    }
}
