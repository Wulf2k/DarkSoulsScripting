using System;
using DarkSoulsScripting.Injection;
using System.Collections.Generic;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class MapEntry : GameStruct
	{
        public const int MAX_NAME_LENGTH = 12;

        protected override void InitSubStructures()
        {

        }

        public string GetName()
        {
            //DSR
            return RUnicodeStr(RIntPtr(RIntPtr(Address + 0x90) + IntPtr.Size), MAX_NAME_LENGTH);
        }

        public Enemy FindEnemy(int modelID, int instanceNum)
        {
            string nameFormat = $"c{modelID:4}_{instanceNum:4}";
            foreach (var e in GetChrsAsEnemies())
            {
                if (e.GetName() == nameFormat)
                    return e;
            }
            return null;
        }

        public IntPtr PointerToBlockAndArea {
            //DSR
			get { return RIntPtr(Address + IntPtr.Size); }
		}

		public byte Block {
            //DSR
            get { return RByte(PointerToBlockAndArea + IntPtr.Size + 0x2); }
		}

		public byte Area {
            //DSR
            get { return RByte(PointerToBlockAndArea + IntPtr.Size + 0x3); }
		}

		public int ChrCount {
            //DSR
			get { return RInt32(Address + 0x48); }
		}

        public IntPtr StartOfChrStruct {
            //DSR
            get { return RIntPtr(Address + 0x50); }
        }

        public List<ChrSlot> GetChrSlots()
		{
            //DSR
            List<ChrSlot> result = new List<ChrSlot>();

			for (int i = 0; i < ChrCount; i++) {
                IntPtr addr = StartOfChrStruct + (IntPtr.Size * 7 * i);
                result.Add(new ChrSlot() { AddressReadFunc = () => addr });
			}

			return result;
		}

		public List<Enemy> GetChrsAsEnemies()
		{
            //DSR
            List<Enemy> result = new List<Enemy>();

			for (int i = 0; i < ChrCount; i++) {
                var addr = StartOfChrStruct + (IntPtr.Size * 7 * i);
                result.Add(new ChrSlot() { AddressReadFunc = () => addr }.GetChrAsEnemy());
			}

			return result;
		}

		public List<ChrTransform> GetChrTransforms()
		{
            //DSR
            List<ChrTransform> result = new List<ChrTransform>();

			for (int i = 0; i < ChrCount; i++) {
                var addr = StartOfChrStruct + (IntPtr.Size * 7 * i);
                result.Add(new ChrSlot() { AddressReadFunc = () => addr }.Transform);
			}

			return result;
		}
    }

}
