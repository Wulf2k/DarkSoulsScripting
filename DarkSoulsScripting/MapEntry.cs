using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public class MapEntry : IngameStruct
	{
        public MapEntry(int addr) : base(addr)
        {
        }

        public MapEntry(Func<int> addrReadFunc) : base(addrReadFunc)
        {
        }

        public MapEntry()
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

		public EntityHeader[] GetEntityHeaders()
		{
			EntityHeader[] result = new EntityHeader[EntityCount];

			for (int i = 0; i <= result.Length - 1; i++) {
				result[i] = new EntityHeader(StartOfEntityStruct + (Size * i));
			}

			return result;
		}

		public Entity[] GetEntities()
		{
			Entity[] result = new Entity[EntityCount];

			for (int i = 0; i <= EntityCount - 1; i++) {
				result[i] = new EntityHeader(StartOfEntityStruct + (Size * i)).Entity;
			}

			return result;
		}

		public EntityLocation[] GetEntityLocations()
		{
			EntityLocation[] result = new EntityLocation[EntityCount];

			for (int i = 0; i <= EntityCount - 1; i++) {
				result[i] = new EntityHeader(StartOfEntityStruct + (Size * i)).Location;
			}

			return result;
		}

        public override void OverwriteWith(dynamic other)
        {
            throw new NotImplementedException();
        }
    }

}
