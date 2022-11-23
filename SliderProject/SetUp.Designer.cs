
namespace SliderProject
{
    partial class SetUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbLap = new System.Windows.Forms.CheckBox();
            this.cbNgauNhien = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian slide (s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cho phép lặp lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngẫu nhiên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbLap
            // 
            this.cbLap.AutoSize = true;
            this.cbLap.Location = new System.Drawing.Point(192, 75);
            this.cbLap.Name = "cbLap";
            this.cbLap.Size = new System.Drawing.Size(22, 21);
            this.cbLap.TabIndex = 9;
            this.cbLap.UseVisualStyleBackColor = true;
            // 
            // cbNgauNhien
            // 
            this.cbNgauNhien.AutoSize = true;
            this.cbNgauNhien.Location = new System.Drawing.Point(192, 118);
            this.cbNgauNhien.Name = "cbNgauNhien";
            this.cbNgauNhien.Size = new System.Drawing.Size(22, 21);
            this.cbNgauNhien.TabIndex = 10;
            this.cbNgauNhien.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(192, 23);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(162, 31);
            this.timer.TabIndex = 11;
            this.timer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(366, 223);
            this.ControlBox = false;
            this.Controls.Add(this.timer);
            this.Controls.Add(this.cbNgauNhien);
            this.Controls.Add(this.cbLap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetUp";
            this.Text = "SetUp";
            this.Load += new System.EventHandler(this.SetUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbLap;
        private System.Windows.Forms.CheckBox cbNgauNhien;
        private System.Windows.Forms.NumericUpDown timer;
    }
}