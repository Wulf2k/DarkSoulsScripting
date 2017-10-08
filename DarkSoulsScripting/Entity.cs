using System;
using DarkSoulsScripting.Injection;
using System.ComponentModel;
using DarkSoulsScripting.AI_DEFINE;

namespace DarkSoulsScripting
{

    [Flags]
	public enum EntityFlagsA
	{
		SetDeadMode = 0x2000000,
		DisableDamage = 0x4000000,
		EnableInvincible = 0x8000000,
		FirstPersonView = 0x100000,
		SetDrawEnable = 0x800000,
		SetSuperArmor = 0x10000,
		SetDisableGravity = 0x4000
	}

	[Flags]
	public enum EntityFlagsB
	{
		DisableHpGauge = 0x8
	}

	[Flags]
	public enum EntityDebugFlags
	{
		NoGoodsConsume = 0x1000000,
		DisableDrawingA = 0x100000,
		DrawCounter = 0x200000,
		DisableDrawingB = 0x80000,
		DrawDirection = 0x4000,
		NoUpdate = 0x8000,
		NoAttack = 0x100,
		NoMove = 0x200,
		NoStamConsume = 0x400,
		NoMPConsume = 0x800,
		NoDead = 0x20,
		NoDamage = 0x40,
		NoHit = 0x80,
		DrawHit = 0x4
	}

	[Flags]
	public enum EntityMapFlagsA : byte
	{
		None = 0,
		EnableLogic = 0x1
	}

	[Flags]
	public enum EntityMapFlagsB : byte
	{
		None = 0,
		DisableCollision = 0x40
	}
	
	public class Entity : IngameStruct
	{
        public static Entity Player = new Entity(() => ExtraFuncs.GetEntityPtr(10000));

        public EntityLocation Location { get; private set; } = null;
        public EntityHeader Header { get; private set; } = null;
        public EntityStats Stats { get; private set; } = null;

        protected override void InitStructMembers()
        {
            Location = new EntityLocation(() => LocationPtr);
            Header = new EntityHeader(() => HeaderPtr);
            Stats = new EntityStats(() => StatsPtr);
        }

        public Entity(Func<int> addrReadFunc) : base(addrReadFunc)
        {
        }

        public Entity(int addr) : base(addr)
        {
        }

        public Entity()
        {
        }

        public int HeaderPtr {
			get { return Hook.RInt32(Address + 0xc); }
			set { Hook.WInt32(Address + 0xc, value); }
		}

		public bool DisableEventBackreadState {
			get { return Hook.RBool(Address + 0x14); }
			set { Hook.WBool(Address + 0x14, value); }
		}



		public int DebugControllerPtr {
			get { return Hook.RInt32(CharMapDataPtr + 0x244); }
			set { Hook.WInt32(CharMapDataPtr + 0x244, value); }
		}

		public EntityController DebugController {
			get { return new EntityController(() => DebugControllerPtr); }
			set { DebugControllerPtr = value.Pointer; }
		}

		public static Entity GetPlayer()
		{
			return FromID(10000);
		}

		public static Entity FromID(int id)
		{
			return new Entity(() => ExtraFuncs.GetEntityPtr(id));
		}

		public static Entity FromName(string mapName, string entityName)
		{
			return new Entity(() => ExtraFuncs.GetEntityPtrByName(mapName, entityName));
		}

		public string ModelName {
			get { return Hook.RUnicodeStr(Address + 0x38, 10); }
			set { Hook.WUnicodeStr(Address + 0x38, value.Substring(0, Math.Min(value.Length, 10))); }
		}

		public int NPCID {
			get { return Hook.RInt32(Address + 0x68); }
			set { Hook.WInt32(Address + 0x68, value); }
		}

		public int NPCID2 {
			get { return Hook.RInt32(Address + 0x6c); }
			set { Hook.WInt32(Address + 0x6c, value); }
		}

		public CHR_TYPE ChrType {
			get { return (CHR_TYPE)Hook.RInt32(Address + 0x70); }
			set { Hook.WInt32(Address + 0x70, (int)value); }
		}

		public TEAM_TYPE TeamType {
			get { return (TEAM_TYPE)Hook.RInt32(Address + 0x74); }
			set { Hook.WInt32(Address + 0x74, (int)value); }
		}

		public bool IsTargetLocked {
			get { return Hook.RBool(Address + 0x128); }
			set { Hook.WBool(Address + 0x128, value); }
		}

		public int DeathStructPointer {
			get { return Hook.RInt32(Address + 0x170); }
		}

