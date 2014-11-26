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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            trackWorkingTime.Value = AppConfiguration.WorkingTime;
            trackLazyTime.Value = AppConfiguration.LazyTime;
            SetEnables();
            SetCycleRadioButtons();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppConfiguration.WorkingTime = trackWorkingTime.Value;
            AppConfiguration.LazyTime = trackLazyTime.Value;
            AppConfiguration.CycleSetting = GetCycleSetting();
            AppConfiguration.Save();
            Close();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }

        private void trackWorkingTime_ValueChanged(object sender, EventArgs e)
        {
            lblWorkingTime.Text = trackWorkingTime.Value + " минут";
        }

        private void trackLazyTime_ValueChanged(object sender, EventArgs e)
        {
            lblLazyTime.Text = trackLazyTime.Value + " минут";
        }

        private void SetEnables()
        {
            txtCycleCount.Enabled = rbCyclesByCount.Checked;
            txtCycleDuration.Enabled = rbCyclesByDuration.Checked;
            dtCycleEndTime.Enabled = rbCycleUntilTime.Checked;
        }

        private void SetCycleRadioButtons()
        {
            switch (AppConfiguration.CycleSetting)
            {
                case CycleSettingEnum.NoCycle:
                    rbNoCycle.Checked = true;
                    break;
                case CycleSettingEnum.EndlessCycle:
                    rbEndlessCycle.Checked = true;
                    break;
                case CycleSettingEnum.CyclesByCount:
                    rbCyclesByCount.Checked = true;
                    break;
                case CycleSettingEnum.CyclesByDuration:
                    rbCyclesByDuration.Checked = true;
                    break;
                case CycleSettingEnum.CyclesUntilTime:
                    rbCycleUntilTime.Checked = true;
                    break;
            }
        }

        private CycleSettingEnum GetCycleSetting()
        {
            return rbNoCycle.Checked
                ? CycleSettingEnum.NoCycle
                : rbEndlessCycle.Checked
                    ? CycleSettingEnum.EndlessCycle
                    : rbCyclesByCount.Checked
                        ? CycleSettingEnum.CyclesByCount
                        : rbCyclesByDuration.Checked
                            ? CycleSettingEnum.CyclesByDuration
                            : CycleSettingEnum.CyclesUntilTime;
        }

        private void rbNoCycle_Click(object sender, EventArgs e)
        {
            SetEnables();
        }
    }
}
