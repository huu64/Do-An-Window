using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cuoiki_1_
{
    public partial class frmXe : Form
    {
        private Model1 db = new Model1();
      
        private string userRole;
        private int selectedVehicleId;
        private string connectionString = "Model1"; 
        private int userID; 

        public frmXe(int selectedVehicleId, string userRole)
        {
            InitializeComponent();         
            SetAdminControls();
        }

        public frmXe(string role)
        {
            InitializeComponent();
            userRole = role;
            SetAdminControls();
            LoadData();
            listViewXe.SelectedIndexChanged += ListViewXe_SelectedIndexChanged;
        }
        public frmXe()
        {
            SetAdminControls();
            InitializeComponent();
            LoadData();
            listViewXe.SelectedIndexChanged += ListViewXe_SelectedIndexChanged;
        }

       

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(userRole == "admin")
            {
                FormQuanLyXe form4 = new FormQuanLyXe();
                form4.Show();
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Chức năng này chỉ dành cho Admin.");
            }
        }

        private void SetAdminControls()
        {

            if (btnQuanLyXe != null && userRole != "admin")
            {
                btnQuanLyXe.Visible = false;
            }
        }

        private void LoadData()
        {
            // Load data from the database into the ListView
            var vehicles = db.Xes.ToList(); // Assuming you have a DbSet<Xe> named Xes in Model2

            foreach (var vehicle in vehicles)
            {
                ListViewItem item = new ListViewItem(vehicle.MaXe.ToString());
                item.SubItems.Add(vehicle.TenXe);
                item.SubItems.Add(vehicle.LoaiXe);
                item.SubItems.Add(vehicle.GiaThanh.HasValue ? vehicle.GiaThanh.Value.ToString("N0") : "N/A");
                item.SubItems.Add(vehicle.PhanKhoi);
                item.SubItems.Add(vehicle.HangXe);
                listViewXe.Items.Add(item);
            }
        }

        private void ListViewXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewXe.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewXe.SelectedItems[0];

             
                txtMaXe.Text = selectedItem.SubItems[0].Text;
                txtTenXe.Text = selectedItem.SubItems[1].Text;
                cbbLoaiXe1.Text = selectedItem.SubItems[2].Text;
                txtGiaThanh.Text = selectedItem.SubItems[3].Text;
                txtPhanKhoi.Text = selectedItem.SubItems[4].Text;
                cbbHangXe1.Text = selectedItem.SubItems[5].Text;
            }
        }


        private void btnTimXe_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewXe.SelectedItems.Count > 0)
                {
                    int selectedVehicleId = int.Parse(listViewXe.SelectedItems[0].SubItems[0].Text);
                    Form5 form5 = new Form5(selectedVehicleId, userRole);
                    form5.Show();
                }
                else
                {
                    // Show notification if no item is selected
                    MessageBox.Show("Bạn chưa chọn sản phẩm trong danh sách !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Perform the search based on the filter criteria
                    var filteredVehicles = db.Xes.Where(v =>
                        (txtMaXe.Text == "" || v.MaXe.ToString().Contains(txtMaXe.Text)) &&
                        (txtTenXe.Text == "" || v.TenXe.Contains(txtTenXe.Text)) &&
                        (cbbLoaiXe1.SelectedItem == null || v.LoaiXe == cbbLoaiXe1.SelectedItem.ToString()) &&
                        (cbbHangXe1.SelectedItem == null || v.HangXe == cbbHangXe1.SelectedItem.ToString())
                    ).ToList();

                    listViewXe.Items.Clear();
                    foreach (var vehicle in filteredVehicles)
                    {
                        ListViewItem item = new ListViewItem(vehicle.MaXe.ToString());
                        item.SubItems.Add(vehicle.TenXe);
                        item.SubItems.Add(vehicle.LoaiXe);
                        item.SubItems.Add(vehicle.GiaThanh.HasValue ? vehicle.GiaThanh.Value.ToString("N0") : "N/A");
                        item.SubItems.Add(vehicle.PhanKhoi);
                        item.SubItems.Add(vehicle.HangXe);
                        listViewXe.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // If the specific error is encountered, show a message box with a detailed error message
                if (ex.Message.Contains("Unable to create a null constant value of type 'System.Object'"))
                {
                    MessageBox.Show(" Vui lòng chọn một sản phẩm bất kì !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // General error handling
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void listViewXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

