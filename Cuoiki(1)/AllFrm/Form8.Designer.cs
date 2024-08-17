namespace Cuoiki_1_
{
    partial class Form8
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
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.dgvLichSuGiaoDich = new System.Windows.Forms.DataGridView();
            this.dgvBaoHanh = new System.Windows.Forms.DataGridView();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGiaoDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Location = new System.Drawing.Point(12, 107);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.RowHeadersWidth = 51;
            this.dgvGiaoDich.RowTemplate.Height = 24;
            this.dgvGiaoDich.Size = new System.Drawing.Size(762, 252);
            this.dgvGiaoDich.TabIndex = 0;
            this.dgvGiaoDich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellContentClick);
            // 
            // dgvLichSuGiaoDich
            // 
            this.dgvLichSuGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuGiaoDich.Location = new System.Drawing.Point(12, 365);
            this.dgvLichSuGiaoDich.Name = "dgvLichSuGiaoDich";
            this.dgvLichSuGiaoDich.RowHeadersWidth = 51;
            this.dgvLichSuGiaoDich.RowTemplate.Height = 24;
            this.dgvLichSuGiaoDich.Size = new System.Drawing.Size(762, 252);
            this.dgvLichSuGiaoDich.TabIndex = 1;
            this.dgvLichSuGiaoDich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSuGiaoDich_CellContentClick);
            // 
            // dgvBaoHanh
            // 
            this.dgvBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHanh.Location = new System.Drawing.Point(12, 635);
            this.dgvBaoHanh.Name = "dgvBaoHanh";
            this.dgvBaoHanh.RowHeadersWidth = 51;
            this.dgvBaoHanh.RowTemplate.Height = 24;
            this.dgvBaoHanh.Size = new System.Drawing.Size(762, 252);
            this.dgvBaoHanh.TabIndex = 2;
            this.dgvBaoHanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHanh_CellContentClick);
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(910, 378);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(212, 24);
            this.cbbKhachHang.TabIndex = 3;
            this.cbbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbbKhachHang_SelectedIndexChanged);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(910, 449);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(293, 22);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(910, 477);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(293, 22);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(910, 505);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(910, 533);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(293, 22);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(910, 598);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 34);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Lưu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Khách Hàng";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1105, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(489, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lịch Sử Mua Hàng";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1237, 912);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.dgvBaoHanh);
            this.Controls.Add(this.dgvLichSuGiaoDich);
            this.Controls.Add(this.dgvGiaoDich);
            this.Name = "Form8";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuGiaoDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.DataGridView dgvLichSuGiaoDich;
        private System.Windows.Forms.DataGridView dgvBaoHanh;
        private System.Windows.Forms.ComboBox cbbKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}