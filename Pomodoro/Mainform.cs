using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            MainTimer.Start();
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = true;
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Visible = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            this.Visible = false;
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            _restTime = new TimeSpan(0, _workingTime, 0);
            _state = PomodoroState.Started;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            ShowTime();
        }

        #region Business Layer

        private DateTime _startTime;
        private PomodoroState _state = PomodoroState.Stopped;

        private int _workingTime = 20;
        private int _lazyTime = 10;
        private TimeSpan _restTime;

        private void ShowTime()
        {
            if (_state == PomodoroState.Started)
            {
                _restTime = _restTime.Subtract(new TimeSpan(0, 0, 1));
                lblTime.Text = _restTime.Minutes.ToString("00") + 
                    ":" + _restTime.Seconds.ToString("00");
            }
        }

        #endregion

    }

    public enum PomodoroState
    {
        Stopped,
        Started,
        Paused
    }
}
