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
        public static Fmg DlgMsg { get; private set; } = null;
        public static Fmg EventMsg { get; private set; } = null;
        public static Fmg MenuOthersMsg { get; private set; } = null;
        public static Fmg SysMsg { get; private set; } = null;
        

        static MsgMan()
        {
            EventMsg = new Fmg() { AddressReadFunc = () => RIntPtr(Address + 0xF8) };
            DlgMsg = new Fmg() { AddressReadFunc = () => RIntPtr(Address + 0x338) };
            SysMsg = new Fmg() { AddressReadFunc = () => RIntPtr(Address + 0x340) };
            MenuOthersMsg = new Fmg() { AddressReadFunc = () => RIntPtr(Address + 0x3E0) };
        }

    }

    public class Fmg : GameStruct
    {
        protected override void InitSubStructures()
        {

        }


        public IntPtr getOffset(int id)
        {
            int numEntries;
            int startOffset;
            int startIdx;
            int startId;
            int endId;
            numEntries = RInt32(Address + 0xC);
            startOffset = RInt32(Address + 0x14);
            for (int i = 0; i < numEntries; i++)
            {
                startIdx = RInt32(Address + 0x1c + i * 0xC);
                startId = RInt32(Address + 0x1c + i * 0xC + 4);
                endId = RInt32(Address + 0x1c + i * 0xC + 8);

                if ((id >= startId) && (id <= endId))
                {
                    return Address + RInt32(Address + startOffset + 4 * (startIdx + id - startId));
                }
            }
            return IntPtr.Zero;
            
        }

        public string Msg(int id)
        {
            IntPtr txtLoc = getOffset(id);
            if (txtLoc.Equals(IntPtr.Zero))
                { return ""; }
            return RUnicodeStr(txtLoc, 0x50);
        }
        public void Msg(int id, string str)
        {
            IntPtr txtLoc = getOffset(id);
            if (!((long)txtLoc > (long)Address))
            { return; }
            WBytes(txtLoc, System.Text.Encoding.Unicode.GetBytes(str + '\0'));
        }
    }
}
