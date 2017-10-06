using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
    public class EntityLocation : IngameStruct
	{
        public EntityLocation(Func<int> addrReadFunc) : base(addrReadFunc) { }

        public EntityLocation(int addr) : base(addr) { }

        public EntityLocation()
        {

        }

        public override void OverwriteWith(dynamic other)
		{
			var oAngle = other.Angle;
			var oX = other.X;
			var oY = other.Y;
			var oZ = other.Z;

			Angle = oAngle;
			X = oX;
			Y = oY;
			Z = oZ;
		}

        public float Heading {
			get { return (float)((Hook.RFloat(Address + 0x4) / Math.PI * 180) + 180); }
			set { Hook.WFloat(Address + 0x4, (float)(value * Math.PI / 180) - (float)Math.PI); }
		}

		public float Angle {
			get { return Hook.RFloat(Address + 0x4); }
			set { Hook.WFloat(Address + 0x4, value); }
		}

		public float X {
			get { return Hook.RFloat(Address + 0x10); }
			set { Hook.WFloat(Address + 0x10, value); }
		}

		public float Y {
			get { return Hook.RFloat(Address + 0x14); }
			set { Hook.WFloat(Address + 0x14, value); }
		}

		public float Z {
			get { return Hook.RFloat(Address + 0x18); }
			set { Hook.WFloat(Address + 0x18, value); }
		}

	}

}
