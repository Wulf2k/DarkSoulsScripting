using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public static partial class Functions
    {

        public static bool ActionEnd(int ChrID) 
            => Call<bool>(0x00D616D0, ChrID);

        public static bool AddActionCount(int ChrID, int b) 
            => Call<bool>(0x00D5FC20, ChrID, b);

        public static int AddBlockClearBonus() 
            => Call<int>(0x00D5E480);

        public static int AddClearCount() 
            => Call<int>(0x00D5EC20);

        public static int AddCorpseEvent(int a, int b) 
            => Call<int>(0x00D60930, a, b);

        public static int AddCustomRoutePoint(int ChrID, int b) 
            => Call<int>(0x00D645C0, ChrID, b);

        public static int AddDeathCount() 
            => Call<int>(0x00D5DE20);

        public static int AddEventGoal(int a, int b, float c, float d, float e, float f, float g, float h, float i, float j, float k)
            => Call<int>(0x00D66000, a, b, c, d, e, f, g, h, i, j, k);

        public static bool AddEventSimpleTalk(int a, int b) 
            => Call<bool>(0x00D62860, a, b);

        public static bool AddEventSimpleTalkTimer(int a, int b)
            => Call<bool>(0x00D62860, a, b);






        public static int ChrFadeIn(int ChrID, float Duration, float Opacity)
            => Call<int>(0x00D607E0, ChrID, Duration, Opacity);
    }
}
