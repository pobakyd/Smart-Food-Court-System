namespace SmartFoodCourtSystem
{
    partial class fOrderFood
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
            this.flowLayoutPanel_Food = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_User_Mess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Order = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Add_Cart = new System.Windows.Forms.Button();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.button_Add_Food = new System.Windows.Forms.Button();
            this.button_Delete_Food = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Total_Price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Food
            // 
            this.flowLayoutPanel_Food.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel_Food.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel_Food.Name = "flowLayoutPanel_Food";
            this.flowLayoutPanel_Food.Size = new System.Drawing.Size(416, 235);
            this.flowLayoutPanel_Food.TabIndex = 0;
            // 
            // textBox_User_Mess
            // 
            this.textBox_User_Mess.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_User_Mess.Location = new System.Drawing.Point(13, 296);
            this.textBox_User_Mess.Multiline = true;
            this.textBox_User_Mess.Name = "textBox_User_Mess";
            this.textBox_User_Mess.Size = new System.Drawing.Size(416, 158);
            this.textBox_User_Mess.TabIndex = 10;
            this.textBox_User_Mess.Text = "Hãy nhập lời nhắn của bạn để chúng tôi phục vụ tốt hơn";
            this.textBox_User_Mess.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_User_Mess_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lời nhắn";
            // 
            // listView_Order
            // 
            this.listView_Order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView_Order.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_Order.FullRowSelect = true;
            this.listView_Order.GridLines = true;
            this.listView_Order.HideSelection = false;
            this.listView_Order.Location = new System.Drawing.Point(436, 85);
            this.listView_Order.Name = "listView_Order";
            this.listView_Order.Size = new System.Drawing.Size(299, 275);
            this.listView_Order.TabIndex = 3;
            this.listView_Order.UseCompatibleStateImageBehavior = false;
            this.listView_Order.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // button_Add_Cart
            // 
            this.button_Add_Cart.Location = new System.Drawing.Point(438, 414);
            this.button_Add_Cart.Name = "button_Add_Cart";
            this.button_Add_Cart.Size = new System.Drawing.Size(118, 40);
            this.button_Add_Cart.TabIndex = 4;
            this.button_Add_Cart.Text = "Thêm vào giỏ hàng";
            this.button_Add_Cart.UseVisualStyleBackColor = true;
            this.button_Add_Cart.Click += new System.EventHandler(this.button_Add_Cart_Click);
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Location = new System.Drawing.Point(436, 36);
            this.numericUpDown_Amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Amount.TabIndex = 5;
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Add_Food
            // 
            this.button_Add_Food.Location = new System.Drawing.Point(637, 10);
            this.button_Add_Food.Name = "button_Add_Food";
            this.button_Add_Food.Size = new System.Drawing.Size(98, 23);
            this.button_Add_Food.TabIndex = 6;
            this.button_Add_Food.Text = "Thêm món";
            this.button_Add_Food.UseVisualStyleBackColor = true;
            this.button_Add_Food.Click += new System.EventHandler(this.button_Add_Food_Click);
            // 
            // button_Delete_Food
            // 
            this.button_Delete_Food.Location = new System.Drawing.Point(637, 51);
            this.button_Delete_Food.Name = "button_Delete_Food";
            this.button_Delete_Food.Size = new System.Drawing.Size(98, 23);
            this.button_Delete_Food.TabIndex = 7;
            this.button_Delete_Food.Text = "Xóa món";
            this.button_Delete_Food.UseVisualStyleBackColor = true;
            this.button_Delete_Food.Click += new System.EventHandler(this.button_Delete_Food_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(637, 415);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(98, 39);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Quay lại";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hãy nhấp đúp vào hình ảnh để xem thông tin chi tiết về món ăn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng món:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(474, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng tiền:";
            // 
            // textBox_Total_Price
            // 
            this.textBox_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Total_Price.ForeColor = System.Drawing.Color.Red;
            this.textBox_Total_Price.Location = new System.Drawing.Point(553, 376);
            this.textBox_Total_Price.Name = "textBox_Total_Price";
            this.textBox_Total_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Total_Price.Size = new System.Drawing.Size(182, 24);
            this.textBox_Total_Price.TabIndex = 14;
            this.textBox_Total_Price.Text = "0 VNĐ";
            this.textBox_Total_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fOrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 466);
            this.Controls.Add(this.textBox_Total_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Delete_Food);
            this.Controls.Add(this.button_Add_Food);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.button_Add_Cart);
            this.Controls.Add(this.listView_Order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_User_Mess);
            this.Controls.Add(this.flowLayoutPanel_Food);
            this.Name = "fOrderFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Food Court System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fOrderFood_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Food;
        private System.Windows.Forms.TextBox textBox_User_Mess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Order;
        private System.Windows.Forms.Button button_Add_Cart;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
        private System.Windows.Forms.Button button_Add_Food;
        private System.Windows.Forms.Button button_Delete_Food;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Total_Price;
    }
}