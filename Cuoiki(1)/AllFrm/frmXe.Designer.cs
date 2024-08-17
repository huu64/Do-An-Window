namespace Cuoiki_1_
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnTimXe = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnQuanLyXe = new System.Windows.Forms.Button();
            this.listViewXe = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbHangXe1 = new System.Windows.Forms.ComboBox();
            this.txtGiaThanh = new System.Windows.Forms.TextBox();
            this.txtPhanKhoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLoaiXe1 = new System.Windows.Forms.ComboBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTimXe
            // 
            this.btnTimXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTimXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimXe.Location = new System.Drawing.Point(628, 375);
            this.btnTimXe.Name = "btnTimXe";
            this.btnTimXe.Size = new System.Drawing.Size(187, 58);
            this.btnTimXe.TabIndex = 2;
            this.btnTimXe.Text = "Xem Chi Tiết";
            this.btnTimXe.UseVisualStyleBackColor = false;
            this.btnTimXe.Click += new System.EventHandler(this.btnTimXe_Click);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "winnerx-png.png");
            // 
            // btnQuanLyXe
            // 
            this.btnQuanLyXe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyXe.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyXe.Location = new System.Drawing.Point(628, 458);
            this.btnQuanLyXe.Name = "btnQuanLyXe";
            this.btnQuanLyXe.Size = new System.Drawing.Size(187, 76);
            this.btnQuanLyXe.TabIndex = 5;
            this.btnQuanLyXe.Text = "Quản Lý Cửa Hàng";
            this.btnQuanLyXe.UseVisualStyleBackColor = false;
            this.btnQuanLyXe.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // listViewXe
            // 
            this.listViewXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewXe.FullRowSelect = true;
            this.listViewXe.GridLines = true;
            this.listViewXe.HideSelection = false;
            this.listViewXe.Location = new System.Drawing.Point(-9, 12);
            this.listViewXe.Name = "listViewXe";
            this.listViewXe.Size = new System.Drawing.Size(1191, 236);
            this.listViewXe.TabIndex = 22;
            this.listViewXe.UseCompatibleStateImageBehavior = false;
            this.listViewXe.View = System.Windows.Forms.View.Details;
            this.listViewXe.SelectedIndexChanged += new System.EventHandler(this.listViewXe_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã Xe";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Xe";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Loại Xe";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 180;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giá Thành";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 180;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Phân Khối";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 180;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Hãng Xe";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 150;
            // 
            // cbbHangXe1
            // 
            this.cbbHangXe1.FormattingEnabled = true;
            this.cbbHangXe1.Location = new System.Drawing.Point(417, 489);
            this.cbbHangXe1.Name = "cbbHangXe1";
            this.cbbHangXe1.Size = new System.Drawing.Size(121, 24);
            this.cbbHangXe1.TabIndex = 28;
            // 
            // txtGiaThanh
            // 
            this.txtGiaThanh.Location = new System.Drawing.Point(417, 375);
            this.txtGiaThanh.Name = "txtGiaThanh";
            this.txtGiaThanh.Size = new System.Drawing.Size(121, 22);
            this.txtGiaThanh.TabIndex = 26;
            // 
            // txtPhanKhoi
            // 
            this.txtPhanKhoi.Location = new System.Drawing.Point(417, 426);
            this.txtPhanKhoi.Name = "txtPhanKhoi";
            this.txtPhanKhoi.Size = new System.Drawing.Size(121, 22);
            this.txtPhanKhoi.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hãng Xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phân Khối";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá Thành";
            // 
            // cbbLoaiXe1
            // 
            this.cbbLoaiXe1.FormattingEnabled = true;
            this.cbbLoaiXe1.Location = new System.Drawing.Point(104, 486);
            this.cbbLoaiXe1.Name = "cbbLoaiXe1";
            this.cbbLoaiXe1.Size = new System.Drawing.Size(121, 24);
            this.cbbLoaiXe1.TabIndex = 40;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(104, 426);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(121, 22);
            this.txtTenXe.TabIndex = 38;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(104, 381);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(121, 22);
            this.txtMaXe.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Loại Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tên Xe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Mã Xe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cuoiki_1_.Properties.Resources.winnerx_png;
            this.pictureBox1.Location = new System.Drawing.Point(945, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1203, 548);
            this.Controls.Add(this.cbbLoaiXe1);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbHangXe1);
            this.Controls.Add(this.txtGiaThanh);
            this.Controls.Add(this.txtPhanKhoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewXe);
            this.Controls.Add(this.btnQuanLyXe);
            this.Controls.Add(this.btnTimXe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmXe";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btnTimXe;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuanLyXe;
        private System.Windows.Forms.ListView listViewXe;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cbbHangXe1;
        private System.Windows.Forms.TextBox txtGiaThanh;
        private System.Windows.Forms.TextBox txtPhanKhoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLoaiXe1;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}