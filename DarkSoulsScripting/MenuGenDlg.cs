using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class MenuGenDlg : GameStruct
    {
        protected override void InitSubStructures()
        {

        }

        public Int32 MsgID
        {
            get { return RInt32(Address); }
            set { WInt32(Address, value); }
        }
        public Int32 DialogID_1
        {
            get { return RInt32(Address+0x4); }
            set { WInt32(Address+0x4, value); }
        }
        public Int32 DialogID_2
        {
            get { return RInt32(Address+0x8); }
            set { WInt32(Address+0x8, value); }
        }
        public Int32 OverrideMsgID
        {
            get { return RInt32(Address + 0x18); }
            set { WInt32(Address + 0x18, value); }
        }

        public Int32 BtnResponse
        {
            get { return RInt32(Address + 0x38); }
            set { WInt32(Address + 0x38, value); }
        }
        public Int32 QtyResponse
        {
            get { return RInt32(Address + 0x3c); }
            set { WInt32(Address + 0x3c, value); }
        }
        public Int32 QtyCurrent
        {
            get { return RInt32(Address + 0x40); }
            set { WInt32(Address + 0x40, value); }
        }
    }
}
