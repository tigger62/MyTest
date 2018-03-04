namespace KeyBoardDetectTest
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
            this.btnHook = new System.Windows.Forms.Button();
            this.btnUnhook = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHook
            // 
            this.btnHook.Location = new System.Drawing.Point(8, 16);
            this.btnHook.Name = "btnHook";
            this.btnHook.Size = new System.Drawing.Size(75, 23);
            this.btnHook.TabIndex = 0;
            this.btnHook.Text = "Hook";
            this.btnHook.UseVisualStyleBackColor = true;
            this.btnHook.Click += new System.EventHandler(this.btnHook_Click);
            // 
            // btnUnhook
            // 
            this.btnUnhook.Location = new System.Drawing.Point(421, 16);
            this.btnUnhook.Name = "btnUnhook";
            this.btnUnhook.Size = new System.Drawing.Size(75, 23);
            this.btnUnhook.TabIndex = 1;
            this.btnUnhook.Text = "UnHook";
            this.btnUnhook.UseVisualStyleBackColor = true;
            this.btnUnhook.Click += new System.EventHandler(this.btnUnhook_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 418);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 475);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUnhook);
            this.Controls.Add(this.btnHook);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHook;
        private System.Windows.Forms.Button btnUnhook;
        private System.Windows.Forms.TextBox textBox1;
    }
}

