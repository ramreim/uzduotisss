namespace threaddsss
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbusena03 = new System.Windows.Forms.Label();
            this.lblbusena04 = new System.Windows.Forms.Label();
            this.lblbusena05 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(550, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "startt";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(773, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblbusena03
            // 
            this.lblbusena03.AutoSize = true;
            this.lblbusena03.Location = new System.Drawing.Point(776, 114);
            this.lblbusena03.Name = "lblbusena03";
            this.lblbusena03.Size = new System.Drawing.Size(35, 13);
            this.lblbusena03.TabIndex = 3;
            this.lblbusena03.Text = "label3";
            // 
            // lblbusena04
            // 
            this.lblbusena04.AutoSize = true;
            this.lblbusena04.Location = new System.Drawing.Point(767, 164);
            this.lblbusena04.Name = "lblbusena04";
            this.lblbusena04.Size = new System.Drawing.Size(35, 13);
            this.lblbusena04.TabIndex = 4;
            this.lblbusena04.Text = "label4";
            // 
            // lblbusena05
            // 
            this.lblbusena05.AutoSize = true;
            this.lblbusena05.Location = new System.Drawing.Point(776, 212);
            this.lblbusena05.Name = "lblbusena05";
            this.lblbusena05.Size = new System.Drawing.Size(35, 13);
            this.lblbusena05.TabIndex = 5;
            this.lblbusena05.Text = "label5";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(550, 87);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 67);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(550, 160);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 65);
            this.btnResume.TabIndex = 7;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 451);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblbusena05);
            this.Controls.Add(this.lblbusena04);
            this.Controls.Add(this.lblbusena03);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbusena03;
        private System.Windows.Forms.Label lblbusena04;
        private System.Windows.Forms.Label lblbusena05;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResume;
    }
}

