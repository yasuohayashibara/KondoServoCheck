namespace KondoServoCheck
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.buttonServoOn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonServoOff = new System.Windows.Forms.Button();
            this.trackBarAngle = new System.Windows.Forms.TrackBar();
            this.buttonMotion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 1500000;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadTimeout = 1000;
            // 
            // buttonServoOn
            // 
            this.buttonServoOn.Location = new System.Drawing.Point(16, 16);
            this.buttonServoOn.Name = "buttonServoOn";
            this.buttonServoOn.Size = new System.Drawing.Size(88, 23);
            this.buttonServoOn.TabIndex = 0;
            this.buttonServoOn.Text = "SERVO ON";
            this.buttonServoOn.UseVisualStyleBackColor = true;
            this.buttonServoOn.Click += new System.EventHandler(this.buttonServoOn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonServoOff
            // 
            this.buttonServoOff.Location = new System.Drawing.Point(120, 16);
            this.buttonServoOff.Name = "buttonServoOff";
            this.buttonServoOff.Size = new System.Drawing.Size(88, 23);
            this.buttonServoOff.TabIndex = 1;
            this.buttonServoOff.Text = "SERVO OFF";
            this.buttonServoOff.UseVisualStyleBackColor = true;
            this.buttonServoOff.Click += new System.EventHandler(this.buttonServoOff_Click);
            // 
            // trackBarAngle
            // 
            this.trackBarAngle.Location = new System.Drawing.Point(16, 144);
            this.trackBarAngle.Maximum = 18000;
            this.trackBarAngle.Minimum = -18000;
            this.trackBarAngle.Name = "trackBarAngle";
            this.trackBarAngle.Size = new System.Drawing.Size(256, 45);
            this.trackBarAngle.TabIndex = 2;
            this.trackBarAngle.TickFrequency = 1000;
            this.trackBarAngle.Scroll += new System.EventHandler(this.trackBarAngle_Scroll);
            // 
            // buttonMotion
            // 
            this.buttonMotion.Location = new System.Drawing.Point(16, 56);
            this.buttonMotion.Name = "buttonMotion";
            this.buttonMotion.Size = new System.Drawing.Size(88, 23);
            this.buttonMotion.TabIndex = 3;
            this.buttonMotion.Text = "MOTION";
            this.buttonMotion.UseVisualStyleBackColor = true;
            this.buttonMotion.Click += new System.EventHandler(this.buttonMotion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonMotion);
            this.Controls.Add(this.trackBarAngle);
            this.Controls.Add(this.buttonServoOff);
            this.Controls.Add(this.buttonServoOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonServoOn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonServoOff;
        private System.Windows.Forms.TrackBar trackBarAngle;
        private System.Windows.Forms.Button buttonMotion;
    }
}

