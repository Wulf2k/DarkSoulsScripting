using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public class Map
	{
		public const int BasePointer = 0x137d644;
		public static int Address {
			get { return Hook.RInt32(BasePointer); }
		}

		public static int CharData1Address {
			get { return Hook.RInt32(Address + 0x3c); }
		}

		public static int MapEntryCount {
			get { return Hook.RInt32(Address + 0x70); }
		}

		public static MapEntry[] GetEntries()
		{
			MapEntry[] result = new MapEntry[MapEntryCount];
			for (int i = 0; i <= result.Length - 1; i++) {
				result[i] = new MapEntry() { AddressReadFunc = () => Address + 0x74 + (4 * i) };
			}
			return result;
		}

	}

}
