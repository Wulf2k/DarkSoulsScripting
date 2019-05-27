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
        public static Params EquipParamGoods { get; private set; } = null;
        public static Params SpEffectParam { get; private set; } = null;
        //public static Param SysMsg { get; private set; } = null;


        static ParamMan()
        {
            EquipParamGoods = new Params() { AddressReadFunc = () => RIntPtr(RIntPtr(RIntPtr(Address + 0x10) + 0x108)+0x38) };
            SpEffectParam = new Params() { AddressReadFunc = () => RIntPtr(RIntPtr(RIntPtr(Address + 0x10) + 0x198) + 0x38) };

            //SysMsg = new Param() { AddressReadFunc = () => RIntPtr(Address + 0x340) };
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
            //int startOffset;
            //int startIdx;
            int paramid;
            //int endId;
            numEntries = RInt16(Address + 0xA);
            //startOffset = RInt32(Address + 0x14);
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

        public string Param(int id)
        {
            IntPtr txtLoc = getOffset(id);
            if (txtLoc.Equals(IntPtr.Zero))
                { return ""; }
            return RUnicodeStr(txtLoc, 0x50);
        }
        public void Param(int id, string str)
        {
            IntPtr txtLoc = getOffset(id);
            if (!((long)txtLoc > (long)Address))
            { return; }
            WBytes(txtLoc, System.Text.Encoding.Unicode.GetBytes(str + '\0'));
        }
    }
}
