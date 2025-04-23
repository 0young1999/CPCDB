using CPCDBot.HIDE.SettingControl;

namespace CPCDBot
{
	public class CsProgramOption : CsAutoProperty
	{
        private static CsProgramOption? instance;
        public static CsProgramOption GetInstance()
        {
            return instance ??= new CsProgramOption();
        }
        private CsProgramOption() : base("") { }


    }
}
