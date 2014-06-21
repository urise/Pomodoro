using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PomodoroDispatcher
    {
        private PomodoroOptions Options { get; set; }

        public PomodoroState State { get; private set; }
        private int SecondsTillEnd { get; set; }

        public EventHandler OnTimeTextChanged;

        public EventHandler OnRestStarted;

        public EventHandler OnRestEnded;

        private const int SecondsInMinute = 60;

        public string TimeText
        {
            get { return (SecondsTillEnd/60).ToString("00") + ":" + (SecondsTillEnd%60).ToString("00"); }
        }

        public PomodoroDispatcher(PomodoroOptions options)
        {
            Options = options;
            State = PomodoroState.Stopped;
        }

        public void TickOneSecond()
        {
            switch (State)
            {
                case PomodoroState.WorkStarted:
                    if (--SecondsTillEnd <= 0)
                    {
                        SecondsTillEnd = Options.RestTime*SecondsInMinute;
                        State = PomodoroState.RestStarted;
                        OnRestStarted(this, new EventArgs());
                    }
                    OnTimeTextChanged(this, new EventArgs());
                    break;
                case PomodoroState.RestStarted:
                    if (--SecondsTillEnd <= 0)
                    {
                        State = PomodoroState.Stopped;
                        OnRestEnded(this, new EventArgs());
                    }
                    OnTimeTextChanged(this, new EventArgs());
                    break;
            }
        }

        public void Start()
        {
            SecondsTillEnd = Options.WorkingTime*SecondsInMinute;
            State = PomodoroState.WorkStarted;
        }

        public void Pause()
        {
            State = PomodoroState.Paused;
        }

        public void Stop()
        {
            State = PomodoroState.Stopped;
        }
    }
}
