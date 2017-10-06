using static DarkSoulsScripting.Hook;

namespace DarkSoulsScripting
{
    public class Pointers
    {
        public static int PtrToPtrToCharDataPtr1 { get => RInt32(0x137DC70); }
        public static int PtrToCharDataPtr1 { get => RInt32(PtrToPtrToCharDataPtr1 + 0x4); }
        public static int CharDataPtr1 { get => RInt32(PtrToCharDataPtr1); }
        public static int GameStatsPtr { get => RInt32(0x1378700); }
        public static int CharDataPtr2 { get => RInt32(GameStatsPtr + 0x8); }
        public static int CharMapDataPtr { get => RInt32(CharDataPtr1 + 0x28); }
        public static int MenuPtr { get => RInt32(0x13786D0); }
        public static int LinePtr { get => RInt32(0x1378388); }
        public static int KeyPtr { get => RInt32(0x1378640); }
        public static int EntityControllerPtr { get => RInt32(CharMapDataPtr + 0x54); }
        public static int EntityAnimPtr { get => RInt32(CharMapDataPtr + 0x14); }
        public static int PtrToPtrToEntityAnimInstancePtr { get => RInt32(EntityAnimPtr + 0xC); }
        public static int PtrToEntityAnimInstancePtr { get => RInt32(PtrToPtrToEntityAnimInstancePtr + 0x10); }
        public static int EntityAnimInstancePtr { get => RInt32(PtrToEntityAnimInstancePtr); }
    }

}