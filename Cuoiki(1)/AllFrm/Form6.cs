using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuoiki_1_
{
    public partial class Form6 : Form
    {
        private Model1 db = new Model1();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu và mật khẩu xác nhận có khớp nhau không
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không khớp!");
                return;
            }

            // Chuỗi kết nối tới SQL
            string connectionString = "data source=DESKTOP-JPQ3R1G\\SQLEXPRESS;initial catalog=quanlyxemay;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                    string queryCheckUser = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    SqlCommand cmdCheckUser = new SqlCommand(queryCheckUser, conn);
                    cmdCheckUser.Parameters.AddWithValue("@Username", txtUsername.Text);

                    int userCount = (int)cmdCheckUser.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                    }
                    else
                    {
                        // Thêm người dùng với role "KhachHang"
                        string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", "KhachHang");

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công!");
                        this.Close(); 
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
            DialogResult result = MessageBox.Show("Bạn có chắc không muốn tiếp tục đăng kí và thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
