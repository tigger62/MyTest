namespace Launcher
{
    partial class fmLauncher
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
            this.btnClosed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSetAppName = new System.Windows.Forms.TextBox();
            this.tbxSetIdleTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowPID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(169, 181);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(75, 23);
            this.btnClosed.TabIndex = 1;
            this.btnClosed.Text = "Closed";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "程式名稱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "閒置時間";
            // 
            // tbxSetAppName
            // 
            this.tbxSetAppName.Location = new System.Drawing.Point(79, 26);
            this.tbxSetAppName.Name = "tbxSetAppName";
            this.tbxSetAppName.Size = new System.Drawing.Size(201, 22);
            this.tbxSetAppName.TabIndex = 4;
            // 
            // tbxSetIdleTime
            // 
            this.tbxSetIdleTime.Location = new System.Drawing.Point(79, 65);
            this.tbxSetIdleTime.Name = "tbxSetIdleTime";
            this.tbxSetIdleTime.Size = new System.Drawing.Size(57, 22);
            this.tbxSetIdleTime.TabIndex = 5;
            this.tbxSetIdleTime.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // lblShowPID
            // 
            this.lblShowPID.AutoSize = true;
            this.lblShowPID.Location = new System.Drawing.Point(77, 50);
            this.lblShowPID.Name = "lblShowPID";
            this.lblShowPID.Size = new System.Drawing.Size(33, 12);
            this.lblShowPID.TabIndex = 7;
            this.lblShowPID.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // fmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblShowPID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSetIdleTime);
            this.Controls.Add(this.tbxSetAppName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnStart);
            this.Name = "fmLauncher";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmLauncher_FormClosing);
            this.Load += new System.EventHandler(this.fmLauncher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSetAppName;
        private System.Windows.Forms.TextBox tbxSetIdleTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowPID;
        private System.Windows.Forms.Label label5;
    }
}

