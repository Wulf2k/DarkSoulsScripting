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
        
        public const int CHR_STRUCT_SIZE = 0x5F8;


        //DSR 1.03

        //Hey, this isn't WorldChrMan....
        //WorldChrManAddress = 0x141d151b0
        //public static IntPtr Address => RIntPtr((0x137DC70, 0, 0x141D1F710));
        public static IntPtr Address => RIntPtr(0x141d151b0);

        public static Player LocalPlayer { get; private set; } = null;

        static WorldChrMan()
        {
            LocalPlayer = new Player() { AddressReadFunc = () => RIntPtr(Address + 0x68) };
        }

        //This is not all enemies.
        public static List<Enemy> GetEnemies()
        {
            var result = new List<Enemy>();
            for (Int64 i = (Int64)ChrsBegin; i < (Int64)ChrsEnd; i += IntPtr.Size)
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
            get => RIntPtr(RIntPtr(0x141D1F710) + IntPtr.Size);
            set => WIntPtr(RIntPtr(0x141D1F710) + IntPtr.Size, value);
        }

        public static IntPtr ChrsEnd
        {
            //DSR
            get => RIntPtr(RIntPtr(0x141D1F710) + IntPtr.Size * 2);
            set => WIntPtr(RIntPtr(0x141D1F710) + IntPtr.Size * 2, value);
        }
    }
}
