using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;
using Iced.Intel;
using DarkSoulsScripting.Injection.Structures;
using static Iced.Intel.AssemblerRegisters;

namespace DarkSoulsScripting
{
    public static class TexMan
    {
        public static IntPtr Address => RIntPtr(0x141d1cda8);

        public static Int32 NumTexHdlResCaps => RInt32(Address + 0x14);
        public static IntPtr PtrTexHdlResCaps => RIntPtr(Address + 0x18);



        public static TexHdlResCap[] TexHdlResCaps { get; private set; } = null;

        static TexMan()
        {
            TexHdlResCaps = new TexHdlResCap[NumTexHdlResCaps];
            for (int x = 0; x < NumTexHdlResCaps; x++)
            {
                IntPtr addr = RIntPtr(PtrTexHdlResCaps + x * IntPtr.Size);
                TexHdlResCaps[x] = new TexHdlResCap() { AddressReadFunc = () => addr };
            }

        }


        public static UInt32 GetHandleTexHdlResCap(string name)
        {

            for (int i = 0; i < NumTexHdlResCaps; i++)
            {
                if (name.Equals(TexHdlResCaps[i].ResName))
                {
                    return TexHdlResCaps[i].Handle;
                }
            }
            return 0;
        }

    }
}
