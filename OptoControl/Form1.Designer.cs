namespace OptoControl
{
    partial class OptoControl
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
            this.MyButtonEnable = new System.Windows.Forms.Button();
            this.MyButtonDirection = new System.Windows.Forms.Button();
            this.MyTrackBarInterval = new System.Windows.Forms.TrackBar();
            this.MyLabelInterval = new System.Windows.Forms.Label();
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyTrackBarInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // MyButtonEnable
            // 
            this.MyButtonEnable.Location = new System.Drawing.Point(12, 12);
            this.MyButtonEnable.Name = "MyButtonEnable";
            this.MyButtonEnable.Size = new System.Drawing.Size(129, 52);
            this.MyButtonEnable.TabIndex = 1;
            this.MyButtonEnable.Text = "Enable";
            this.MyButtonEnable.UseVisualStyleBackColor = true;
            this.MyButtonEnable.Click += new System.EventHandler(this.MyButtonEnable_Click);
            // 
            // MyButtonDirection
            // 
            this.MyButtonDirection.Location = new System.Drawing.Point(514, 12);
            this.MyButtonDirection.Name = "MyButtonDirection";
            this.MyButtonDirection.Size = new System.Drawing.Size(153, 52);
            this.MyButtonDirection.TabIndex = 2;
            this.MyButtonDirection.Text = "Turn Right";
            this.MyButtonDirection.UseVisualStyleBackColor = true;
            this.MyButtonDirection.Click += new System.EventHandler(this.MyButtonDirection_Click);
            // 
            // MyTrackBarInterval
            // 
            this.MyTrackBarInterval.LargeChange = 1;
            this.MyTrackBarInterval.Location = new System.Drawing.Point(12, 70);
            this.MyTrackBarInterval.Maximum = 30;
            this.MyTrackBarInterval.Minimum = 2;
            this.MyTrackBarInterval.Name = "MyTrackBarInterval";
            this.MyTrackBarInterval.Size = new System.Drawing.Size(655, 69);
            this.MyTrackBarInterval.TabIndex = 3;
            this.MyTrackBarInterval.Value = 5;
            this.MyTrackBarInterval.Scroll += new System.EventHandler(this.MyTrackBarInterval_Scroll);
            // 
            // MyLabelInterval
            // 
            this.MyLabelInterval.AutoSize = true;
            this.MyLabelInterval.Location = new System.Drawing.Point(290, 28);
            this.MyLabelInterval.Name = "MyLabelInterval";
            this.MyLabelInterval.Size = new System.Drawing.Size(51, 20);
            this.MyLabelInterval.TabIndex = 4;
            this.MyLabelInterval.Text = "label1";
            this.MyLabelInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MySerialPort
            // 
            this.MySerialPort.PortName = "COM3";
            // 
            // OptoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 281);
            this.Controls.Add(this.MyLabelInterval);
            this.Controls.Add(this.MyTrackBarInterval);
            this.Controls.Add(this.MyButtonDirection);
            this.Controls.Add(this.MyButtonEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptoControl";
            this.Text = "OptoControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Optocontrol_Close);
            this.Load += new System.EventHandler(this.OptoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyTrackBarInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MyButtonEnable;
        private System.Windows.Forms.Button MyButtonDirection;
        private System.Windows.Forms.TrackBar MyTrackBarInterval;
        private System.Windows.Forms.Label MyLabelInterval;
        private System.IO.Ports.SerialPort MySerialPort;
    }
}

