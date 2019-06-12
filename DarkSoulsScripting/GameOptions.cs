using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{

    //All values updated to 1.03


    public enum BloodLevel : byte
    {
        Off = 0,
        Normal = 1,
        Mild = 2
    }

    public class GameOptions : GameStruct
    {
        protected override void InitSubStructures()
        {
            
        }

        public byte CameraSpeedX
        {
            get { return RByte(Address + 0x8); }
            set { WByte(Address + 0x8, value); }
        }

        public byte Vibration
        {
            get { return RByte(Address + 0x9); }
            set { WByte(Address + 0x9, value); }
        }

        public byte Brightness
        {
            get { return RByte(Address + 0xA); }
            set { WByte(Address + 0xA, value); }
        }

        public byte SoundType
        {
            get { return RByte(Address + 0xB); }
            set { WByte(Address + 0xB, value); }
        }

        public byte VolumeBGM
        {
            get { return RByte(Address + 0xC); }
            set { WByte(Address + 0xC, value); }
        }

        public byte VolumeSFX
        {
            get { return RByte(Address + 0xD); }
            set { WByte(Address + 0xD, value); }
        }

        public byte VolumeVoice
        {
            get { return RByte(Address + 0xE); }
            set { WByte(Address + 0xE, value); }
        }

        public BloodLevel Blood
        {
            get { return (BloodLevel)RByte(Address + 0xF); }
            set { WByte(Address + 0xF, (byte)value); }
        }

        public bool Subtitles
        {
            get { return RBool(Address + 0x10); }
            set { WBool(Address + 0x10, value); }
        }

        public bool HUD
        {
            get { return RBool(Address + 0x11); }
            set { WBool(Address + 0x11, value); }
        }

        public byte UIScale
        {
            get { return RByte(Address + 0x12); }
            set { WByte(Address + 0x12, value); }
        }

        public bool CameraReverseX
        {
            get { return RBool(Address + 0x13); }
            set { WBool(Address + 0x13, value); }
        }

        public bool CameraReverseY
        {
            get { return RBool(Address + 0x14); }
            set { WBool(Address + 0xF, value); }
        }

        public bool AutoLockOn
        {
            get { return RBool(Address + 0x15); }
            set { WBool(Address + 0x15, value); }
        }

        public bool CameraAutoWallRecovery
        {
            get { return RBool(Address + 0x16); }
            set { WBool(Address + 0x16, value); }
        }

        public bool JoinLeaderboard
        {
            get { return RBool(Address + 0x17); }
            set { WBool(Address + 0x17, value); }
        }

        public byte DebugRankRegisterProfileIdx
        {
            get { return RByte(Address + 0x18); }
            set { WByte(Address + 0x18, value); }
        }

        public byte CameraSpeedY
        {
            get { return RByte(Address + 0x58); }
            set { WByte(Address + 0x58, value); }
        }

    }
}
