namespace SmartFoodCourtSystem
{
    partial class fOrderManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fOrderManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel_Order = new System.Windows.Forms.FlowLayoutPanel();
            this.listView_Order_Info = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Mess = new System.Windows.Forms.TextBox();
            this.button_Send_Mess = new System.Windows.Forms.Button();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Food = new System.Windows.Forms.ComboBox();
            this.button_Add_Food = new System.Windows.Forms.Button();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Total_Price = new System.Windows.Forms.TextBox();
            this.button_Complete = new System.Windows.Forms.Button();
            this.textBox_User_Mess = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_User_Name = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flowLayoutPanel_Order
            // 
            this.flowLayoutPanel_Order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel_Order.Location = new System.Drawing.Point(13, 28);
            this.flowLayoutPanel_Order.Name = "flowLayoutPanel_Order";
            this.flowLayoutPanel_Order.Size = new System.Drawing.Size(494, 450);
            this.flowLayoutPanel_Order.TabIndex = 1;
            // 
            // listView_Order_Info
            // 
            this.listView_Order_Info.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView_Order_Info.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_Order_Info.FullRowSelect = true;
            this.listView_Order_Info.GridLines = true;
            this.listView_Order_Info.HideSelection = false;
            this.listView_Order_Info.Location = new System.Drawing.Point(513, 87);
            this.listView_Order_Info.Name = "listView_Order_Info";
            this.listView_Order_Info.Size = new System.Drawing.Size(331, 404);
            this.listView_Order_Info.TabIndex = 2;
            this.listView_Order_Info.UseCompatibleStateImageBehavior = false;
            this.listView_Order_Info.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên tài khoản";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đặt hàng";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên món";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Đơn giá";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thành tiền";
            // 
            // textBox_Mess
            // 
            this.textBox_Mess.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_Mess.Location = new System.Drawing.Point(14, 528);
            this.textBox_Mess.Multiline = true;
            this.textBox_Mess.Name = "textBox_Mess";
            this.textBox_Mess.Size = new System.Drawing.Size(494, 162);
            this.textBox_Mess.TabIndex = 3;
            this.textBox_Mess.Text = "Hãy nhập lời nhắn bạn muốn gửi đến khách hàng";
            this.textBox_Mess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Mess_MouseClick);
            // 
            // button_Send_Mess
            // 
            this.button_Send_Mess.Location = new System.Drawing.Point(13, 484);
            this.button_Send_Mess.Name = "button_Send_Mess";
            this.button_Send_Mess.Size = new System.Drawing.Size(111, 38);
            this.button_Send_Mess.TabIndex = 4;
            this.button_Send_Mess.Text = "Gửi tin nhắn";
            this.button_Send_Mess.UseVisualStyleBackColor = true;
            this.button_Send_Mess.Click += new System.EventHandler(this.button_Send_Mess_Click);
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(514, 28);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(212, 21);
            this.comboBox_Category.TabIndex = 5;
            this.comboBox_Category.SelectedIndexChanged += new System.EventHandler(this.comboBox_Category_SelectedIndexChanged);
            // 
            // comboBox_Food
            // 
            this.comboBox_Food.FormattingEnabled = true;
            this.comboBox_Food.Location = new System.Drawing.Point(514, 56);
            this.comboBox_Food.Name = "comboBox_Food";
            this.comboBox_Food.Size = new System.Drawing.Size(212, 21);
            this.comboBox_Food.TabIndex = 9;
            // 
            // button_Add_Food
            // 
            this.button_Add_Food.Location = new System.Drawing.Point(733, 28);
            this.button_Add_Food.Name = "button_Add_Food";
            this.button_Add_Food.Size = new System.Drawing.Size(73, 49);
            this.button_Add_Food.TabIndex = 10;
            this.button_Add_Food.Text = "Thêm món";
            this.button_Add_Food.UseVisualStyleBackColor = true;
            this.button_Add_Food.Click += new System.EventHandler(this.button_Add_Food_Click);
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Location = new System.Drawing.Point(812, 44);
            this.numericUpDown_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown_Amount.TabIndex = 11;
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(514, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng tiền:";
            // 
            // textBox_Total_Price
            // 
            this.textBox_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_Price.ForeColor = System.Drawing.Color.Red;
            this.textBox_Total_Price.Location = new System.Drawing.Point(513, 666);
            this.textBox_Total_Price.Name = "textBox_Total_Price";
            this.textBox_Total_Price.ReadOnly = true;
            this.textBox_Total_Price.Size = new System.Drawing.Size(198, 24);
            this.textBox_Total_Price.TabIndex = 13;
            // 
            // button_Complete
            // 
            this.button_Complete.Location = new System.Drawing.Point(717, 639);
            this.button_Complete.Name = "button_Complete";
            this.button_Complete.Size = new System.Drawing.Size(128, 51);
            this.button_Complete.TabIndex = 14;
            this.button_Complete.Text = "Hoàn tất đơn hàng";
            this.button_Complete.UseVisualStyleBackColor = true;
            this.button_Complete.Click += new System.EventHandler(this.button_Complete_Click);
            // 
            // textBox_User_Mess
            // 
            this.textBox_User_Mess.Location = new System.Drawing.Point(514, 528);
            this.textBox_User_Mess.Multiline = true;
            this.textBox_User_Mess.Name = "textBox_User_Mess";
            this.textBox_User_Mess.Size = new System.Drawing.Size(331, 100);
            this.textBox_User_Mess.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lời nhắn của khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_User_Name
            // 
            this.textBox_User_Name.Location = new System.Drawing.Point(657, 0);
            this.textBox_User_Name.Name = "textBox_User_Name";
            this.textBox_User_Name.ReadOnly = true;
            this.textBox_User_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_User_Name.TabIndex = 18;
            // 
            // fOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 702);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_User_Name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_User_Mess);
            this.Controls.Add(this.button_Complete);
            this.Controls.Add(this.textBox_Total_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.button_Add_Food);
            this.Controls.Add(this.comboBox_Food);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.button_Send_Mess);
            this.Controls.Add(this.textBox_Mess);
            this.Controls.Add(this.listView_Order_Info);
            this.Controls.Add(this.flowLayoutPanel_Order);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fOrderManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Food Court System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fOrderManager_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Order;
        private System.Windows.Forms.ListView listView_Order_Info;
        private System.Windows.Forms.TextBox textBox_Mess;
        private System.Windows.Forms.Button button_Send_Mess;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Food;
        private System.Windows.Forms.Button button_Add_Food;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Total_Price;
        private System.Windows.Forms.Button button_Complete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox_User_Mess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_User_Name;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}