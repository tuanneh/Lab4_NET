using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanNet
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ẩn form Menu
            this.Hide();

            // Hiển thị form NhanVien
            formNguoiDung formNguoiDung = new formNguoiDung();
            formNguoiDung.FormClosed += (s, args) => this.Show(); // Hiển thị lại form Menu khi form NhanVien đóng
            formNguoiDung.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TTMay_Click(object sender, EventArgs e)
        {
            // Ẩn form Menu
            this.Hide();

            // Hiển thị form PhongBan
            formThongTinMay formThongTinMay = new formThongTinMay();
            formThongTinMay.FormClosed += (s, args) => this.Show(); // Hiển thị lại form Menu khi form PhongBan đóng
            formThongTinMay.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "Đồng ý"
            if (result == DialogResult.Yes)
            {
                // Đóng ứng dụng
                Application.Exit();
            }
        }
    }
}
