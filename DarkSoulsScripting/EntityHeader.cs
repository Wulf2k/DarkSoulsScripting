using System;
using DarkSoulsScripting.Injection;

namespace DarkSoulsScripting
{

    [Flags]
	public enum EntityHeaderFlagsA : byte
	{
		None = 0x0,
		Disabled = 0x1,
		PlayerHide = 0x4
	}

	public class EntityHeader : IngameStruct
	{
        public EntityHeader(Func<int> addrReadFunc) : base(addrReadFunc)
        {

        }

        public EntityHeader(int addr) : base(addr)
        {

        }

        public EntityHeader()
        {

        }

        public override void OverwriteWith(dynamic other)
        {
            Hook.WBytes(Address, Hook.RBytes(other.Address, other.Size));
        }

        protected override void InitStructMembers()
        {
            Location = new EntityLocation(() => LocationPtr);
        }

        public override int Size { get => 0x20; }

        public EntityLocation Location = null;

		public int EntityPtr {
			get { return Hook.RInt32(Address + 0x0); }
			set { Hook.WInt32(Address + 0x0, value); }
		}

		public Entity Entity {
			get { return new Entity(() => EntityPtr); }
		}

		public int CloneValue {
			get { return Hook.RInt32(Address + 0x8); }
			set { Hook.WInt32(Address + 0x8, value); }
		}

		public int UnknownPtr1 {
			get { return Hook.RInt32(Address + 0x10); }
		}

		public EntityHeaderFlagsA FlagsA {
			get { return (EntityHeaderFlagsA)Hook.RByte(Address + 0x14); }
			set { Hook.WByte(Address + 0x14, Convert.ToByte(value)); }
		}


		public int LocationPtr {
			get { return Hook.RInt32(Address + 0x18); }
			set { Hook.WInt32(Address + 0x18, value); }
		}

		public int UnknownPtr2 {
			get { return Hook.RInt32(Address + 0x1c); }
		}

		//TODO: See if writeable, also see wtf it even is lol
		public bool DeadFlag {
			get { return Hook.RBool(UnknownPtr2 + 0x14); }
		}
		#region "Flags"
		public bool GetFlagA(EntityHeaderFlagsA flg)
		{
			return FlagsA.HasFlag(flg);
		}

		public void SetFlagA(EntityHeaderFlagsA flg, bool state)
		{
			if (state) {
				FlagsA = FlagsA | flg;
			} else {
				FlagsA = FlagsA & (~flg);
			}
		}

        public bool PlayerHide {
			get { return GetFlagA(EntityHeaderFlagsA.PlayerHide); }
			set { SetFlagA(EntityHeaderFlagsA.PlayerHide, value); }
		}

		public bool Disabled {
			get { return GetFlagA(EntityHeaderFlagsA.Disabled); }
			set { SetFlagA(EntityHeaderFlagsA.Disabled, value); }
		}
		#endregion


	}

}
