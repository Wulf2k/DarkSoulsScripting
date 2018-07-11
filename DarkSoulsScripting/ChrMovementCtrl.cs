using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class ChrMovementCtrl<TChrController> : GameStruct
        where TChrController : ChrController, new()
    {
        public ChrTransform Transform { get; private set; } = null;
        public TChrController Controller { get; private set; } = null;
        public PlayerController DebugPlayerController { get; private set; } = null;

        protected override void InitSubStructures()
        {
            Transform = new ChrTransform() { AddressReadFunc = () => TransformPtr };
            Controller = new TChrController() { AddressReadFunc = () => ControllerPtr };
            DebugPlayerController = new PlayerController() { AddressReadFunc = () => DebugPlayerControllerPtr };
        }

        public Player GetChrAsPlayer() => new Player() { AddressReadFunc = () => ChrPtr };
        public Enemy GetChrAsEnemy() => new Enemy() { AddressReadFunc = () => ChrPtr };

        public IntPtr ChrPtr
        {
            //DSR
            get { return RIntPtr((Address + 0x10, IntPtr.Zero, Address + 0x10)); }
            set { WIntPtr((Address + 0x10, IntPtr.Zero, Address + 0x10), value); }
        }

        public IntPtr ControllerPtr
        {
            //DSR
            get { return RIntPtr((Address + 0x54, IntPtr.Zero, Address + 0x88)); }
            set { WIntPtr((Address + 0x54, IntPtr.Zero, Address + 0x88), value); }
        }

        public bool EnableLogic
        {
            //DSR
            get { return RBit((Address + 0xC0, IntPtr.Zero, Address + 0x100), 7); }
            set { WBit((Address + 0xC0, IntPtr.Zero, Address + 0x100), 7, value); }
        }

        public bool DisableMapHit
        {
            //DSR
            get { return RBit((Address + 0xC4, IntPtr.Zero, Address + 0x104), 27); }
            set { WBit((Address + 0xC4, IntPtr.Zero, Address + 0x104), 27, value); }
        }

        //0x40 flag applied to Address + 0xC6
        //public bool DisableCollision
        //{
        //    get { return GetMapFlagB(ChrMapFlagsB.DisableCollision); }
        //    set { SetMapFlagB(ChrMapFlagsB.DisableCollision, value); }
        //}


        public IntPtr AnimationPtr
        {
            //DSR
            get { return RIntPtr((Address + 0x14, IntPtr.Zero, Address + 0x18)); }
            set { WIntPtr((Address + 0x14, IntPtr.Zero, Address + 0x18), value); }
        }

        public List<ChrAnimInstance> GetAnimInstances()
        {
            //DSR
            IntPtr animStructThing = RIntPtr((AnimationPtr + 0xC, IntPtr.Zero, AnimationPtr + 0x18));
            IntPtr startAddr = RIntPtr((AnimationPtr + 0x10, IntPtr.Zero, AnimationPtr + 0x20));
            int entryCount = RInt32((AnimationPtr + 0x14, IntPtr.Zero, AnimationPtr + 0x28));

            var result = new List<ChrAnimInstance>();

            for (int i = 0; i < entryCount; i++)
            {
                IntPtr entryAddr = RIntPtr(startAddr + (i * IntPtr.Size));
                result.Add(new ChrAnimInstance() { AddressReadFunc = () => entryAddr });
            }

            return result;
        }

        public float AnimationSpeed
        {
            //DSR
            get { return RFloat((AnimationPtr + 0x64, IntPtr.Zero, AnimationPtr + 0xA8)); }
            set { WFloat((AnimationPtr + 0x64, IntPtr.Zero, AnimationPtr + 0xA8), value); }
        }

        public bool AnimDbgDrawSkeleton
        {
            //DSR
            get { return RBool((AnimationPtr + 0x68, IntPtr.Zero, AnimationPtr + 0xB0)); }
            set { WBool((AnimationPtr + 0x68, IntPtr.Zero, AnimationPtr + 0xB0), value); }
        }

        public bool AnimDbgDrawBoneName
        {
            //DSR
            get { return RBool((AnimationPtr + 0x69, IntPtr.Zero, AnimationPtr + 0xB1)); }
            set { WBool((AnimationPtr + 0x69, IntPtr.Zero, AnimationPtr + 0xB1), value); }
        }

        public bool AnimDbgDrawExtractMotion
        {
            get { return RBool(AnimationPtr + 0x81); }
            set { WBool(AnimationPtr + 0x81, value); }
        }

        public bool AnimDbgSlotLog
        {
            get { return RBool(AnimationPtr + 0x82); }
            set { WBool(AnimationPtr + 0x82, value); }
        }

        public IntPtr TransformPtr
        {
            //DSR
            get { return RIntPtr((Address + 0x1c, IntPtr.Zero, Address + 0x28)); }
            set { WIntPtr((Address + 0x1c, IntPtr.Zero, Address + 0x28), value); }
        }

        public bool WarpActivate
        {
            //DSR
            get { return RBool((Address + 0xC8, IntPtr.Zero, Address + 0x108)); }
            set { WBool((Address + 0xC8, IntPtr.Zero, Address + 0x108), value); }
        }

        public float WarpX
        {
            //DSR
            get { return RFloat((Address + 0xD0, IntPtr.Zero, Address + 0x110)); }
            set { WFloat((Address + 0xD0, IntPtr.Zero, Address + 0x110), value); }
        }

        public float WarpY
        {
            //DSR
            get { return RFloat((Address + 0xD4, IntPtr.Zero, Address + 0x114)); }
            set { WFloat((Address + 0xD4, IntPtr.Zero, Address + 0x114), value); }
        }

        public float WarpZ
        {
            //DSR
            get { return RFloat((Address + 0xD8, IntPtr.Zero, Address + 0x118)); }
            set { WFloat((Address + 0xD8, IntPtr.Zero, Address + 0x118), value); }
        }

        //TODO: Confirm warp x and z rotation exist (I just guessed based on the pattern: [ pos x, pos y, pos y, {???}, rot y, {???} ]

        public float WarpRX
        {
            //DSR
            get { return RFloat((Address + 0xE0, IntPtr.Zero, Address + 0x120)); }
            set { WFloat((Address + 0xE0, IntPtr.Zero, Address + 0x120), value); }
        }

        public float WarpRY
        {
            //DSR
            get { return RFloat((Address + 0xE4, IntPtr.Zero, Address + 0x124)); }
            set { WFloat((Address + 0xE4, IntPtr.Zero, Address + 0x124), value); }
        }

        public float WarpRZ
        {
            //DSR
            get { return RFloat((Address + 0xE8, IntPtr.Zero, Address + 0x128)); }
            set { WFloat((Address + 0xE8, IntPtr.Zero, Address + 0x128), value); }
        }

        public float WarpHeading
        {
            //DSR
            get { return (float)((RFloat((Address + 0xE4, IntPtr.Zero, Address + 0x124)) / Math.PI * 180) + 180); }
            set { WFloat((Address + 0xE4, IntPtr.Zero, Address + 0x124), (float)(value * Math.PI / 180) - (float)Math.PI); }
        }

        public IntPtr DebugPlayerControllerPtr {
            //DSR
			get { return Hook.RIntPtr(Address + 0x298); }
			set { Hook.WIntPtr(Address + 0x298, value); }
		}
    }
}
