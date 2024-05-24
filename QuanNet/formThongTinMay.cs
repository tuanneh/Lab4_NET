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
    public partial class formThongTinMay : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string connectionString = "Data Source=MSI;Initial Catalog=QuanNet;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * From ThongTinMay";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            data_ThongTinMay.DataSource = table;
        }

        public formThongTinMay()
        {
            InitializeComponent();
        }

        private void formThongTinMay_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            loaddata();
        }

        private void BTN_TraCuu_Click(object sender, EventArgs e)
        {
            string searchTerm = textSoMay.Text.Trim();

            string query = "SELECT * FROM ThongTinMay WHERE SoMay = @SearchTerm";

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
                    data_ThongTinMay.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void BTN_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
