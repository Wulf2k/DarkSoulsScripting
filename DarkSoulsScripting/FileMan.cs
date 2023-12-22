using System;
using DarkSoulsScripting.Injection;
using static DarkSoulsScripting.Hook;

using Iced.Intel;
using DarkSoulsScripting.Injection.Structures;
using static Iced.Intel.AssemblerRegisters;
using DarkSoulsScripting.Injection.DLL;

namespace DarkSoulsScripting
{
    public class FileMan
    {

        //DSR1310
        public static IntPtr Address => RIntPtr(0x141c81198);

        

    }
}
