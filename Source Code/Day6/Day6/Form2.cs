using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadCustomerToList()
        {
            TrainingEntities db = new TrainingEntities();
            foreach (var item in db.Customers)
            {
                listBoxCustomer.Items.Add(item.name);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCustomerToList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TrainingEntities db = new TrainingEntities();
            listBoxCustomer.Items.Clear();
            var searchResult = db.Customers.Where(c => c.name.Contains(txtName.Text));
            foreach (var item in searchResult)
            {
                listBoxCustomer.Items.Add(item.name);
            }
        }
    }
}
