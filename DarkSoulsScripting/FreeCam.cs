using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class FreeCam
    {
        //DSR1310
        //RemoManStep
        public static IntPtr Address => RIntPtr(RIntPtr(RIntPtr((0x141c71970)) + 0x28) + 0x330);
        public static IntPtr EnableAddress => RIntPtr(RIntPtr((0x141c71970)) + 0x28);


        public static bool Enabled
        {
            get => RBool(EnableAddress + 0x328);
            set => WBool(EnableAddress + 0x328, value);
        }

        public static float DrawDistance
        {
            get => RFloat(Address + 0x5C);
            set => WFloat(Address + 0x5C, value);
        }

        public static float RotX
        {
            get => RFloat(Address + 0x30);
            set => WFloat(Address + 0x30, value);
        }

        public static float RotY
        {
            get => RFloat(Address + 0x34);
            set => WFloat(Address + 0x34, value);
        }

        public static float RotZ
        {
            get => RFloat(Address + 0x38);
            set => WFloat(Address + 0x38, value);
        }

        public static float PosX
        {
            get => RFloat(Address + 0x40);
            set => WFloat(Address + 0x40, value);
        }

        public static float PosY
        {
            get => RFloat(Address + 0x44);
            set => WFloat(Address + 0x44, value);
        }

        public static float PosZ
        {
            get => RFloat(Address + 0x48);
            set => WFloat(Address + 0x48, value);
        }

        public static float CamRotX
        {
            get => RFloat(Address + 0x140);
            set => WFloat(Address + 0x140, value);
        }

        //TODO: CONFIRM
        public static float CamRotY
        {
            get => RFloat(Address + 0x144);
            set => WFloat(Address + 0x144, value);
        }

        //TODO: CONFIRM
        public static float CamRotZ
        {
            get => RFloat(Address + 0x148);
            set => WFloat(Address + 0x148, value);
        }

        public static float TargetRotX
        {
            get => RFloat(Address + 0x150);
            set => WFloat(Address + 0x150, value);
        }

        //TODO: CONFIRM
        public static float TargetRotY
        {
            get => RFloat(Address + 0x154);
            set => WFloat(Address + 0x154, value);
        }

        //TODO: CONFIRM
        public static float TargetRotZ
        {
            get => RFloat(Address + 0x158);
            set => WFloat(Address + 0x158, value);
        }

        /*
        +0x0204	float	X RotSpeedMin
        +0x0208	float	Y RotSpeedMin
        +0x020C	float	X RotSpeedMax
        +0x0210	float	Y RotSpeedMax
        +0x021C	float	X RotHiSpeedMin
        +0x0220	float	Y RotHiSpeedMin
        +0x0224	float	X RotHiSpeedMax
        +0x0228	float	Y RotHiSpeedMax

         */
    }
}
