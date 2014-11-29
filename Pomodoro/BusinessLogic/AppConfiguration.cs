using System;
using System.IO;

namespace BusinessLogic
{
    public enum CycleSettingEnum
    {
        NoCycle,
        EndlessCycle,
        CyclesByCount,
        CyclesByDuration,
        CyclesUntilTime
    }
    public enum PomodoroState
    {
        Stopped,
        WorkStarted,
        RestStarted,
        Paused
    }
    public static class AppConfiguration
    {
        private const string INI_FILE_NAME = "settings.ini";
        private const int DEFAULT_WORKING_TIME = 20;
        private const int DEFAULT_LAZY_TIME = 10;
        private const bool DEFAULT_SHOW_DESCRIPTION = false;
        private const CycleSettingEnum DEFAULT_CYCLE_SETTING = CycleSettingEnum.NoCycle;
        private const int DEFAULT_CYCLE_COUNT = 5;
        private const int DEFAULT_CYCLE_DURATION = 90;
        private const bool DEFAULT_PLAY_SOUND = true;
        private const bool DEFAULT_SHOW_WINDOW = true;

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
                return string.IsNullOrEmpty(configValue) ? DEFAULT_SHOW_DESCRIPTION : (configValue.ToLower() == "true");
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

        public static int CycleCount
        {
            get
            {
                var configValue = Config["CycleCount"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_CYCLE_COUNT : int.Parse(configValue);
            }
            set { Config["CycleCount"] = value.ToString(); }
        }

        public static int CycleDuration
        {
            get
            {
                var configValue = Config["CycleDuration"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_CYCLE_DURATION : int.Parse(configValue);
            }
            set { Config["CycleDuration"] = value.ToString(); }
        }

        public static DateTime CycleEndTime { get; set; }

        public static void Save()
        {
            Config.Save(INI_FILE_NAME);
        }
        public static bool PlaySound
        {
            get
            {
                var configValue = Config["PlaySound"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_PLAY_SOUND : (configValue.ToLower() == "true");
            }
            set { Config["PlaySound"] = value.ToString(); }
        }
        public static bool ShowWindow
        {
            get
            {
                var configValue = Config["ShowWindow"];
                return string.IsNullOrEmpty(configValue) ? DEFAULT_SHOW_WINDOW : (configValue.ToLower() == "true");
            }
            set { Config["ShowWindow"] = value.ToString(); }
        }
    }
}
