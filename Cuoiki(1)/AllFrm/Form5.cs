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
    public partial class Form5 : Form
    {
        private Model1 db = new Model1();

        private int vehicleId;
        private string userRole;

        public Form5(int selectedVehicleId, string userRole)
        {
            InitializeComponent();
            vehicleId = selectedVehicleId;
            this.userRole = userRole;
            LoadVehicleDetails();
            SetupFormBasedOnRole();
        }

        private void SetupFormBasedOnRole()
        {
            if (userRole == "nhanvien")
            {
                // Giới hạn quyền cho nhân viên
                btnDelete.Visible = false;
                
            }
        }

            private void LoadVehicleDetails()
        {
            var vehicle = db.Xes.SingleOrDefault(v => v.MaXe == vehicleId);

            if (vehicle != null)
            {
                txtMaXe.Text = vehicle.MaXe.ToString();
                txtTenXe.Text = vehicle.TenXe;
                txtGiaThanh.Text = vehicle.GiaThanh.HasValue ? vehicle.GiaThanh.Value.ToString("N0") : "N/A";
                txtPhanKhoi.Text = vehicle.PhanKhoi;
                txtLoaiXe.Text = vehicle.LoaiXe;
                txtHangXe.Text = vehicle.HangXe;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin xe.");
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            LoadVehicleDetails();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát ", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userRole == "KhachHang")
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin và Nhân Viên.");
            }
            else
            {
                MessageBox.Show("Xóa Thất Bại.");
            }
            using (var context = new Model1())
            {
                try
                {
                    var vehicle = context.Xes.SingleOrDefault(v => v.MaXe == vehicleId);
                    if (vehicle != null)
                    {
                        context.Xes.Remove(vehicle);
                        context.SaveChanges();
                        MessageBox.Show("Xóa xe thành công!");
                        this.Close(); // Đóng Form sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy xe để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new Model1())
            {
                try
                {
                    var vehicle = context.Xes.SingleOrDefault(v => v.MaXe == vehicleId);
                    if (vehicle != null)
                    {
                        vehicle.TenXe = txtTenXe.Text;
                        vehicle.LoaiXe = txtLoaiXe.Text;
                        vehicle.GiaThanh = decimal.Parse(txtGiaThanh.Text);
                        vehicle.PhanKhoi = txtPhanKhoi.Text;
                        vehicle.HangXe = txtHangXe.Text;

                        context.SaveChanges();
                        MessageBox.Show("Lưu thông tin xe thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy xe để lưu.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
        }
    }
}