		public bool IsDead {
			get { return Hook.RBool(DeathStructPointer + 0x18); }
		}
		//Writing value crashed game...
		//Set(value As Boolean)
		//    WBool(DeathStructPointer + &H18, value)
		//End Set

		public float PoiseCurrent {
			get { return Hook.RFloat(Address + 0x1c0); }
			set { Hook.WFloat(Address + 0x1c0, value); }
		}

		public float PoiseMax {
			get { return Hook.RFloat(Address + 0x1c4); }
			set { Hook.WFloat(Address + 0x1c4, value); }
		}

		public float PoiseRecoverTimer {
			get { return Hook.RFloat(Address + 0x1cc); }
			set { Hook.WFloat(Address + 0x1cc, value); }
		}

		public EntityFlagsA FlagsA {
			get { return (EntityFlagsA)Hook.RInt32(Address + 0x1fc); }
			set { Hook.WInt32(Address + 0x1fc, (int)value); }
		}

		public EntityFlagsB FlagsB {
			get { return (EntityFlagsB)Hook.RInt32(Address + 0x200); }
			set { Hook.WInt32(Address + 0x200, (int)value); }
		}

		public int ChrID {
			get { return Hook.RInt32(Address + 0x208); }
			set { Hook.WInt32(Address + 0x208, value); }
		}

		public float Opacity {
			get { return Hook.RFloat(Address + 0x258); }
			set { Hook.WFloat(Address + 0x258, value); }
		}

		public int DrawGroup1 {
			get { return Hook.RInt32(Address + 0x264); }
			set { Hook.WInt32(Address + 0x264, value); }
		}

		public int DrawGroup2 {
			get { return Hook.RInt32(Address + 0x268); }
			set { Hook.WInt32(Address + 0x268, value); }
		}

		public int DrawGroup3 {
			get { return Hook.RInt32(Address + 0x26c); }
			set { Hook.WInt32(Address + 0x26c, value); }
		}

		public int DrawGroup4 {
			get { return Hook.RInt32(Address + 0x270); }
			set { Hook.WInt32(Address + 0x270, value); }
		}

		public int DispGroup1 {
			get { return Hook.RInt32(Address + 0x274); }
			set { Hook.WInt32(Address + 0x274, value); }
		}

		public int DispGroup2 {
			get { return Hook.RInt32(Address + 0x278); }
			set { Hook.WInt32(Address + 0x278, value); }
		}

		public int DispGroup3 {
			get { return Hook.RInt32(Address + 0x27c); }
			set { Hook.WInt32(Address + 0x27c, value); }
		}

		public int DispGroup4 {
			get { return Hook.RInt32(Address + 0x280); }
			set { Hook.WInt32(Address + 0x280, value); }
		}

		public int MultiplayerZone {
			get { return Hook.RInt32(Address + 0x284); }
			set { Hook.WInt32(Address + 0x284, value); }
		}

		public short Material_Floor {
			get { return Hook.RInt16(Address + 0x288); }
			set { Hook.WInt16(Address + 0x288, value); }
		}

		public short Material_ArmorSE {
			get { return Hook.RInt16(Address + 0x28a); }
			set { Hook.WInt16(Address + 0x28a, value); }
		}

		public short Material_ArmorSFX {
			get { return Hook.RInt16(Address + 0x28c); }
			set { Hook.WInt16(Address + 0x28c, value); }
		}

		public int HP {
			get { return Hook.RInt32(Address + 0x2d4); }
			set { Hook.WInt32(Address + 0x2d4, value); }
		}

		public int MaxHP {
			get { return Hook.RInt32(Address + 0x2d8); }
			set { Hook.WInt32(Address + 0x2d8, value); }
		}

		public int Stamina {
			get { return Hook.RInt32(Address + 0x2e4); }
			set { Hook.WInt32(Address + 0x2e4, value); }
		}

		public int MaxStamina {
			get { return Hook.RInt32(Address + 0x2e8); }
			set { Hook.WInt32(Address + 0x2e8, value); }
		}

		public int ResistancePoisonCurrent {
			get { return Hook.RInt32(Address + 0x300); }
			set { Hook.WInt32(Address + 0x300, value); }
		}

		public int ResistanceToxicCurrent {
			get { return Hook.RInt32(Address + 0x304); }
			set { Hook.WInt32(Address + 0x304, value); }
		}

		public int ResistanceBleedCurrent {
			get { return Hook.RInt32(Address + 0x308); }
			set { Hook.WInt32(Address + 0x308, value); }
		}

