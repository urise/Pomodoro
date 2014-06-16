namespace Pomodoro
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnStopWork = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tray
            // 
            this.Tray.ContextMenuStrip = this.TrayMenu;
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Pomodoro Method";
            this.Tray.Visible = true;
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            // 
            // TrayMenu
            // 
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWorkToolStripMenuItem,
            this.stopWorkToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(163, 70);
            // 
            // startWorkToolStripMenuItem
            // 
            this.startWorkToolStripMenuItem.Name = "startWorkToolStripMenuItem";
            this.startWorkToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.startWorkToolStripMenuItem.Text = "Начать работать";
            // 
            // stopWorkToolStripMenuItem
            // 
            this.stopWorkToolStripMenuItem.Name = "stopWorkToolStripMenuItem";
            this.stopWorkToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.stopWorkToolStripMenuItem.Text = "Начать лениться";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(12, 12);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(129, 23);
            this.btnStartWork.TabIndex = 1;
            this.btnStartWork.Text = "Начать работать";
            this.btnStartWork.UseVisualStyleBackColor = true;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // btnStopWork
            // 
            this.btnStopWork.Location = new System.Drawing.Point(13, 42);
            this.btnStopWork.Name = "btnStopWork";
            this.btnStopWork.Size = new System.Drawing.Size(128, 23);
            this.btnStopWork.TabIndex = 2;
            this.btnStopWork.Text = "Начать лениться";
            this.btnStopWork.UseVisualStyleBackColor = true;
            this.btnStopWork.Click += new System.EventHandler(this.btnStopWork_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(147, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(119, 46);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "20:00";
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 69);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStopWork);
            this.Controls.Add(this.btnStartWork);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.Text = "Метод Помидора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.ToolStripMenuItem startWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnStopWork;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer MainTimer;
    }
}

