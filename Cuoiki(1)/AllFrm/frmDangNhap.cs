using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuoiki_1_
{
    public partial class frmDangNhap : Form
    {
        private Model1 db = new Model1();
        private string khachhangRole;

        public frmDangNhap()
        {
            InitializeComponent();
        }
            public frmDangNhap(string role)
            {
            InitializeComponent();
            khachhangRole = role;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (user.Role == "admin")
                {
                    // Admin có thể mở Form 2, Form 3, hoặc Form 4
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                else if (user.Role == "nhanvien")
                {
                    // Nhân viên chỉ có thể mở Form 2
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                else if (user.Role == "KhachHang")
                {
                    // Nhân viên chỉ có thể mở Form 2
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                Form6 form6 = new Form6();
                form6.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            var user = db.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (user.Role == "admin")
                {
                    // Admin có thể mở Form 2, Form 3, hoặc Form 4
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                else if (user.Role == "nhanvien")
                {
                    // Nhân viên chỉ có thể mở Form 2
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                else if (user.Role == "KhachHang")
                {
                    // Nhân viên chỉ có thể mở Form 2
                    frmXe form2 = new frmXe(user.Role);
                    form2.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Form6 form6 = new Form6();
                form6.ShowDialog();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
