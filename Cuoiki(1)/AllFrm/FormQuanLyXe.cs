using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Cuoiki_1_
{
    public partial class FormQuanLyXe : Form
    {
        private string connectionString = "data source=DESKTOP-JPQ3R1G\\SQLEXPRESS;initial catalog=quanlyxemay;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework"; // Chuỗi kết nối của bạn
        private int selectedXeID = 0;
        public FormQuanLyXe()
        {
            InitializeComponent();
            LoadXeData();
            LoadLoaiXeComboBox();
            LoadHangXeComboBox();
        }

        // Tải dữ liệu xe vào ListView
        private void LoadXeData()
        {
            listViewXe.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaXe, TenXe, LoaiXe, GiaThanh, PhanKhoi, HangXe FROM Xe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaXe"].ToString());
                        item.SubItems.Add(reader["TenXe"].ToString());
                        item.SubItems.Add(reader["LoaiXe"].ToString());
                        item.SubItems.Add(reader["GiaThanh"].ToString());
                        item.SubItems.Add(reader["PhanKhoi"].ToString());
                        item.SubItems.Add(reader["HangXe"].ToString());
                        listViewXe.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Tải dữ liệu vào ComboBox Loại Xe
        private void LoadLoaiXeComboBox()
        {
            comboBoxLoaiXe.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT LoaiXe FROM Xe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxLoaiXe.Items.Add(reader["LoaiXe"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        // Tải dữ liệu vào ComboBox Hãng Xe
        private void LoadHangXeComboBox()
        {
            comboBoxHangXe.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT DISTINCT HangXe FROM Xe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxHangXe.Items.Add(reader["HangXe"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát mà không lưu thay đổi?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        
    }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(txtTenXe.Text) || string.IsNullOrWhiteSpace(comboBoxLoaiXe.Text) ||
                string.IsNullOrWhiteSpace(txtGiaThanh.Text) || string.IsNullOrWhiteSpace(txtPhanKhoi.Text) ||
                string.IsNullOrWhiteSpace(comboBoxHangXe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Kết nối tới cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Câu lệnh SQL để thêm xe mới, bỏ qua MaXe vì nó được tự động tăng
                string sql = "INSERT INTO Xe (TenXe, LoaiXe, GiaThanh, PhanKhoi, HangXe) " +
                             "VALUES (@TenXe, @LoaiXe, @GiaThanh, @PhanKhoi, @HangXe)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Gán giá trị cho các tham số
                    cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@LoaiXe", comboBoxLoaiXe.Text);
                    cmd.Parameters.AddWithValue("@GiaThanh", decimal.Parse(txtGiaThanh.Text));
                    cmd.Parameters.AddWithValue("@PhanKhoi", txtPhanKhoi.Text);
                    cmd.Parameters.AddWithValue("@HangXe", comboBoxHangXe.Text);

                    // Thực thi lệnh
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm xe mới thành công!");

                // Làm mới lại dữ liệu sau khi thêm
                LoadXeData();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtTenXe.Text) ||
                comboBoxLoaiXe.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtGiaThanh.Text) ||
                string.IsNullOrEmpty(txtPhanKhoi.Text) ||
                comboBoxHangXe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin xe máy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedXeID == 0)
            {
                MessageBox.Show("Vui lòng chọn một xe để xóa.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Xe WHERE MaXe = @MaXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaXe", selectedXeID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa xe thành công!");
                    LoadXeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedXeID == 0)
            {
                MessageBox.Show("Vui lòng chọn một xe để sửa.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Xe SET TenXe = @TenXe, LoaiXe = @LoaiXe, GiaThanh = @GiaThanh, PhanKhoi = @PhanKhoi, HangXe = @HangXe WHERE MaXe = @MaXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaXe", selectedXeID);
                    cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@LoaiXe", comboBoxLoaiXe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GiaThanh", decimal.Parse(txtGiaThanh.Text));
                    cmd.Parameters.AddWithValue("@PhanKhoi", txtPhanKhoi.Text);
                    cmd.Parameters.AddWithValue("@HangXe", comboBoxHangXe.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thông tin xe thành công!");
                    LoadXeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedXeID == 0)
            {
                MessageBox.Show("Vui lòng chọn một xe để lưu thay đổi.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Xe SET TenXe = @TenXe, LoaiXe = @LoaiXe, GiaThanh = @GiaThanh, PhanKhoi = @PhanKhoi, HangXe = @HangXe WHERE MaXe = @MaXe";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaXe", selectedXeID);
                    cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                    cmd.Parameters.AddWithValue("@LoaiXe", comboBoxLoaiXe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GiaThanh", decimal.Parse(txtGiaThanh.Text));
                    cmd.Parameters.AddWithValue("@PhanKhoi", txtPhanKhoi.Text);
                    cmd.Parameters.AddWithValue("@HangXe", comboBoxHangXe.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thông tin xe thành công!");
                    LoadXeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        // Sự kiện khi chọn một xe trong ListView
        private void listViewXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewXe.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewXe.SelectedItems[0];
                selectedXeID = int.Parse(item.SubItems[0].Text);
                txtTenXe.Text = item.SubItems[1].Text;
                comboBoxLoaiXe.SelectedItem = item.SubItems[2].Text;
                txtGiaThanh.Text = item.SubItems[3].Text;
                txtPhanKhoi.Text = item.SubItems[4].Text;
                comboBoxHangXe.SelectedItem = item.SubItems[5].Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listViewXe.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaXe, TenXe, LoaiXe, GiaThanh, PhanKhoi, HangXe FROM Xe WHERE 1=1";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(txtMaXe.Text))
                    {
                        query += " AND MaXe = @MaXe";
                        cmd.Parameters.AddWithValue("@MaXe", txtMaXe.Text);
                    }
                    if (!string.IsNullOrEmpty(txtTenXe.Text))
                    {
                        query += " AND TenXe LIKE '%' + @TenXe + '%'";
                        cmd.Parameters.AddWithValue("@TenXe", txtTenXe.Text);
                    }
                    if (comboBoxLoaiXe.SelectedIndex != -1)
                    {
                        query += " AND LoaiXe = @LoaiXe";
                        cmd.Parameters.AddWithValue("@LoaiXe", comboBoxLoaiXe.SelectedItem?.ToString());
                    }
                    if (!string.IsNullOrEmpty(txtGiaThanh.Text))
                    {
                        query += " AND GiaThanh = @GiaThanh";
                        cmd.Parameters.AddWithValue("@GiaThanh", decimal.Parse(txtGiaThanh.Text));
                    }
                    if (!string.IsNullOrEmpty(txtPhanKhoi.Text))
                    {
                        query += " AND PhanKhoi LIKE '%' + @PhanKhoi + '%'";
                        cmd.Parameters.AddWithValue("@PhanKhoi", txtPhanKhoi.Text);
                    }
                    if (comboBoxHangXe.SelectedIndex != -1)
                    {
                        query += " AND HangXe = @HangXe";
                        cmd.Parameters.AddWithValue("@HangXe", comboBoxHangXe.SelectedItem?.ToString());
                    }

                    cmd.CommandText = query;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaXe"].ToString());
                        item.SubItems.Add(reader["TenXe"].ToString());
                        item.SubItems.Add(reader["LoaiXe"].ToString());
                        item.SubItems.Add(reader["GiaThanh"].ToString());
                        item.SubItems.Add(reader["PhanKhoi"].ToString());
                        item.SubItems.Add(reader["HangXe"].ToString());
                        listViewXe.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtTenXe.Clear();
            comboBoxLoaiXe.SelectedIndex = -1;
            txtGiaThanh.Clear();
            txtPhanKhoi.Clear();
            comboBoxHangXe.SelectedIndex = -1;
            selectedXeID = 0;
            LoadXeData(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh Sách Xe");
                        worksheet.Cells["A1"].Value = "Mã Xe";
                        worksheet.Cells["B1"].Value = "Tên Xe";
                        worksheet.Cells["C1"].Value = "Loại Xe";
                        worksheet.Cells["D1"].Value = "Giá Thành";
                        worksheet.Cells["E1"].Value = "Phân Khối";
                        worksheet.Cells["F1"].Value = "Hãng Xe";

                        int row = 2;
                        foreach (ListViewItem item in listViewXe.Items)
                        {
                            worksheet.Cells[row, 1].Value = item.SubItems[0].Text;
                            worksheet.Cells[row, 2].Value = item.SubItems[1].Text;
                            worksheet.Cells[row, 3].Value = item.SubItems[2].Text;
                            worksheet.Cells[row, 4].Value = item.SubItems[3].Text;
                            worksheet.Cells[row, 5].Value = item.SubItems[4].Text;
                            worksheet.Cells[row, 6].Value = item.SubItems[5].Text;
                            row++;
                        }

                        package.SaveAs(new FileInfo(sfd.FileName));
                        MessageBox.Show("Xuất báo cáo thành công!");
                    }
                }
            }
        }
    }
}
