using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class PomodoroOptions
    {
        public int WorkingTime { get; private set; }
        public int RestTime { get; private set; }

        public PomodoroOptions(int workingTime, int restTime)
        {
            WorkingTime = workingTime;
            RestTime = restTime;
        }
    }
}
