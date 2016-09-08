namespace Quikr_Multiple_Posts
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
            this.City = new System.Windows.Forms.Button();
            this.Cith_Label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Title_textBox1 = new System.Windows.Forms.TextBox();
            this.Desc_textBox2 = new System.Windows.Forms.TextBox();
            this.Name_textBox1 = new System.Windows.Forms.TextBox();
            this.Email_textBox2 = new System.Windows.Forms.TextBox();
            this.Mobile_textBox1 = new System.Windows.Forms.TextBox();
            this.button_Load_Webpage = new System.Windows.Forms.Button();
            this.Email_Noti = new System.Windows.Forms.Label();
            this.mobile_label = new System.Windows.Forms.Label();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Mobile_No = new System.Windows.Forms.Label();
            this.label_Email_ID = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Subcategory = new System.Windows.Forms.ComboBox();
            this.lblfm12fm2 = new System.Windows.Forms.Label();
            this.lbl12lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(13, 370);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(90, 36);
            this.City.TabIndex = 2;
            this.City.Text = "City";
            this.City.UseVisualStyleBackColor = true;
            this.City.Click += new System.EventHandler(this.City_Click);
            // 
            // Cith_Label
            // 
            this.Cith_Label.AutoSize = true;
            this.Cith_Label.Location = new System.Drawing.Point(110, 380);
            this.Cith_Label.Name = "Cith_Label";
            this.Cith_Label.Size = new System.Drawing.Size(0, 13);
            this.Cith_Label.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Title_textBox1
            // 
            this.Title_textBox1.Location = new System.Drawing.Point(79, 421);
            this.Title_textBox1.Name = "Title_textBox1";
            this.Title_textBox1.Size = new System.Drawing.Size(529, 20);
            this.Title_textBox1.TabIndex = 5;
            // 
            // Desc_textBox2
            // 
            this.Desc_textBox2.Location = new System.Drawing.Point(79, 453);
            this.Desc_textBox2.Multiline = true;
            this.Desc_textBox2.Name = "Desc_textBox2";
            this.Desc_textBox2.Size = new System.Drawing.Size(529, 185);
            this.Desc_textBox2.TabIndex = 8;
            // 
            // Name_textBox1
            // 
            this.Name_textBox1.Location = new System.Drawing.Point(802, 373);
            this.Name_textBox1.Name = "Name_textBox1";
            this.Name_textBox1.Size = new System.Drawing.Size(179, 20);
            this.Name_textBox1.TabIndex = 10;
            // 
            // Email_textBox2
            // 
            this.Email_textBox2.Location = new System.Drawing.Point(802, 415);
            this.Email_textBox2.Name = "Email_textBox2";
            this.Email_textBox2.Size = new System.Drawing.Size(179, 20);
            this.Email_textBox2.TabIndex = 12;
            this.Email_textBox2.TextChanged += new System.EventHandler(this.Email_textBox2_TextChanged);
            // 
            // Mobile_textBox1
            // 
            this.Mobile_textBox1.Location = new System.Drawing.Point(802, 457);
            this.Mobile_textBox1.MaxLength = 10;
            this.Mobile_textBox1.Name = "Mobile_textBox1";
            this.Mobile_textBox1.Size = new System.Drawing.Size(179, 20);
            this.Mobile_textBox1.TabIndex = 14;
            this.Mobile_textBox1.TextChanged += new System.EventHandler(this.Mobile_textBox1_TextChanged);
            // 
            // button_Load_Webpage
            // 
            this.button_Load_Webpage.Location = new System.Drawing.Point(802, 523);
            this.button_Load_Webpage.Name = "button_Load_Webpage";
            this.button_Load_Webpage.Size = new System.Drawing.Size(83, 36);
            this.button_Load_Webpage.TabIndex = 15;
            this.button_Load_Webpage.Text = "Load Webpage";
            this.button_Load_Webpage.UseVisualStyleBackColor = true;
            this.button_Load_Webpage.Click += new System.EventHandler(this.button_Load_Webpage_Click);
            // 
            // Email_Noti
            // 
            this.Email_Noti.AutoSize = true;
            this.Email_Noti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Noti.Location = new System.Drawing.Point(806, 439);
            this.Email_Noti.Name = "Email_Noti";
            this.Email_Noti.Size = new System.Drawing.Size(0, 15);
            this.Email_Noti.TabIndex = 17;
            // 
            // mobile_label
            // 
            this.mobile_label.AutoSize = true;
            this.mobile_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_label.Location = new System.Drawing.Point(806, 482);
            this.mobile_label.Name = "mobile_label";
            this.mobile_label.Size = new System.Drawing.Size(0, 15);
            this.mobile_label.TabIndex = 18;
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Location = new System.Drawing.Point(13, 13);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1345, 303);
            this.geckoWebBrowser1.TabIndex = 27;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(23, 424);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 28;
            this.label_Title.Text = "Title";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 456);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 29;
            this.label_Description.Text = "Description";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(718, 376);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 30;
            this.label_Name.Text = "Name";
            // 
            // label_Mobile_No
            // 
            this.label_Mobile_No.AutoSize = true;
            this.label_Mobile_No.Location = new System.Drawing.Point(718, 460);
            this.label_Mobile_No.Name = "label_Mobile_No";
            this.label_Mobile_No.Size = new System.Drawing.Size(55, 13);
            this.label_Mobile_No.TabIndex = 31;
            this.label_Mobile_No.Text = "Mobile No";
            // 
            // label_Email_ID
            // 
            this.label_Email_ID.AutoSize = true;
            this.label_Email_ID.Location = new System.Drawing.Point(718, 418);
            this.label_Email_ID.Name = "label_Email_ID";
            this.label_Email_ID.Size = new System.Drawing.Size(46, 13);
            this.label_Email_ID.TabIndex = 32;
            this.label_Email_ID.Text = "Email ID";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Mohan",
            "Kumar"});
            this.comboBox_Category.Location = new System.Drawing.Point(13, 333);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Category.TabIndex = 33;
            this.comboBox_Category.Text = "--Please Select--";
            // 
            // comboBox_Subcategory
            // 
            this.comboBox_Subcategory.FormattingEnabled = true;
            this.comboBox_Subcategory.Location = new System.Drawing.Point(188, 333);
            this.comboBox_Subcategory.Name = "comboBox_Subcategory";
            this.comboBox_Subcategory.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Subcategory.TabIndex = 34;
            this.comboBox_Subcategory.Text = "--Please Select--";
            // 
            // lblfm12fm2
            // 
            this.lblfm12fm2.AutoSize = true;
            this.lblfm12fm2.Location = new System.Drawing.Point(363, 340);
            this.lblfm12fm2.Name = "lblfm12fm2";
            this.lblfm12fm2.Size = new System.Drawing.Size(0, 13);
            this.lblfm12fm2.TabIndex = 35;
            // 
            // lbl12lbl3
            // 
            this.lbl12lbl3.AutoSize = true;
            this.lbl12lbl3.Location = new System.Drawing.Point(381, 333);
            this.lbl12lbl3.Name = "lbl12lbl3";
            this.lbl12lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl12lbl3.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1370, 644);
            this.Controls.Add(this.lbl12lbl3);
            this.Controls.Add(this.lblfm12fm2);
            this.Controls.Add(this.comboBox_Subcategory);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.label_Email_ID);
            this.Controls.Add(this.label_Mobile_No);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Controls.Add(this.mobile_label);
            this.Controls.Add(this.Email_Noti);
            this.Controls.Add(this.button_Load_Webpage);
            this.Controls.Add(this.Mobile_textBox1);
            this.Controls.Add(this.Email_textBox2);
            this.Controls.Add(this.Name_textBox1);
            this.Controls.Add(this.Desc_textBox2);
            this.Controls.Add(this.Title_textBox1);
            this.Controls.Add(this.Cith_Label);
            this.Controls.Add(this.City);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Quikr Multiple Posts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button City;
        private System.Windows.Forms.Label Cith_Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Title_textBox1;
        private System.Windows.Forms.TextBox Desc_textBox2;
        private System.Windows.Forms.TextBox Name_textBox1;
        private System.Windows.Forms.TextBox Email_textBox2;
        private System.Windows.Forms.TextBox Mobile_textBox1;
        private System.Windows.Forms.Button button_Load_Webpage;
        private System.Windows.Forms.Label Email_Noti;
        private System.Windows.Forms.Label mobile_label;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Mobile_No;
        private System.Windows.Forms.Label label_Email_ID;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Subcategory;
        private System.Windows.Forms.Label lblfm12fm2;
        private System.Windows.Forms.Label lbl12lbl3;
    }
}

