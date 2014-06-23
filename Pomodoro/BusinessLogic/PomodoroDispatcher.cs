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

        private PomodoroState _state = PomodoroState.Stopped;

        public PomodoroState State
        {
            get { return _state; }
            private set
            {
                _state = value;
                OnStateChanged(this, new EventArgs());
            }
        }
        private int SecondsTillEnd { get; set; }

        public EventHandler OnTimeTextChanged;

        public EventHandler OnRestStarted;

        public EventHandler OnRestEnded;

        public EventHandler OnStateChanged;

        private const int SecondsInMinute = 60;

        public string TimeText
        {
            get { return (SecondsTillEnd/60).ToString("00") + ":" + (SecondsTillEnd%60).ToString("00"); }
        }

        public PomodoroDispatcher(PomodoroOptions options)
        {
            Options = options;
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

        public void Continue()
        {
            State = PomodoroState.WorkStarted;
        }

        public void Stop()
        {
            State = PomodoroState.Stopped;
        }

        public void Rest()
        {
            State = PomodoroState.RestStarted;
            SecondsTillEnd = Options.RestTime*SecondsInMinute;
        }
    }
}
