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

        public IntPtr ChrPtr
        {
			get { return Hook.RIntPtr(Address + 0x0); }
			set { Hook.WIntPtr(Address + 0x0, value); }
		}

        public Enemy GetEnemy()
        {
            return new Enemy() { AddressReadFunc = () => ChrPtr };
        }

        public Player GetPlayer()
        {
            return new Player() { AddressReadFunc = () => ChrPtr };
        }

		public int CloneValue {
            //DSR
			get { return Hook.RInt32(Address + 0x10); }
			set { Hook.WInt32(Address + 0x8, value); }
		}

		public IntPtr UnknownPtr1 {
            //DSR
			get { return Hook.RIntPtr(Address + 0x28); }
		}

		public IntPtr TransformPtr {
            //DSR
			get { return Hook.RIntPtr(Address + 0x28); }
			set { Hook.WIntPtr(Address + 0x28, value); }
		}

		public IntPtr UnknownPtr2 {
            //DSR
			get { return Hook.RIntPtr(Address + 0x30); }
		}

		//TODO: See if writeable, also see wtf it even is lol
		public bool DeadFlag {
			get { return Hook.RBool(UnknownPtr2 + 0x14); }
		}

        public bool IsHide {
            //DSR
			get { return Hook.RBit(Address + 0x20, 5); }
			set { Hook.WBit(Address + 0x20, 5, value); }
		}

		public bool IsDisable {
            get { return Hook.RBit(Address + 0x20, 7); }
            set { Hook.WBit(Address + 0x20, 7, value); }
        }

	}

}
