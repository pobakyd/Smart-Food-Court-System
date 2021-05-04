namespace SmartFoodCourtSystem
{
    partial class fUserCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUserCart));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Delete_Order = new System.Windows.Forms.Button();
            this.button_Order = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.dataGridView_Cart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Delete_Order
            // 
            this.button_Delete_Order.Location = new System.Drawing.Point(13, 322);
            this.button_Delete_Order.Name = "button_Delete_Order";
            this.button_Delete_Order.Size = new System.Drawing.Size(75, 50);
            this.button_Delete_Order.TabIndex = 2;
            this.button_Delete_Order.Text = "Xóa đơn hàng";
            this.button_Delete_Order.UseVisualStyleBackColor = true;
            this.button_Delete_Order.Click += new System.EventHandler(this.button_Delete_Order_Click);
            // 
            // button_Order
            // 
            this.button_Order.Location = new System.Drawing.Point(207, 322);
            this.button_Order.Name = "button_Order";
            this.button_Order.Size = new System.Drawing.Size(75, 50);
            this.button_Order.TabIndex = 3;
            this.button_Order.Text = "Đặt món";
            this.button_Order.UseVisualStyleBackColor = true;
            this.button_Order.Click += new System.EventHandler(this.button_Order_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(391, 322);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 50);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Quay lại";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // dataGridView_Cart
            // 
            this.dataGridView_Cart.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Cart.Location = new System.Drawing.Point(13, 135);
            this.dataGridView_Cart.Name = "dataGridView_Cart";
            this.dataGridView_Cart.Size = new System.Drawing.Size(453, 181);
            this.dataGridView_Cart.TabIndex = 5;
            // 
            // fUserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 386);
            this.Controls.Add(this.dataGridView_Cart);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Order);
            this.Controls.Add(this.button_Delete_Order);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fUserCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Delete_Order;
        private System.Windows.Forms.Button button_Order;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.DataGridView dataGridView_Cart;
    }
}