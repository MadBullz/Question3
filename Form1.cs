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

namespace Question3
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=Question3;Integrated Security=True";

        

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Dia chi khong the de trong");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string name = this.listName.SelectedItem.ToString();

                    string date = this.dtpNgayYeuCau.Value.ToString("yyyy-MM-dd");

                    string address = txtDiaChi.Text;


                    string query = "insert into Orders values (N'"+name+"', '"+date+"', N'"+address+"')";

                    // SqlCommand -> insert, update, delete
                    // SqlDataAdapter -> select

                    SqlCommand command = new SqlCommand(query, connection);

                    command.ExecuteNonQuery();

                    // DataSet
                    // DataTable

                    // DataSet chua cac DataTable, DataTable tuong trung cho cac bang lay ra tu database
                    connection.Close();
                }
                MessageBox.Show("Them sinh vien thanh cong");
                txtDiaChi.Clear();
                listName.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listName.SelectedIndex = 0;
        }
    }
}
