﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Pomodoro
{
    public partial class Mainform : Form
    {
        private PomodoroDispatcher Dispatcher { get; set; }

        public Mainform()
        {
            InitializeComponent();
            
            Dispatcher = new PomodoroDispatcher();
            Dispatcher.OnTimeTextChanged += ShowTime;
            Dispatcher.OnRestStarted += RestStarted;
            Dispatcher.OnRestEnded += RestEnded;
            Dispatcher.OnStateChanged += StateChanged;
            MainTimer.Start();
            ShowState();
            SetElements();
            SetDefaultTime();
            txtDescription.Visible = AppConfiguration.ShowDescriptionTextBox;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
        }
        private void btnStopWork_Click(object sender, EventArgs e)
        {
            Dispatcher.Stop();
            SetDefaultTime();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            Dispatcher.TickOneSecond();
        }

        private void StateChanged(object sender, EventArgs e)
        {
            ShowState();
            txtDescription.Enabled = Dispatcher.State == PomodoroState.RestStarted ||
                                     Dispatcher.State == PomodoroState.Stopped;
            PlaySound();
        }

        private string GetImageFileName(string extension)
        {
            switch (Dispatcher.State)
            {
                case PomodoroState.WorkStarted:
                    return @"img\tomato-red." + extension;
                case PomodoroState.RestStarted:
                    return @"img\tomato-green." + extension;
                default:
                    return @"img\tomato-orange." + extension;
            }
        }

        private void ShowState()
        {
            pctPomodoro.ImageLocation = GetImageFileName("png");
            Tray.Icon = new Icon(GetImageFileName("ico"));
        }

        private void SetElements()
        {
            txtDescription.Visible = AppConfiguration.ShowDescriptionTextBox;
        }

        private string GetSoundFileName()
        {
            switch (Dispatcher.State)
            {
                case PomodoroState.WorkStarted:
                    return "StartWork.wav";
                case PomodoroState.RestStarted:
                    return "StartRest.wav";
                case PomodoroState.Stopped:
                    return "Stop.wav";
            }
            return string.Empty;
        }
        private void PlaySound()
        {
            if (!AppConfiguration.PlaySound) return;
            var soundFileName = @"sounds\" + GetSoundFileName();
            if (!File.Exists(soundFileName))
                soundFileName = @"sounds\Default" + GetSoundFileName();
            if (!File.Exists(soundFileName)) return;
            var player = new System.Media.SoundPlayer(soundFileName);
            player.Play();
        }

        private void ShowTime(object sender, EventArgs e)
        {
            var timeText = Dispatcher.TimeText;
            SetTime(timeText);
            Tray.Text = timeText + " " + txtDescription.Text;
        }

        private void RestStarted(object sender, EventArgs e)
        {
            if (AppConfiguration.ShowWindow) 
                ShowForm();
        }

        private void RestEnded(object sender, EventArgs e)
        {
            if (AppConfiguration.ShowWindow)
                ShowForm();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            Dispatcher.Rest();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Dispatcher.Stop();
            SetDefaultTime();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            switch (Dispatcher.State)
            {
                case PomodoroState.WorkStarted:
                    Dispatcher.Pause();
                    btnPause.Text = "Продолжить";
                    pauseToolStripMenuItem.Text = btnPause.Text;
                    break;
                case PomodoroState.Paused:
                    Dispatcher.Continue();
                    btnPause.Text = "Пауза";
                    pauseToolStripMenuItem.Text = btnPause.Text;
                    break;
            }
        }

        public void SetTime(string timeText)
        {
            var parts = timeText.Split(':');
            lblMinutes.Text = parts[0];
            lblSeconds.Text = parts[1];
        }

        private void SetTime(int minutes, int seconds = 0)
        {
            lblMinutes.Text = minutes.ToString("00");
            lblSeconds.Text = seconds.ToString("00");
        }

        private void SetDefaultTime()
        {
            SetTime(AppConfiguration.WorkingTime);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var settings = new Settings();
            settings.ShowDialog();
            SetElements();
        }
    }
}
