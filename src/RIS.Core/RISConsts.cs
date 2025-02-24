using RIS.Debugging;

namespace RIS
{
    public class RISConsts
    {
        public const string LocalizationSourceName = "RIS";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "77b11588ce3f43c08e1a47c107d611e7";
    }
}
