using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public static class AppConfiguration
    {
        public static int WorkingTime
        {
            get { return int.Parse(ConfigurationManager.AppSettings["WorkingTime"]); }
        }

        public static int LazyTime
        {
            get { return int.Parse(ConfigurationManager.AppSettings["LazyTime"]); }
        }
    }
}
