using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{

    public class MsbResCap : ResCap
    {
        protected override void InitSubStructures()
        {

        }


        static MsbResCap()
        {

        }

        public IntPtr MsbFile => RIntPtr(Address + 0x28);
        public IntPtr Models => RIntPtr(Address + 0x60);
        public IntPtr Objs => RIntPtr(Address + 0x70);
        public IntPtr ChrData => RIntPtr(Address + 0x80);
        public IntPtr Hkxs => RIntPtr(Address + 0xb0);
        public IntPtr Nvms => RIntPtr(Address + 0xc0);
        public IntPtr Sfxs => RIntPtr(Address + 0x110);
        public IntPtr Treasures => RIntPtr(Address + 0x130);

        public Int32 numChrs => RInt32(Address + 0x1e8);
        public IntPtr Chrs => RIntPtr(Address + 0x1f0);  //0xD0 per char

    }
}