		public int ResistanceCurseCurrent {
			get { return Hook.RInt32(Address + 0x30c); }
			set { Hook.WInt32(Address + 0x30c, value); }
		}

		public int ResistancePoisonMax {
			get { return Hook.RInt32(Address + 0x310); }
			set { Hook.WInt32(Address + 0x310, value); }
		}

		public int ResistanceToxicMax {
			get { return Hook.RInt32(Address + 0x314); }
			set { Hook.WInt32(Address + 0x314, value); }
		}

		public int ResistanceBleedMax {
			get { return Hook.RInt32(Address + 0x318); }
			set { Hook.WInt32(Address + 0x318, value); }
		}

		public int ResistanceCurseMax {
			get { return Hook.RInt32(Address + 0x31c); }
			set { Hook.WInt32(Address + 0x31c, value); }
		}

		public int Unknown1Ptr {
			get { return Hook.RInt32(Address + 0x330); }
			set { Hook.WInt32(Address + 0x330, value); }
		}

        //TODO: Move CharMapData to separate struct

        #region CharMapData

        public int CharMapDataPtr {
			get { return Hook.RInt32(Address + 0x28); }
			set { Hook.WInt32(Address + 0x28, value); }
		}

		public EntityMapFlagsA MapFlagsA {
			get { return (EntityMapFlagsA)Hook.RByte(CharMapDataPtr + 0xC0); }
			set { Hook.WByte(CharMapDataPtr + 0xC0, Convert.ToByte(value)); }
		}

		public EntityMapFlagsB MapFlagsB {
			get { return (EntityMapFlagsB)Hook.RByte(CharMapDataPtr + 0xc6); }
			set { Hook.WByte(CharMapDataPtr + 0xc6, Convert.ToByte(value)); }
		}

		public int ControllerPtr {
			get { return Hook.RInt32(CharMapDataPtr + 0x54); }
			set { Hook.WInt32(CharMapDataPtr + 0x54, value); }
		}

		public EntityController Controller {
			get { return new EntityController(() => ControllerPtr); }
			set { ControllerPtr = value.Pointer; }
		}

		//TODO: CONTROLLER
		//Formatlike "ControllerMoveX", "ControllerR1Held", etc

		public int AnimationPtr {
			get { return Hook.RInt32(CharMapDataPtr + 0x14); }
			set { Hook.WInt32(CharMapDataPtr + 0x14, value); }
		}

		public int AnimationInstancePtr {
			get { return Hook.RInt32(Hook.RInt32(Hook.RInt32(AnimationPtr + 0xc) + 0x10)); }
			set { Hook.WInt32(Hook.RInt32(Hook.RInt32(AnimationPtr + 0xc) + 0x10), value); }
		}

		public float AnimInstanceTime {
			get { return Hook.RFloat(AnimationInstancePtr + 0x8); }
			set { Hook.WFloat(AnimationInstancePtr + 0x8, value); }
		}

		public float AnimInstanceSpeed {
			get { return Hook.RFloat(AnimationInstancePtr + 0x40); }
			set { Hook.WFloat(AnimationInstancePtr + 0x40, value); }
		}

		public float AnimInstanceLoopCount {
			get { return Hook.RFloat(AnimationInstancePtr + 0x44); }
			set { Hook.WFloat(AnimationInstancePtr + 0x44, value); }
		}

		public float AnimationSpeed {
			get { return Hook.RFloat(AnimationPtr + 0x64); }
			set { Hook.WFloat(AnimationPtr + 0x64, value); }
		}

		public bool AnimDbgDrawSkeleton {
			get { return Hook.RBool(AnimationPtr + 0x68); }
			set { Hook.WBool(AnimationPtr + 0x68, value); }
		}

		public bool AnimDbgDrawBoneName {
			get { return Hook.RBool(AnimationPtr + 0x69); }
			set { Hook.WBool(AnimationPtr + 0x69, value); }
		}

		public bool AnimDbgDrawExtractMotion {
			get { return Hook.RBool(AnimationPtr + 0x81); }
			set { Hook.WBool(AnimationPtr + 0x81, value); }
		}

		public bool AnimDbgSlotLog {
			get { return Hook.RBool(AnimationPtr + 0x82); }
			set { Hook.WBool(AnimationPtr + 0x82, value); }
		}

		public int LocationPtr {
			get { return Hook.RInt32(CharMapDataPtr + 0x1c); }
			set { Hook.WInt32(CharMapDataPtr + 0x1c, value); }
		}

