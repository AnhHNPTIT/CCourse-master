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

namespace Day6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomerToList();
        }

        private void LoadCustomerToList()
        {
            string connectionString = "Data Source=(local);Initial Catalog=Training;Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select name, customerAddress, dob from Customer";
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBoxCustomer.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxCustomer.Items.Clear();
            string connectionString = "Data Source=(local);Initial Catalog=Training;Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select name, customerAddress, dob from Customer where name like @name";
                command.Parameters.AddWithValue("@name", "%" + txtName.Text + "%");
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBoxCustomer.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
        }
    }
}
