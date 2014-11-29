using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PomodoroDispatcher
    {
        private PomodoroState _state = PomodoroState.Stopped;

        private DateTime _startTime;

        private int _cyclesCount;

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

        private int GetSeconds(int minutes)
        {
            return minutes;
        }

        public string TimeText
        {
            get { return (SecondsTillEnd/60).ToString("00") + ":" + (SecondsTillEnd%60).ToString("00"); }
        }

        public void TickOneSecond()
        {
            switch (State)
            {
                case PomodoroState.WorkStarted:
                    if (--SecondsTillEnd <= 0)
                    {
                        SecondsTillEnd = GetSeconds(AppConfiguration.LazyTime);
                        State = PomodoroState.RestStarted;
                        OnRestStarted(this, new EventArgs());
                    }
                    OnTimeTextChanged(this, new EventArgs());
                    break;
                case PomodoroState.RestStarted:
                    if (--SecondsTillEnd <= 0)
                    {
                        CycleEnd();
                        OnRestEnded(this, new EventArgs());
                    }
                    OnTimeTextChanged(this, new EventArgs());
                    break;
            }
        }

        public void Start()
        {
            _cyclesCount = 0;
            _startTime = DateTime.Now;
            StartNextCycle();
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
            SecondsTillEnd = GetSeconds(AppConfiguration.LazyTime);
        }

        private void StartNextCycle()
        {
            _cyclesCount++;
            State = PomodoroState.WorkStarted;
            SecondsTillEnd = GetSeconds(AppConfiguration.WorkingTime);
        }

        private void CycleEnd()
        {
            switch (AppConfiguration.CycleSetting)
            {
                case CycleSettingEnum.NoCycle:
                    State = PomodoroState.Stopped;
                    break;
                case CycleSettingEnum.EndlessCycle:
                    StartNextCycle();
                    break;
                case CycleSettingEnum.CyclesByCount:
                    if (_cyclesCount >= AppConfiguration.CycleCount)
                        State = PomodoroState.Stopped;
                    else
                        StartNextCycle();
                    break;
                case CycleSettingEnum.CyclesByDuration:
                    if ((DateTime.Now - _startTime).TotalMinutes >= AppConfiguration.CycleDuration)
                        State = PomodoroState.Stopped;
                    else
                        StartNextCycle();
                    break;
                case CycleSettingEnum.CyclesUntilTime:
                    if (DateTime.Now >= AppConfiguration.CycleEndTime)
                        State = PomodoroState.Stopped;
                    else
                        StartNextCycle();
                    break;
            }
        }
    }
}
