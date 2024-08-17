using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuoiki_1_
{
    public partial class Form8 : Form
    {
        private Model1 db = new Model1();
        private string connectionString = "data source=DESKTOP-JPQ3R1G\\SQLEXPRESS;initial catalog=quanlyxemay;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
        private string userRole;

        public Form8(string role)
        {
            InitializeComponent();
            userRole = role;
        }
        public Form8()
        {
            InitializeComponent();
            userRole = userRole;
            LoadCustomerData();
            SetRoleBasedAccess();
        }

        private void LoadCustomerData()
        {
            var customers = db.KhachHangs.ToList();
            cbbKhachHang.DataSource = customers;
            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "MaKhachHang";
        }

        



        private void SetRoleBasedAccess()
        {
            if (userRole == "KhacHang")
            {
                dgvLichSuGiaoDich.Visible = false;
                dgvBaoHanh.Visible = true;
            }
            else if (userRole == "nhanvien")
            {
                dgvLichSuGiaoDich.Visible = true;
                dgvBaoHanh.Visible = false;
            }
            else if (userRole == "admin")
            {
                dgvLichSuGiaoDich.Visible = true;
                dgvBaoHanh.Visible = true;
            }
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            SetRoleBasedAccess();
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int customerId = (int)cbbKhachHang.SelectedValue;
                LoadCustomerInfo(customerId);
                LoadTransactionData(customerId);
                LoadTransactionHistory(customerId);
                LoadWarrantyData(customerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadCustomerInfo(int customerId)
        {
            var customer = db.KhachHangs.Find(customerId);
            if (customer != null)
            {
                txtTenKhachHang.Text = customer.TenKhachHang;
                txtDiaChi.Text = customer.DiaChi;
                txtSoDienThoai.Text = customer.SoDienThoai;
                txtEmail.Text = customer.Email;
            }
        }

        private void LoadTransactionData(int customerId)
        {
            try
            {
                var transactions = db.GiaoDiches
                    .Where(g => g.MaKhachHang == customerId)
                    .Select(g => new
                    {
                        g.MaGiaoDich,
                        g.MaXe,
                        g.NgayGiaoDich,
                        g.GiaGiaoDich
                    })
                    .ToList();
                dgvGiaoDich.DataSource = transactions;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Lỗi chuyển đổi kiểu dữ liệu: " + ex.Message);
            }
        }

        private void LoadTransactionHistory(int customerId)
        {
            try
            {
                var transactionHistory = db.LichSuGiaoDiches
                    .Join(db.GiaoDiches, ls => ls.MaGiaoDich, g => g.MaGiaoDich, (ls, g) => new { ls, g })
                    .Where(x => x.g.MaKhachHang == customerId)
                    .Select(x => new
                    {
                        x.ls.MaGiaoDich,
                        x.ls.MaXe,
                        x.ls.MaUser,
                        x.ls.LoaiGiaoDich,
                        x.ls.ThoiGian
                    })
                    .ToList();
                dgvLichSuGiaoDich.DataSource = transactionHistory;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Lỗi chuyển đổi kiểu dữ liệu: " + ex.Message);
            }
        }

        private void LoadWarrantyData(int customerId)
        {
            try
            {
                var warranties = db.BaoHanhs
                    .Join(db.GiaoDiches, bh => bh.MaXe, g => g.MaXe, (bh, g) => new { bh, g })
                    .Where(x => x.g.MaKhachHang == customerId)
                    .Select(x => new
                    {
                        x.bh.MaBaoHanh,
                        x.bh.MaXe,
                        x.bh.NgayMua,
                        x.bh.ThoiHanBaoHanh
                    })
                    .ToList();
                dgvBaoHanh.DataSource = warranties;
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Lỗi chuyển đổi kiểu dữ liệu: " + ex.Message);
            }
        }

            private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá trị được chọn trong ComboBox
                if (cbbKhachHang.SelectedValue != null)
                {
                    int customerId;
                    if (int.TryParse(cbbKhachHang.SelectedValue.ToString(), out customerId))
                    {
                        LoadCustomerInfo(customerId);
                        LoadTransactionData(customerId);
                        LoadTransactionHistory(customerId);
                        LoadWarrantyData(customerId);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị được chọn không phải là mã khách hàng hợp lệ.");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có khách hàng nào được chọn.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát ", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvGiaoDich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLichSuGiaoDich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
