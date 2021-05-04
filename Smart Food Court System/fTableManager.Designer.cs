namespace SmartFoodCourtSystem
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listview_Bill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Total_Price = new System.Windows.Forms.TextBox();
            this.combobox_Switch_Table = new System.Windows.Forms.ComboBox();
            this.button_Switch_Table = new System.Windows.Forms.Button();
            this.button_Check_Out = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numeric_Food_Count = new System.Windows.Forms.NumericUpDown();
            this.button_Add_Food = new System.Windows.Forms.Button();
            this.combobox_Food = new System.Windows.Forms.ComboBox();
            this.combobox_Category = new System.Windows.Forms.ComboBox();
            this.flowlayout_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Food_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.adminToolStripMenuItem.Text = "Quản lý";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listview_Bill);
            this.panel2.Location = new System.Drawing.Point(447, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 315);
            this.panel2.TabIndex = 2;
            // 
            // listview_Bill
            // 
            this.listview_Bill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listview_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_Bill.GridLines = true;
            this.listview_Bill.HideSelection = false;
            this.listview_Bill.Location = new System.Drawing.Point(3, 3);
            this.listview_Bill.Name = "listview_Bill";
            this.listview_Bill.Size = new System.Drawing.Size(332, 309);
            this.listview_Bill.TabIndex = 0;
            this.listview_Bill.UseCompatibleStateImageBehavior = false;
            this.listview_Bill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textbox_Total_Price);
            this.panel3.Controls.Add(this.combobox_Switch_Table);
            this.panel3.Controls.Add(this.button_Switch_Table);
            this.panel3.Controls.Add(this.button_Check_Out);
            this.panel3.Location = new System.Drawing.Point(447, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 52);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tổng tiền:";
            // 
            // textbox_Total_Price
            // 
            this.textbox_Total_Price.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textbox_Total_Price.ForeColor = System.Drawing.Color.OrangeRed;
            this.textbox_Total_Price.Location = new System.Drawing.Point(84, 24);
            this.textbox_Total_Price.Name = "textbox_Total_Price";
            this.textbox_Total_Price.ReadOnly = true;
            this.textbox_Total_Price.Size = new System.Drawing.Size(170, 25);
            this.textbox_Total_Price.TabIndex = 7;
            this.textbox_Total_Price.Text = "0";
            this.textbox_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // combobox_Switch_Table
            // 
            this.combobox_Switch_Table.FormattingEnabled = true;
            this.combobox_Switch_Table.Location = new System.Drawing.Point(3, 28);
            this.combobox_Switch_Table.Name = "combobox_Switch_Table";
            this.combobox_Switch_Table.Size = new System.Drawing.Size(75, 21);
            this.combobox_Switch_Table.TabIndex = 6;
            // 
            // button_Switch_Table
            // 
            this.button_Switch_Table.Location = new System.Drawing.Point(3, 3);
            this.button_Switch_Table.Name = "button_Switch_Table";
            this.button_Switch_Table.Size = new System.Drawing.Size(75, 26);
            this.button_Switch_Table.TabIndex = 5;
            this.button_Switch_Table.Text = "Chuyển bàn";
            this.button_Switch_Table.UseVisualStyleBackColor = true;
            this.button_Switch_Table.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // button_Check_Out
            // 
            this.button_Check_Out.Location = new System.Drawing.Point(260, 3);
            this.button_Check_Out.Name = "button_Check_Out";
            this.button_Check_Out.Size = new System.Drawing.Size(75, 46);
            this.button_Check_Out.TabIndex = 3;
            this.button_Check_Out.Text = "Thanh toán";
            this.button_Check_Out.UseVisualStyleBackColor = true;
            this.button_Check_Out.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numeric_Food_Count);
            this.panel4.Controls.Add(this.button_Add_Food);
            this.panel4.Controls.Add(this.combobox_Food);
            this.panel4.Controls.Add(this.combobox_Category);
            this.panel4.Location = new System.Drawing.Point(447, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(338, 52);
            this.panel4.TabIndex = 4;
            // 
            // numeric_Food_Count
            // 
            this.numeric_Food_Count.Location = new System.Drawing.Point(296, 19);
            this.numeric_Food_Count.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_Food_Count.Name = "numeric_Food_Count";
            this.numeric_Food_Count.Size = new System.Drawing.Size(39, 20);
            this.numeric_Food_Count.TabIndex = 3;
            this.numeric_Food_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Add_Food
            // 
            this.button_Add_Food.Location = new System.Drawing.Point(214, 3);
            this.button_Add_Food.Name = "button_Add_Food";
            this.button_Add_Food.Size = new System.Drawing.Size(75, 46);
            this.button_Add_Food.TabIndex = 2;
            this.button_Add_Food.Text = "Thêm món";
            this.button_Add_Food.UseVisualStyleBackColor = true;
            this.button_Add_Food.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // combobox_Food
            // 
            this.combobox_Food.FormattingEnabled = true;
            this.combobox_Food.Location = new System.Drawing.Point(3, 28);
            this.combobox_Food.Name = "combobox_Food";
            this.combobox_Food.Size = new System.Drawing.Size(205, 21);
            this.combobox_Food.TabIndex = 1;
            // 
            // combobox_Category
            // 
            this.combobox_Category.FormattingEnabled = true;
            this.combobox_Category.Location = new System.Drawing.Point(3, 3);
            this.combobox_Category.Name = "combobox_Category";
            this.combobox_Category.Size = new System.Drawing.Size(205, 21);
            this.combobox_Category.TabIndex = 0;
            this.combobox_Category.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // flowlayout_Table
            // 
            this.flowlayout_Table.AutoScroll = true;
            this.flowlayout_Table.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowlayout_Table.Location = new System.Drawing.Point(12, 30);
            this.flowlayout_Table.Name = "flowlayout_Table";
            this.flowlayout_Table.Size = new System.Drawing.Size(429, 428);
            this.flowlayout_Table.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.flowlayout_Table);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Food Court System - The Canteen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Food_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listview_Bill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numeric_Food_Count;
        private System.Windows.Forms.Button button_Add_Food;
        private System.Windows.Forms.ComboBox combobox_Food;
        private System.Windows.Forms.ComboBox combobox_Category;
        private System.Windows.Forms.ComboBox combobox_Switch_Table;
        private System.Windows.Forms.Button button_Switch_Table;
        private System.Windows.Forms.Button button_Check_Out;
        private System.Windows.Forms.FlowLayoutPanel flowlayout_Table;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textbox_Total_Price;
        private System.Windows.Forms.Label label1;
    }
}