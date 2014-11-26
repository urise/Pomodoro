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
    public enum CycleSettingEnum
    {
        NoCycle,
        EndlessCycle,
        CyclesByCount,
        CyclesByDuration,
        CyclesUntilTime
    }
    public static class AppConfiguration
    {
        private const string INI_FILE_NAME = "settings.ini";
        private const int DEFAULT_WORKING_TIME = 20;
        private const int DEFAULT_LAZY_TIME = 10;
        private const bool DEFAULT_SHOW_DESCRIPTION = false;
        private const CycleSettingEnum DEFAULT_CYCLE_SETTING = CycleSettingEnum.NoCycle;


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
            set { Config["WorkingTime"] = value.ToString(); }
        }

        public static int LazyTime
        {
            get
            {
                var configValue = Config["LazyTime"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_LAZY_TIME : int.Parse(configValue);
            }
            set { Config["LazyTime"] = value.ToString(); }
        }

        public static bool ShowDescriptionTextBox
        {
            get
            {
                var configValue = Config["ShowDescriptionTextBox"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_SHOW_DESCRIPTION : (configValue == "true");
            }
            set { Config["ShowDescriptionTextBox"] = value.ToString(); }
        }

        public static CycleSettingEnum CycleSetting
        {
            get
            {
                var configValue = Config["Cycling"];
                if (string.IsNullOrEmpty(configValue)) return DEFAULT_CYCLE_SETTING;
                CycleSettingEnum cycleSetting;
                return Enum.TryParse(configValue, out cycleSetting) ? cycleSetting : DEFAULT_CYCLE_SETTING;
            }
            set { Config["Cycling"] = value.ToString(); }
        }

        public static void Save()
        {
            Config.Save(INI_FILE_NAME);
        }
    }
}
