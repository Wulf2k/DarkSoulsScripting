using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class WorldBlockChr : GameStruct
    {
        public MsbResCap Msb { get; private set; } = null;

        protected override void InitSubStructures()
        {
            Msb = new MsbResCap() { AddressReadFunc = () => MsbResCapPtr };
        }

        public WorldBlockChr()
        {

        }

        public IntPtr MsbResCapPtr => RIntPtr(Address + 0x10);
        public int ChrCount => RInt32(Address + 0x48);
        public IntPtr ChrSlotsPtr => RIntPtr(Address + 0x50);

        public List<ChrSlot> GetChrSlots()
        {
            List<ChrSlot> result = new List<ChrSlot>();

            for (int i = 0; i < ChrCount; i++)
            {
                IntPtr addr = ChrSlotsPtr + (IntPtr.Size * 7 * i);
                result.Add(new ChrSlot() { AddressReadFunc = () => addr });
            }

            return result;
        }

        public List<Enemy> GetEnemies()
        {
            List<Enemy> result = new List<Enemy>();

            for (int i = 0; i < ChrCount; i++)
            {
                var addr = ChrSlotsPtr + (IntPtr.Size * 7 * i);

                Console.WriteLine(addr.ToString("X"));
                result.Add(new ChrSlot() { AddressReadFunc = () => addr }.GetEnemy());
            }

            return result;
        }
    }
}
