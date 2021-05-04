namespace SmartFoodCourtSystem
{
    partial class fRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Register = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_User_Name = new System.Windows.Forms.TextBox();
            this.textBox_Display_Name = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_ReEnter = new System.Windows.Forms.TextBox();
            this.comboBox_Court = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(71, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÍ";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hãy điền đầy đủ các thông tin bên dưới để hoàn tất quá trình \r\nđăng kí tài khoản." +
    "\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên hiển thị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(13, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhập lại mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(13, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chọn quầy";
            // 
            // button_Register
            // 
            this.button_Register.Location = new System.Drawing.Point(45, 319);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(90, 37);
            this.button_Register.TabIndex = 8;
            this.button_Register.Text = "Đăng kí";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Dang_Ki_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(196, 319);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(90, 37);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "Nhập lại";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Nhap_Lai_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.Location = new System.Drawing.Point(336, 319);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(90, 37);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Quay lại";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Quay_Lai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên đăng nhập";
            // 
            // textBox_User_Name
            // 
            this.textBox_User_Name.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_User_Name.Location = new System.Drawing.Point(158, 137);
            this.textBox_User_Name.Name = "textBox_User_Name";
            this.textBox_User_Name.Size = new System.Drawing.Size(195, 20);
            this.textBox_User_Name.TabIndex = 0;
            this.textBox_User_Name.Text = "User name";
            this.textBox_User_Name.Enter += new System.EventHandler(this.textBox_Ten_Dang_Nhap_Enter);
            // 
            // textBox_Display_Name
            // 
            this.textBox_Display_Name.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Display_Name.Location = new System.Drawing.Point(158, 175);
            this.textBox_Display_Name.Name = "textBox_Display_Name";
            this.textBox_Display_Name.Size = new System.Drawing.Size(195, 20);
            this.textBox_Display_Name.TabIndex = 1;
            this.textBox_Display_Name.Text = "User display name";
            this.textBox_Display_Name.Enter += new System.EventHandler(this.textBox_Ten_Hien_Thi_Enter);
            // 
            // textBox_Password
            // 
            this.textBox_Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Password.Location = new System.Drawing.Point(158, 248);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(195, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.Text = "matkhau";
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.Enter += new System.EventHandler(this.textBox_Mat_Khau_Enter);
            // 
            // textBox_ReEnter
            // 
            this.textBox_ReEnter.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_ReEnter.Location = new System.Drawing.Point(158, 285);
            this.textBox_ReEnter.Name = "textBox_ReEnter";
            this.textBox_ReEnter.Size = new System.Drawing.Size(195, 20);
            this.textBox_ReEnter.TabIndex = 4;
            this.textBox_ReEnter.Text = "matkhau";
            this.textBox_ReEnter.UseSystemPasswordChar = true;
            this.textBox_ReEnter.Enter += new System.EventHandler(this.textBox_Nhap_Lai_MK_Enter);
            // 
            // comboBox_Court
            // 
            this.comboBox_Court.FormattingEnabled = true;
            this.comboBox_Court.Items.AddRange(new object[] {
            "Tất cả các quầy",
            "The Canteen",
            "Green Mint",
            "The Rice"});
            this.comboBox_Court.Location = new System.Drawing.Point(158, 210);
            this.comboBox_Court.Name = "comboBox_Court";
            this.comboBox_Court.Size = new System.Drawing.Size(195, 21);
            this.comboBox_Court.TabIndex = 2;
            // 
            // fRegister
            // 
            this.AcceptButton = this.button_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(438, 368);
            this.Controls.Add(this.comboBox_Court);
            this.Controls.Add(this.textBox_ReEnter);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Display_Name);
            this.Controls.Add(this.textBox_User_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fRegister_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_User_Name;
        private System.Windows.Forms.TextBox textBox_Display_Name;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_ReEnter;
        private System.Windows.Forms.ComboBox comboBox_Court;
    }
}