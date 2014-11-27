using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pomodoro
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            trackWorkingTime.Value = AppConfiguration.WorkingTime;
            trackLazyTime.Value = AppConfiguration.LazyTime;
            txtCycleCount.Text = AppConfiguration.CycleCount.ToString();
            txtCycleDuration.Text = AppConfiguration.CycleDuration.ToString();
            if (AppConfiguration.CycleEndTime < DateTime.Now)
                AppConfiguration.CycleEndTime = DateTime.Now;
            dtCycleEndTime.Value = AppConfiguration.CycleEndTime;
            SetCycleRadioButtons();
            SetEnables();
        }

        private void ValidateInput()
        {
            if (trackWorkingTime.Value == 0)
                throw new Exception("Рабочее время не может быть равно нулю");
            if (trackLazyTime.Value == 0)
                throw new Exception("Время отдыха не может быть равно нулю");
            int value;
            if (rbCyclesByCount.Checked && 
                (!int.TryParse(txtCycleCount.Text, out value) || value <= 0))
                throw new Exception("Количество циклов должно быть целым числом больше нуля");
            if (rbCyclesByDuration.Checked &&
                (!int.TryParse(txtCycleDuration.Text, out value) || value <= 0))
                throw new Exception("Количество минут должно быть целым числом больше нуля");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

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
