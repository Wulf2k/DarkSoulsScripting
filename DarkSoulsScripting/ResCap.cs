using static DarkSoulsScripting.Hook;


namespace DarkSoulsScripting
{
    public class ResCap : GameStruct
    {
        protected override void InitSubStructures()
        {

        }

        public string ResName
        {
            get => RUnicodeStr(RIntPtr(Address + 0x8));
            set => WUnicodeStr(RIntPtr(Address + 0x8), value);
        }
    }
}
