namespace Quikr_Multiple_Posts
{
    partial class Login_Page
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
            this.txtmobno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username/Email ID";
            // 
            // txtmobno
            // 
            this.txtmobno.Location = new System.Drawing.Point(63, 121);
            this.txtmobno.MaxLength = 10;
            this.txtmobno.Name = "txtmobno";
            this.txtmobno.PasswordChar = '*';
            this.txtmobno.Size = new System.Drawing.Size(156, 20);
            this.txtmobno.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(63, 52);
            this.txtun.MaxLength = 32000;
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(156, 20);
            this.txtun.TabIndex = 1;
            this.txtun.TextChanged += new System.EventHandler(this.txtun_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Password";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Location = new System.Drawing.Point(76, 80);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(0, 13);
            this.lblun.TabIndex = 6;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmobno);
            this.Controls.Add(this.label1);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmobno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblun;
    }
}