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
            trackWorkingTime.Value = Properties.Settings.Default.WorkingTime;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WorkingTime = trackWorkingTime.Value;
            Properties.Settings.Default.Save();
            Close();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
