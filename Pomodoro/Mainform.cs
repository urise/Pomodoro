using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Pomodoro
{
    public partial class Mainform : Form
    {
        private PomodoroOptions Options { get; set; }
        private PomodoroDispatcher Dispatcher { get; set; }
        public Mainform()
        {
            InitializeComponent();
            Options = new PomodoroOptions(20, 10);
            Dispatcher = new PomodoroDispatcher(Options);
            Dispatcher.OnTimeTextChanged += ShowTime;
            Dispatcher.OnRestStarted += RestStarted;
            Dispatcher.OnRestEnded += RestEnded;
            MainTimer.Start();
        }

        private void ShowForm()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void HideToTray()
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            this.Visible = false;
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowForm();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    HideToTray();
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            HideToTray();
        }

        private void btnStartWork_Click(object sender, EventArgs e)
        {
            Tray.Text = txtDescription.Text;
            Dispatcher.Start();
            lblTime.ForeColor = Color.DarkRed;
            HideToTray();
        }
        private void btnStopWork_Click(object sender, EventArgs e)
        {
            Dispatcher.Stop();
            lblTime.Text = "--:--";
            lblTime.ForeColor = Color.DarkOrange;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Dispatcher.TickOneSecond();
        }

        #region Business Layer

        private void ShowTime(object sender, EventArgs e)
        {
            lblTime.Text = Dispatcher.TimeText;
            Tray.Text = Dispatcher.TimeText + " " + txtDescription.Text;
        }

        private void RestStarted(object sender, EventArgs e)
        {
            lblTime.ForeColor = Color.DarkGreen;
            ShowForm();
        }

        private void RestEnded(object sender, EventArgs e)
        {
            lblTime.Text = "--:--";
            lblTime.ForeColor = Color.DarkOrange;
            ShowForm();
        }

        #endregion

    }

    
}
