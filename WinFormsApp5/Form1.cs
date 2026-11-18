using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        string connection = "KRN-20-202-C09\\MSSQLSERVER2;Server=vadik;Database=vadik;Integrated Security = True; TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void productClient_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();

            string query = "SELECT * FROM products";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            flowLayoutPanel1.Controls.Clear();

            while (reader.Read())
            {
                UserControl1 userControl = new UserControl1();

                userControl.Card(
                    reader["nameProduct"].ToString(),
                    Convert.ToInt32(reader["cost"]),
                    reader["photo"].ToString());
                flowLayoutPanel1.Controls.Add(userControl);
            }

            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
