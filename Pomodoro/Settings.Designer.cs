namespace Pomodoro
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackWorkingTime = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.lblLazyTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackLazyTime = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbNoCycle = new System.Windows.Forms.RadioButton();
            this.rbEndlessCycle = new System.Windows.Forms.RadioButton();
            this.rbCyclesByCount = new System.Windows.Forms.RadioButton();
            this.rbCyclesByDuration = new System.Windows.Forms.RadioButton();
            this.rbCycleUntilTime = new System.Windows.Forms.RadioButton();
            this.txtCycleCount = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtCycleEndTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCycleDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWorkingTime)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLazyTime)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblLazyTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackLazyTime);
            this.panel1.Controls.Add(this.lblWorkingTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackWorkingTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Время работы";
            // 
            // trackWorkingTime
            // 
            this.trackWorkingTime.Location = new System.Drawing.Point(119, 7);
            this.trackWorkingTime.Maximum = 60;
            this.trackWorkingTime.Minimum = 5;
            this.trackWorkingTime.Name = "trackWorkingTime";
            this.trackWorkingTime.Size = new System.Drawing.Size(297, 42);
            this.trackWorkingTime.TabIndex = 0;
            this.trackWorkingTime.TickFrequency = 5;
            this.trackWorkingTime.Value = 5;
            this.trackWorkingTime.ValueChanged += new System.EventHandler(this.trackWorkingTime_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(428, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(347, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 154);
            this.panel3.TabIndex = 2;
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkingTime.Location = new System.Drawing.Point(422, 7);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(61, 19);
            this.lblWorkingTime.TabIndex = 2;
            this.lblWorkingTime.Text = "0 минут";
            // 
            // lblLazyTime
            // 
            this.lblLazyTime.AutoSize = true;
            this.lblLazyTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLazyTime.Location = new System.Drawing.Point(422, 46);
            this.lblLazyTime.Name = "lblLazyTime";
            this.lblLazyTime.Size = new System.Drawing.Size(61, 19);
            this.lblLazyTime.TabIndex = 5;
            this.lblLazyTime.Text = "0 минут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время отдыха";
            // 
            // trackLazyTime
            // 
            this.trackLazyTime.Location = new System.Drawing.Point(119, 46);
            this.trackLazyTime.Maximum = 60;
            this.trackLazyTime.Minimum = 5;
            this.trackLazyTime.Name = "trackLazyTime";
            this.trackLazyTime.Size = new System.Drawing.Size(297, 42);
            this.trackLazyTime.TabIndex = 3;
            this.trackLazyTime.TickFrequency = 5;
            this.trackLazyTime.Value = 5;
            this.trackLazyTime.ValueChanged += new System.EventHandler(this.trackLazyTime_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txtCycleDuration);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtCycleEndTime);
            this.panel4.Controls.Add(this.txtCycleCount);
            this.panel4.Controls.Add(this.rbCycleUntilTime);
            this.panel4.Controls.Add(this.rbCyclesByDuration);
            this.panel4.Controls.Add(this.rbCyclesByCount);
            this.panel4.Controls.Add(this.rbEndlessCycle);
            this.panel4.Controls.Add(this.rbNoCycle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(336, 150);
            this.panel4.TabIndex = 0;
            // 
            // rbNoCycle
            // 
            this.rbNoCycle.AutoSize = true;
            this.rbNoCycle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbNoCycle.Location = new System.Drawing.Point(12, 3);
            this.rbNoCycle.Name = "rbNoCycle";
            this.rbNoCycle.Size = new System.Drawing.Size(88, 22);
            this.rbNoCycle.TabIndex = 0;
            this.rbNoCycle.TabStop = true;
            this.rbNoCycle.Text = "Без цикла";
            this.rbNoCycle.UseVisualStyleBackColor = true;
            this.rbNoCycle.Click += new System.EventHandler(this.rbNoCycle_Click);
            // 
            // rbEndlessCycle
            // 
            this.rbEndlessCycle.AutoSize = true;
            this.rbEndlessCycle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbEndlessCycle.Location = new System.Drawing.Point(12, 31);
            this.rbEndlessCycle.Name = "rbEndlessCycle";
            this.rbEndlessCycle.Size = new System.Drawing.Size(142, 22);
            this.rbEndlessCycle.TabIndex = 1;
            this.rbEndlessCycle.TabStop = true;
            this.rbEndlessCycle.Text = "Бесконечный цикл";
            this.rbEndlessCycle.UseVisualStyleBackColor = true;
            this.rbEndlessCycle.Click += new System.EventHandler(this.rbNoCycle_Click);
            // 
            // rbCyclesByCount
            // 
            this.rbCyclesByCount.AutoSize = true;
            this.rbCyclesByCount.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCyclesByCount.Location = new System.Drawing.Point(12, 59);
            this.rbCyclesByCount.Name = "rbCyclesByCount";
            this.rbCyclesByCount.Size = new System.Drawing.Size(154, 22);
            this.rbCyclesByCount.TabIndex = 2;
            this.rbCyclesByCount.TabStop = true;
            this.rbCyclesByCount.Text = "Остановиться после";
            this.rbCyclesByCount.UseVisualStyleBackColor = true;
            this.rbCyclesByCount.Click += new System.EventHandler(this.rbNoCycle_Click);
            // 
            // rbCyclesByDuration
            // 
            this.rbCyclesByDuration.AutoSize = true;
            this.rbCyclesByDuration.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCyclesByDuration.Location = new System.Drawing.Point(12, 87);
            this.rbCyclesByDuration.Name = "rbCyclesByDuration";
            this.rbCyclesByDuration.Size = new System.Drawing.Size(201, 22);
            this.rbCyclesByDuration.TabIndex = 3;
            this.rbCyclesByDuration.TabStop = true;
            this.rbCyclesByDuration.Text = "Остановиться по истечении";
            this.rbCyclesByDuration.UseVisualStyleBackColor = true;
            this.rbCyclesByDuration.Click += new System.EventHandler(this.rbNoCycle_Click);
            // 
            // rbCycleUntilTime
            // 
            this.rbCycleUntilTime.AutoSize = true;
            this.rbCycleUntilTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbCycleUntilTime.Location = new System.Drawing.Point(12, 115);
            this.rbCycleUntilTime.Name = "rbCycleUntilTime";
            this.rbCycleUntilTime.Size = new System.Drawing.Size(123, 22);
            this.rbCycleUntilTime.TabIndex = 4;
            this.rbCycleUntilTime.TabStop = true;
            this.rbCycleUntilTime.Text = "Остановиться в";
            this.rbCycleUntilTime.UseVisualStyleBackColor = true;
            this.rbCycleUntilTime.Click += new System.EventHandler(this.rbNoCycle_Click);
            // 
            // txtCycleCount
            // 
            this.txtCycleCount.Location = new System.Drawing.Point(172, 61);
            this.txtCycleCount.Name = "txtCycleCount";
            this.txtCycleCount.Size = new System.Drawing.Size(55, 20);
            this.txtCycleCount.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(336, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 150);
            this.panel5.TabIndex = 1;
            // 
            // dtCycleEndTime
            // 
            this.dtCycleEndTime.CustomFormat = "HH:mm";
            this.dtCycleEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCycleEndTime.Location = new System.Drawing.Point(142, 114);
            this.dtCycleEndTime.Name = "dtCycleEndTime";
            this.dtCycleEndTime.ShowUpDown = true;
            this.dtCycleEndTime.Size = new System.Drawing.Size(85, 20);
            this.dtCycleEndTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "циклов";
            // 
            // txtCycleDuration
            // 
            this.txtCycleDuration.Location = new System.Drawing.Point(219, 89);
            this.txtCycleDuration.Name = "txtCycleDuration";
            this.txtCycleDuration.Size = new System.Drawing.Size(55, 20);
            this.txtCycleDuration.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(280, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "минут";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 291);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWorkingTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackLazyTime)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackWorkingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWorkingTime;
        private System.Windows.Forms.Label lblLazyTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackLazyTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbCycleUntilTime;
        private System.Windows.Forms.RadioButton rbCyclesByDuration;
        private System.Windows.Forms.RadioButton rbCyclesByCount;
        private System.Windows.Forms.RadioButton rbEndlessCycle;
        private System.Windows.Forms.RadioButton rbNoCycle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker dtCycleEndTime;
        private System.Windows.Forms.TextBox txtCycleCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCycleDuration;
        private System.Windows.Forms.Label label2;
    }
}