        public bool WarpActivate
        {
            get { return Hook.RBool(CharMapDataPtr + 0xC8); }
            set { Hook.WBool(CharMapDataPtr + 0xC8, value); }
        }

        public float WarpX
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xD0); }
            set { Hook.WFloat(CharMapDataPtr + 0xD0, value); }
        }

        public float WarpY
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xD4); }
            set { Hook.WFloat(CharMapDataPtr + 0xD4, value); }
        }

        public float WarpZ
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xD8); }
            set { Hook.WFloat(CharMapDataPtr + 0xD8, value); }
        }

        //TODO: Confirm warp x and z rotation exist (I just guessed based on the pattern: [ pos x, pos y, pos y, {???}, rot y, {???} ]

        public float WarpRX
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xE0); }
            set { Hook.WFloat(CharMapDataPtr + 0xE0, value); }
        }

        public float WarpRY
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xE4); }
            set { Hook.WFloat(CharMapDataPtr + 0xE4, value); }
        }

        public float WarpRZ
        {
            get { return Hook.RFloat(CharMapDataPtr + 0xE8); }
            set { Hook.WFloat(CharMapDataPtr + 0xE8, value); }
        }

        public float WarpHeading
        {
            get { return (float)((Hook.RFloat(CharMapDataPtr + 0xE4) / Math.PI * 180) + 180); }
            set { Hook.WFloat(CharMapDataPtr + 0xE4, (float)(value * Math.PI / 180) - (float)Math.PI); }
        }



        #endregion

        //TODO: Move Stats to separate struct and remove "Stat" from the beginning of each member's name

        public int StatsPtr
        {
            get { return Hook.RInt32(Address + 0x414); }
            set { Hook.WInt32(Address + 0x414, value); }
        }

		public EntityDebugFlags DebugFlags {
			get { return (EntityDebugFlags)Hook.RInt32(Address + 0x3c4); }
			set { Hook.WInt32(Address + 0x3c4, (int)value); }
		}

		public bool GetDebugFlag(EntityDebugFlags flg)
		{
			return DebugFlags.HasFlag(flg);
		}

		public void SetDebugFlag(EntityDebugFlags flg, bool state)
		{
			if (state) {
				DebugFlags = DebugFlags | flg;
			} else {
				DebugFlags = DebugFlags & (~flg);
			}
		}

		public bool GetFlagA(EntityFlagsA flg)
		{
			return FlagsA.HasFlag(flg);
		}

		public void SetFlagA(EntityFlagsA flg, bool state)
		{
			if (state) {
				FlagsA = FlagsA | flg;
			} else {
				FlagsA = FlagsA & (~flg);
			}
		}

		#region "DebugFlags"
		public bool NoGoodsConsume {
			get { return GetDebugFlag(EntityDebugFlags.NoGoodsConsume); }
			set { SetDebugFlag(EntityDebugFlags.NoGoodsConsume, value); }
		}

		public bool DisableDrawingA {
			get { return GetDebugFlag(EntityDebugFlags.DisableDrawingA); }
			set { SetDebugFlag(EntityDebugFlags.DisableDrawingA, value); }
		}

		public bool DrawCounter {
			get { return GetDebugFlag(EntityDebugFlags.DrawCounter); }
			set { SetDebugFlag(EntityDebugFlags.DrawCounter, value); }
		}

		public bool DisableDrawingB {
			get { return GetDebugFlag(EntityDebugFlags.DisableDrawingB); }
			set { SetDebugFlag(EntityDebugFlags.DisableDrawingB, value); }
		}

		public bool DrawDirection {
			get { return GetDebugFlag(EntityDebugFlags.DrawDirection); }
			set { SetDebugFlag(EntityDebugFlags.DrawDirection, value); }
		}

		public bool NoUpdate {
			get { return GetDebugFlag(EntityDebugFlags.NoUpdate); }
			set { SetDebugFlag(EntityDebugFlags.NoUpdate, value); }
		}

		public bool NoAttack {
			get { return GetDebugFlag(EntityDebugFlags.NoAttack); }
			set { SetDebugFlag(EntityDebugFlags.NoAttack, value); }
		}

		public bool NoMove {
			get { return GetDebugFlag(EntityDebugFlags.NoMove); }
			set { SetDebugFlag(EntityDebugFlags.NoMove, value); }
		}

		public bool NoStamConsume {
			get { return GetDebugFlag(EntityDebugFlags.NoStamConsume); }
			set { SetDebugFlag(EntityDebugFlags.NoStamConsume, value); }
		}

		public bool NoMPConsume {
			get { return GetDebugFlag(EntityDebugFlags.NoMPConsume); }
			set { SetDebugFlag(EntityDebugFlags.NoMPConsume, value); }
		}

		public bool NoDead {
			get { return GetDebugFlag(EntityDebugFlags.NoDead); }
			set { SetDebugFlag(EntityDebugFlags.NoDead, value); }
		}

		public bool NoDamage {
			get { return GetDebugFlag(EntityDebugFlags.NoDamage); }
			set { SetDebugFlag(EntityDebugFlags.NoDamage, value); }
		}

		public bool DrawHit {
			get { return GetDebugFlag(EntityDebugFlags.DrawHit); }
			set { SetDebugFlag(EntityDebugFlags.DrawHit, value); }
		}
		#endregion

		#region "FlagsA"
		public bool DisableDamage {
			get { return GetFlagA(EntityFlagsA.DisableDamage); }
			set { SetFlagA(EntityFlagsA.DisableDamage, value); }
		}

		public bool EnableInvincible {
			get { return GetFlagA(EntityFlagsA.EnableInvincible); }
			set { SetFlagA(EntityFlagsA.EnableInvincible, value); }
		}

		public bool FirstPersonView {
			get { return GetFlagA(EntityFlagsA.FirstPersonView); }
			set { SetFlagA(EntityFlagsA.FirstPersonView, value); }
		}

		public bool SetDeadMode {
			get { return GetFlagA(EntityFlagsA.SetDeadMode); }
			set { SetFlagA(EntityFlagsA.SetDeadMode, value); }
		}

		public bool SetDisableGravity {
			get { return GetFlagA(EntityFlagsA.SetDisableGravity); }
			set { SetFlagA(EntityFlagsA.SetDisableGravity, value); }
		}

		public bool SetDrawEnable {
			get { return GetFlagA(EntityFlagsA.SetDrawEnable); }
			set { SetFlagA(EntityFlagsA.SetDrawEnable, value); }
		}

		public bool SetSuperArmor {
			get { return GetFlagA(EntityFlagsA.SetSuperArmor); }
			set { SetFlagA(EntityFlagsA.SetSuperArmor, value); }
		}
		#endregion

		public bool GetMapFlagA(EntityMapFlagsA flg)
		{
			return MapFlagsA.HasFlag(flg);
		}

		public void SetMapFlagA(EntityMapFlagsA flg, bool state)
		{
			if (state) {
				MapFlagsA = MapFlagsA | flg;
			} else {
				MapFlagsA = MapFlagsA & (~flg);
			}
		}

		public bool GetMapFlagB(EntityMapFlagsB flg)
		{
			return MapFlagsB.HasFlag(flg);
		}

		public void SetMapFlagB(EntityMapFlagsB flg, bool state)
		{
			if (state) {
				MapFlagsB = MapFlagsB | flg;
			} else {
				MapFlagsB = MapFlagsB & (~flg);
			}
		}

		#region "MapFlagsA and MapFlagsB"

		public bool EnableLogic {
			get { return GetMapFlagA(EntityMapFlagsA.EnableLogic); }
			set { SetMapFlagA(EntityMapFlagsA.EnableLogic, value); }
		}

		public bool DisableCollision {
			get { return GetMapFlagB(EntityMapFlagsB.DisableCollision); }
			set { SetMapFlagB(EntityMapFlagsB.DisableCollision, value); }
		}

		#endregion

		public void SetCamFollow()
		{
            Hook.WInt32(Hook.RInt32(0x137D648) + 0xEC, Address);
        }

        public void WarpToCoords(float x, float y, float z, float heading)
        {
            WarpX = x;
            WarpY = y;
            WarpZ = z;
            WarpHeading = heading;
            WarpActivate = true;
        }

        public void WarpToLocation(EntityLocation loc)
        {
            WarpToCoords(loc.X, loc.Y, loc.Z, loc.Heading);
        }

		public void WarpToEntity(Entity dest)
		{
            WarpToLocation(dest.Location);
		}

		public void WarpToEntityPtr(int dest)
		{
            WarpToEntity(new Entity(dest));
        }

		public void WarpToEventEntityID(int dest)
		{
            WarpToEntity(FromID(dest));
		}

        [Browsable(false)]
        public override void OverwriteWith(dynamic other)
        {
            throw new NotImplementedException();
        }
    }
}
