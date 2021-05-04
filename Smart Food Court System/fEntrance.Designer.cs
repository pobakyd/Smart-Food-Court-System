namespace SmartFoodCourtSystem
{
    partial class fEntrance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEntrance));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Thuc_Khach = new System.Windows.Forms.Button();
            this.label_Chao_Mung = new System.Windows.Forms.Label();
            this.button_Nhan_Vien = new System.Windows.Forms.Button();
            this.button_Quan_Li = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 43);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(592, 234);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button_Thuc_Khach
            // 
            this.button_Thuc_Khach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Thuc_Khach.BackgroundImage")));
            this.button_Thuc_Khach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Thuc_Khach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Thuc_Khach.Location = new System.Drawing.Point(12, 283);
            this.button_Thuc_Khach.Name = "button_Thuc_Khach";
            this.button_Thuc_Khach.Size = new System.Drawing.Size(96, 83);
            this.button_Thuc_Khach.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_Thuc_Khach, "Thực khách");
            this.button_Thuc_Khach.UseVisualStyleBackColor = true;
            this.button_Thuc_Khach.Click += new System.EventHandler(this.button_Thuc_Khach_Click);
            // 
            // label_Chao_Mung
            // 
            this.label_Chao_Mung.AutoSize = true;
            this.label_Chao_Mung.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chao_Mung.ForeColor = System.Drawing.Color.IndianRed;
            this.label_Chao_Mung.Location = new System.Drawing.Point(170, 9);
            this.label_Chao_Mung.Name = "label_Chao_Mung";
            this.label_Chao_Mung.Size = new System.Drawing.Size(0, 25);
            this.label_Chao_Mung.TabIndex = 4;
            // 
            // button_Nhan_Vien
            // 
            this.button_Nhan_Vien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Nhan_Vien.BackgroundImage")));
            this.button_Nhan_Vien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Nhan_Vien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Nhan_Vien.Location = new System.Drawing.Point(275, 283);
            this.button_Nhan_Vien.Name = "button_Nhan_Vien";
            this.button_Nhan_Vien.Size = new System.Drawing.Size(96, 83);
            this.button_Nhan_Vien.TabIndex = 5;
            this.toolTip2.SetToolTip(this.button_Nhan_Vien, "Nhân viên");
            this.button_Nhan_Vien.UseVisualStyleBackColor = true;
            this.button_Nhan_Vien.Click += new System.EventHandler(this.button_Nhan_Vien_Click);
            // 
            // button_Quan_Li
            // 
            this.button_Quan_Li.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Quan_Li.BackgroundImage")));
            this.button_Quan_Li.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Quan_Li.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Quan_Li.Location = new System.Drawing.Point(508, 283);
            this.button_Quan_Li.Name = "button_Quan_Li";
            this.button_Quan_Li.Size = new System.Drawing.Size(96, 83);
            this.button_Quan_Li.TabIndex = 6;
            this.toolTip3.SetToolTip(this.button_Quan_Li, "Quản lí");
            this.button_Quan_Li.UseVisualStyleBackColor = true;
            this.button_Quan_Li.Click += new System.EventHandler(this.button_Quan_Li_Click);
            // 
            // fEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 380);
            this.Controls.Add(this.button_Quan_Li);
            this.Controls.Add(this.button_Nhan_Vien);
            this.Controls.Add(this.label_Chao_Mung);
            this.Controls.Add(this.button_Thuc_Khach);
            this.Controls.Add(this.pictureBox);
            this.Name = "fEntrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Food Court System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Thuc_Khach;
        private System.Windows.Forms.Label label_Chao_Mung;
        private System.Windows.Forms.Button button_Nhan_Vien;
        private System.Windows.Forms.Button button_Quan_Li;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}