using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class WorldChrMan
    {
        //Taken from the Dark Souls 1 Overhaul IDA Workspace.
        public const int CHR_STRUCT_SIZE = 0x5F8;

        public static IntPtr Address => RIntPtr((0x137DC70, 0, 0x141D0C520));

        public static Player LocalPlayer { get; private set; } = null;

        static WorldChrMan()
        {
            LocalPlayer = new Player() { AddressReadFunc = () => RIntPtr(ChrsBegin + 0x0) };
        }

        //TODO: SEE IF THESE ARE ALL ENEMIES OR WHAT.
        public static List<Enemy> GetEnemies()
        {
            var result = new List<Enemy>();
            for (Int64 i = (Int64)ChrsBegin; i <= (Int64)ChrsEnd; i += IntPtr.Size)
            {
                IntPtr thisEnemyAddress = RIntPtr(i);
                result.Add(new Enemy() { AddressReadFunc = () => thisEnemyAddress });
            }
            return result;
        }

        public static EnemyPtrAccessor EnemyPtr = new EnemyPtrAccessor();

        public class EnemyPtrAccessor
        {
            public IntPtr this[int index]
            {
                //DSR
                get => RIntPtr(ChrsBegin + (index * IntPtr.Size));
                set => WIntPtr(ChrsBegin + (index * IntPtr.Size), value);
            }
        }

        public static IntPtr ChrsBegin
        {
            //DSR
            get => RIntPtr(Address + IntPtr.Size);
            set => WIntPtr(Address + IntPtr.Size, value);
        }

        public static IntPtr ChrsEnd
        {
            //DSR
            get => RIntPtr(Address + IntPtr.Size * 2);
            set => WIntPtr(Address + IntPtr.Size * 2, value);
        }
    }
}
