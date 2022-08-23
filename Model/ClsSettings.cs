/// Create by Skak2000
using System.Configuration;

namespace Model
{
    public static class ClsSettings
    {
        static ClsSettings()
        {
            ShowNumberOfErrors = int.Parse(ConfigurationManager.AppSettings.Get("ShowNumberOfErrors"));

        }

        public static int ShowNumberOfErrors { get; set; }
    }
}
