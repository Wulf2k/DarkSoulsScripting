using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{
	public class ChrSlot : GameStruct
	{
        public ChrTransform Transform = null;

        protected override void InitSubStructures()
        {
            Transform = new ChrTransform() { AddressReadFunc = () => TransformPtr };
        }

        public IntPtr ChrPtr {
			get { return Hook.RIntPtr(Address + 0x0); }
			set { Hook.WIntPtr(Address + 0x0, value); }
		}

        public Enemy GetChrAsEnemy()
        {
            return new Enemy() { AddressReadFunc = () => ChrPtr };
        }

        public Player GetChrAsPlayer()
        {
            return new Player() { AddressReadFunc = () => ChrPtr };
        }

		public int CloneValue {
			get { return Hook.RInt32(Address + 0x8); }
			set { Hook.WInt32(Address + 0x8, value); }
		}

		public IntPtr UnknownPtr1 {
			get { return Hook.RIntPtr(Address + 0x10); }
		}

		public IntPtr TransformPtr {
			get { return Hook.RIntPtr(Address + 0x18); }
			set { Hook.WIntPtr(Address + 0x18, value); }
		}

		public IntPtr UnknownPtr2 {
			get { return Hook.RIntPtr(Address + 0x1c); }
		}

		//TODO: See if writeable, also see wtf it even is lol
		public bool DeadFlag {
			get { return Hook.RBool(UnknownPtr2 + 0x14); }
		}

        public bool IsHide {
			get { return Hook.RBit(Address + 0x14, 5); }
			set { Hook.WBit(Address + 0x14, 5, value); }
		}

		public bool IsDisable {
            get { return Hook.RBit(Address + 0x14, 7); }
            set { Hook.WBit(Address + 0x14, 7, value); }
        }

	}

}
