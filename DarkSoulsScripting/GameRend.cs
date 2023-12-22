using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static class GameRend
    {
        //DSR1310
        //HgManImp = 0x141b68ec8
        public static IntPtr Address => RIntPtr(RIntPtr(0x141b68ec8) + 0x738);

        public static bool DisplayBoundingBoxes
        {
            get => RBool(Address + 0x31d);
            set => WBool(Address + 0x31d, value);
        }
        public static bool EnableFreeCam
        {
            get => RBool(Address + 0x328);
            set => WBool(Address + 0x328, value);
        }

        public static bool DisplayWaterHeightMap
        {
            get => RBool(Address + 0x3d5);
            set => WBool(Address + 0x3d5, value);
        }
        public static bool DisplayReflectTex
        {
            get => RBool(Address + 0x3d6);
            set => WBool(Address + 0x3d6, value);
        }
        public static bool DisplayVelocityMap
        {
            get => RBool(Address + 0x3d7);
            set => WBool(Address + 0x3d7, value);
        }



        public static float VelocityMapWidth
        {
            get => RFloat(0x141307d10);
            set => WFloat(0x141307d10, value);
        }
        public static float VelocityMapHeight
        {
            get => RFloat(0x14130E5A4);
            set => WFloat(0x14130E5A4, value);
        }
        public static float WaterHeightMapXPos
        {
            get => RFloat(0x14130e650);
            set => WFloat(0x14130e650, value);
        }
        public static float WaterHeightMapYPos
        {
            get => RFloat(0x14130e654);
            set => WFloat(0x14130e654, value);
        }
        public static float VelocityMapXPos
        {
            get => RFloat(0x14130e660);
            set => WFloat(0x14130e660, value);
        }
        public static float VelocityMapYPos
        {
            get => RFloat(0x14130e664);
            set => WFloat(0x14130e664, value);
        }
    }
}
