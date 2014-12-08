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
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pctPomodoro = new System.Windows.Forms.PictureBox();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPomodoro)).BeginInit();
            this.mainMenu.SuspendLayout();
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
            this.pauseToolStripMenuItem,
            this.стопToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.TrayMenu.Name = "TrayMenu";
            this.TrayMenu.Size = new System.Drawing.Size(126, 114);
            // 
            // startWorkToolStripMenuItem
            // 
            this.startWorkToolStripMenuItem.Name = "startWorkToolStripMenuItem";
            this.startWorkToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.startWorkToolStripMenuItem.Text = "Работать";
            this.startWorkToolStripMenuItem.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // stopWorkToolStripMenuItem
            // 
            this.stopWorkToolStripMenuItem.Name = "stopWorkToolStripMenuItem";
            this.stopWorkToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.stopWorkToolStripMenuItem.Text = "Отдыхать";
            this.stopWorkToolStripMenuItem.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pauseToolStripMenuItem.Text = "Пауза";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // стопToolStripMenuItem
            // 
            this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            this.стопToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.стопToolStripMenuItem.Text = "Стоп";
            this.стопToolStripMenuItem.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 293);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tomato-green.ico");
            this.imageList1.Images.SetKeyName(1, "tomato-orange.ico");
            this.imageList1.Images.SetKeyName(2, "tomato-red.ico");
            // 
            // pctPomodoro
            // 
            this.pctPomodoro.Location = new System.Drawing.Point(12, 0);
            this.pctPomodoro.Name = "pctPomodoro";
            this.pctPomodoro.Size = new System.Drawing.Size(300, 300);
            this.pctPomodoro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPomodoro.TabIndex = 5;
            this.pctPomodoro.TabStop = false;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinutes.Location = new System.Drawing.Point(89, 133);
            this.lblMinutes.MinimumSize = new System.Drawing.Size(75, 0);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(75, 46);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "20";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(89, 192);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(75, 22);
            this.btnStartWork.TabIndex = 1;
            this.btnStartWork.Text = "СТАРТ";
            this.btnStartWork.UseVisualStyleBackColor = true;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(89, 220);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(157, 22);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "ПАУЗА";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(171, 192);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 22);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "СТОП";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(89, 248);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(157, 22);
            this.btnRest.TabIndex = 7;
            this.btnRest.Text = "Отдыхать";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.Location = new System.Drawing.Point(171, 133);
            this.lblSeconds.MinimumSize = new System.Drawing.Size(75, 0);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(75, 46);
            this.lblSeconds.TabIndex = 8;
            this.lblSeconds.Text = "20";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(326, 24);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem2.Text = "About";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 318);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.pctPomodoro);
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.Text = "Метод Помидора 0.6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.TrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctPomodoro)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
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
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стопToolStripMenuItem;
        internal System.Windows.Forms.PictureBox pctPomodoro;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

