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

namespace QuanNet
{
    public partial class formNguoiDung : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string connectionString = "Data Source=MSI;Initial Catalog=QuanNet;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From ThongTinNguoiDung";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            data_ThongTinNguoiDung.DataSource = table;
        }


        public formNguoiDung()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void formNguoiDung_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BTN_TraCuuTK_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTaiKhoan.Text.Trim();

            string query = "SELECT * FROM ThongTinNguoiDung WHERE TaiKhoan = @SearchTerm";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    data_ThongTinNguoiDung.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BTN_XoaTK_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete From ThongTinNguoiDung Where TaiKhoan = @TaiKhoan";
            command.Parameters.AddWithValue("@TaiKhoan", txtTaiKhoan.Text);
            command.ExecuteNonQuery();
            loaddata();

            MessageBox.Show("Xóa Tài Khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại (PhongBan)
        }
    }
}
