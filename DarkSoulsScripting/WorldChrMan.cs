using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class WorldChrMan
    {
        public const int CHR_STRUCT_SIZE = 0x5F8;

        public static Player LocalPlayer { get; private set; } = null;
        public static List<WorldBlockChr> LoadedWorldBlockChrs = null;



        public static IntPtr Address => RIntPtr(0x141d151b0);


        static WorldChrMan()
        {
            LocalPlayer = new Player() { AddressReadFunc = () => LocalPlayerPtr };
            LoadedWorldBlockChrs = new List<WorldBlockChr>();
            for (int x = 0; x < numLoadedWorldBlockChrs; x++)
            {
                IntPtr addr = RIntPtr(LoadedWorldBlockChrStart + x * 8);
                LoadedWorldBlockChrs.Add(new WorldBlockChr() { AddressReadFunc = () => addr });
            }
                

        }

        

        
        public static Int32 numWorldBlockChrs => RInt32(Address + 0x28);
        public static IntPtr WorldBlockChrPtr => RIntPtr(Address + 0x30);
        public static IntPtr LocalPlayerPtr => RIntPtr(Address + 0x68);
        public static Int32 numLoadedWorldBlockChrs => RInt32(Address + 0xA0);
        public static IntPtr LoadedWorldBlockChrStart => Address + 0xA8;




        public static List<Enemy> GetEnemies()
        {
            var result = new List<Enemy>();

            foreach (WorldBlockChr wbc in LoadedWorldBlockChrs)
            {
                Console.WriteLine(wbc.Address.ToString("X"));
                if (wbc.ChrCount > 0)
                    foreach (Enemy nme in wbc.GetEnemies())
                        result.Add(nme);
            }
            return result;
        }
        public static Enemy GetEnemyByName(string name)
        {
            foreach (var e in GetEnemies())
            {
                if (e.GetName() == name)
                    return e;
            }
            return null;
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
