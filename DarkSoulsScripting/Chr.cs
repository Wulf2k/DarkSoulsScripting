using System;
using DarkSoulsScripting.Injection;
using System.ComponentModel;
using DarkSoulsScripting.AI_DEFINE;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
	public abstract class Chr<TChrMovementCtrl, TChrController> : GameStruct
        where TChrController : ChrController, new()
        where TChrMovementCtrl : ChrMovementCtrl<TChrController>, new()
	{
        public const int MAX_NAME_LENGTH = 10;

        public ChrSlot Slot { get; private set; } = null;
        public TChrMovementCtrl MovementCtrl { get; private set; } = null;
        public ChrUNK1 UNK1 { get; private set; } = null;

        protected override void InitSubStructures()
        {
            Slot = new ChrSlot() { AddressReadFunc = () => SlotPtr };
            MovementCtrl = new TChrMovementCtrl() { AddressReadFunc = () => MovementCtrlPtr };
            UNK1 = new ChrUNK1() { AddressReadFunc = () => UNK1Ptr };
        }

        public int Handle
        {
            get { return RInt32(Address + 0x8);  }
            set { WInt32(Address + 0x8, value);  }
        }

        public IntPtr SlotPtr
        {
            get { return RIntPtr(IntPtr.Add(Address, 0x18)); }
			set { WIntPtr(Address + 0x18, value); }
		}

        public IntPtr UNK1Ptr
        {
            get { return RIntPtr(Address + 0x20); }
			set { WIntPtr(Address + 0x20, value); }
		}

		public bool DisableEventBackreadState
        {
            get { return RBool(Address + 0x28); }
			set { WBool(Address + 0x28, value); }
		}

        public IntPtr MovementCtrlPtr
        {
            get { return RIntPtr(Address + 0x68); }
            set { WIntPtr(Address + 0x68, value); }
        }

        public int TargetHandle
        {
            get { return RInt32(RIntPtr(Address + 0x70) + 0x220); }
            //immediately overwritten if set // set { WInt32(RIntPtr(Address + 0x70) + 0x220, value); }
        }


        public string ModelName {
			get { return RUnicodeStr(Address + 0x88, 10); }
			set { WUnicodeStr(Address + 0x88, value.Substring(0, Math.Min(value.Length, 10))); }
		}

        public IntPtr UnknownMSBStructPointer {

			get { return RIntPtr(Address + 0xB0); }
			set { WIntPtr(Address + 0xB0, value); }
		}

        public int UnknownMSBStructIndex {
            get { return RInt32((Address + 0x98, IntPtr.Zero, Address + 0xB8)); }
			set { WInt32((Address + 0x98, IntPtr.Zero, Address + 0xB8), value); }
		}

		public int NPCParam {
			get { return RInt32(Address + 0xC8); }
			set { WInt32(Address + 0xC8, value); }
		}

		public int ChrInitParam {
			get { return RInt32(Address + 0xCC); }
			set { WInt32(Address + 0xCC, value); }
		}

		public CHR_TYPE ChrType {
			get { return (CHR_TYPE)RInt32(Address + 0xD4); }
			set { WInt32(Address + 0xD4, (int)value); }
		}

		public TEAM_TYPE TeamType {
			get { return (TEAM_TYPE)RInt32(Address + 0xD8); }
			set { WInt32(Address + 0xD8, (int)value); }
		}

		public float Opacity {
            
			get { return RFloat((Address + 0x258, IntPtr.Zero, Address + 0x328)); }
			set { WFloat((Address + 0x258, IntPtr.Zero, Address + 0x328), value); }
		}
        
		public int HP {
			get { return RInt32(Address + 0x3E8); }
			set { WInt32(Address + 0x3E8, value); }
		}

		public int MaxHP {
			get { return RInt32(Address + 0x3EC); }
			set { WInt32(Address + 0x3EC, value); }
		}

        public int TalkID
        {
            //DSR
            //Confirm
            get { return RInt32(Address + 0x464);  }
            set { WInt32(Address + 0x464, value); }
        }

        public IntPtr StatsPtr
        {
            
            get { return RIntPtr(Address + 0x578); }
            set { WIntPtr(Address + 0x578, value); }
        }
        /*
        #region "DebugFlags"
        public bool NoGoodsConsume {
            get { return RBit(Address + 0x525, 7); }
            set { WBit(Address + 0x525, 7, value); }
        }

		public bool DisableDrawingA {
            get { return RBit(Address + 0x525, 11); }
            set { WBit(Address + 0x525, 11, value); }
        }

		public bool DrawCounter {
            get { return RBit(Address + 0x525, 10); }
            set { WBit(Address + 0x525, 10, value); }
        }

		public bool DisableDrawingB {
            get { return RBit(Address + 0x525, 12); }
            set { WBit(Address + 0x525, 12, value); }
        }

		public bool DrawDirection {
            get { return RBit(Address + 0x525, 17); }
            set { WBit(Address + 0x525, 17, value); }
        }

		public bool NoUpdate {
            get { return RBit(Address + 0x525, 16); }
            set { WBit(Address + 0x525, 16, value); }
        }

		public bool NoAttack {
            get { return RBit(Address + 0x525, 23); }
            set { WBit(Address + 0x525, 23, value); }
        }

		public bool NoMove {
            //DSR
            get { return RBit(Address + 0x525, 22); }
            set { WBit(Address + 0x525, 22, value); }
        }

		public bool NoStamConsume {
            get { return RBit(Address + 0x525, 21); }
            set { WBit(Address + 0x525, 21, value); }
        }

		public bool NoMPConsume {
            get { return RBit(Address + 0x525, 20); }
            set { WBit(Address + 0x525, 20, value); }
        }

		public bool NoDead {
            get { return RBit(Address + 0x525, 26); }
            set { WBit(Address + 0x525, 26, value); }
        }

		public bool NoDamage {
            get { return RBit(Address + 0x525, 25); }
            set { WBit(Address + 0x525, 25, value); }
        }

        public bool NoHit
        {
            get { return RBit(Address + 0x525, 24); }
            set { WBit(Address + 0x525, 24, value); }
        }

        public bool DrawHit {
            get { return RBit(Address + 0x525, 29); }
            set { WBit(Address + 0x525, 29, value); }
        }
		#endregion

		#region "Flags"
		public bool DisableDamage {
			get { return RBit(Address + 0x1FC, 5); }
			set { WBit(Address + 0x1FC, 5, value); }
		}

		public bool EnableInvincible {
            get { return RBit(Address + 0x1FC, 4); }
            set { WBit(Address + 0x1FC, 4, value); }
        }

		public bool FirstPersonView {
            get { return RBit(Address + 0x1FC, 11); }
            set { WBit(Address + 0x1FC, 11, value); }
        }

		public bool DeadMode {
            get { return RBit(Address + 0x1FC, 6); }
            set { WBit(Address + 0x1FC, 6, value); }
        }

		public bool DisableGravity {
            get { return RBit(Address + 0x1FC, 17); }
            set { WBit(Address + 0x1FC, 17, value); }
        }

		public bool SetDrawEnable {
            get { return RBit(Address + 0x1FC, 8); }
            set { WBit(Address + 0x1FC, 8, value); }
        }

        //TODO: CHECK WTF THIS EVEN IS. BLAME WULF
        public bool DisableGravity2
        {
            get { return RBit(Address + 0x1FC, 9); }
            set { WBit(Address + 0x1FC, 9, value); }
        }

        //CRASHES GAME
        public bool OmissionLock
        {
            get { return RBit(Address + 0x1FC, 15); }
            set { WBit(Address + 0x1FC, 15, value); }
        }

        public bool ForceUpdateNextFrame
        {
            get { return RBit(Address + 0x1FC, 14); }
            set { WBit(Address + 0x1FC, 14, value); }
        }

        public bool ForcePlayAnimationStayCancel
        {
            get { return RBit(Address + 0x1FC, 21); }
            set { WBit(Address + 0x1FC, 21, value); }
        }

        public bool Generate
        {
            get { return RBit(Address + 0x1FC, 27); }
            set { WBit(Address + 0x1FC, 27, value); }
        }

        public bool DisableHpGauge
        {
            get { return RBit(Address + 0x1FC, 28); }
            set { WBit(Address + 0x1FC, 28, value); }
        }
        #endregion
        */
        public void View()
		{
            
            WIntPtr((RIntPtr((0x137D648, 0, 0x141D151F8))+0xEC, IntPtr.Zero, RIntPtr((0x137D648, 0, 0x141D151F8))+0xF0), Address);
        }
        
        public void WarpToCoords(float x, float y, float z, float heading)
        {
            
            MovementCtrl.WarpX = x;
            MovementCtrl.WarpY = y;
            MovementCtrl.WarpZ = z;
            MovementCtrl.WarpHeading = heading;
            MovementCtrl.WarpActivate = true;
        }

        public void WarpToTransform(ChrTransform dest)
        {
            WarpToCoords(dest.X, dest.Y, dest.Z, dest.Heading);
        }

		public void WarpToPlayer(Player dest)
		{
            
            WarpToTransform(dest.MovementCtrl.Transform);
		}

        public void WarpToEnemy(Enemy dest)
		{
            WarpToTransform(dest.MovementCtrl.Transform);
		}

        public void SwitchControlPlayer()
        {
            MovementCtrl.DebugPlayerControllerPtr = WorldChrMan.LocalPlayer.MovementCtrl.ControllerPtr;
            IngameFuncs.EnableLogic(10000, 0);
            View();
        }

        public void ReturnControlPlayer()
        {
            MovementCtrl.DebugPlayerControllerPtr = IntPtr.Zero;
            IngameFuncs.EnableLogic(10000, 1);
            WorldChrMan.LocalPlayer.View();
        }

        public string GetName()
        {
            
            return RAsciiStr(RIntPtr(UnknownMSBStructPointer + 0x1f0) + 0x64 + 0xD0 * UnknownMSBStructIndex, MAX_NAME_LENGTH);
        }

        public Enemy GetTargetAsEnemy()
        {
            //public TChr GetChr() => new TChr() { AddressReadFunc = () => ChrPtr };
            MapEntry currmap = Map.GetCurrent();
            return currmap.GetChrsAsEnemies().Find(x => x.Handle == TargetHandle);
        }
    }
}
