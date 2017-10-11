using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public class MapEntry : IngameStruct
	{
        protected override void InitSubStructures()
        {

        }

        public int PointerToBlockAndArea {
			get { return Hook.RInt32(Address + 0x4); }
		}

		public byte Block {
			get { return Hook.RByte(PointerToBlockAndArea + 0x6); }
		}

		public byte Area {
			get { return Hook.RByte(PointerToBlockAndArea + 0x7); }
		}

		public int EntityCount {
			get { return Hook.RInt32(Address + 0x3c); }
		}

		public int StartOfEntityStruct {
			get { return Hook.RInt32(Address + 0x40); }
		}

		public ChrHeader[] GetEntityHeaders()
		{
			ChrHeader[] result = new ChrHeader[EntityCount];

			for (int i = 0; i <= result.Length - 1; i++) {
				result[i] = new ChrHeader() { AddressReadFunc = () => StartOfEntityStruct + (20 * i) };
			}

			return result;
		}

		public Chr[] GetEntities()
		{
			Chr[] result = new Chr[EntityCount];

			for (int i = 0; i <= EntityCount - 1; i++) {
				result[i] = new ChrHeader() { AddressReadFunc = () => StartOfEntityStruct + (20 * i) }.GetChr();
			}

			return result;
		}

		public ChrTransform[] GetEntityTransforms()
		{
			ChrTransform[] result = new ChrTransform[EntityCount];

			for (int i = 0; i <= EntityCount - 1; i++) {
				result[i] = new ChrHeader() { AddressReadFunc = () => StartOfEntityStruct + (20 * i) }.Transform;
			}

			return result;
		}
    }

}
