using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Pomodoro
{
    public static class AppConfiguration
    {
        private const string INI_FILE_NAME = "settings.ini";
        private const int DEFAULT_WORKING_TIME = 20;
        private const int DEFAULT_LAZY_TIME = 10;
        private const bool DEFAULT_SHOW_DESCRIPTION = false;


        private static IniConfig _config;
        private static IniConfig Config
        {
            get
            {
                return _config ?? (_config = 
                    File.Exists(INI_FILE_NAME) ? new IniConfig(INI_FILE_NAME) : new IniConfig());
            }
        }

        public static int WorkingTime
        {
            get
            {
                var configValue = Config["WorkingTime"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_WORKING_TIME : int.Parse(configValue);
            }
        }

        public static int LazyTime
        {
            get
            {
                var configValue = Config["LazyTime"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_LAZY_TIME : int.Parse(configValue);
            }
        }

        public static bool ShowDescriptionTextBox
        {
            get
            {
                var configValue = Config["ShowDescriptionTextBox"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_SHOW_DESCRIPTION : (configValue == "true");
            }
        }
    }
}
