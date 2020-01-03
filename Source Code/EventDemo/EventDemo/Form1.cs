using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // numberStore.OddNumberAdded += NumberStore_OddNumberAdded;
            
        }

        private void NumberStore_OddNumberAdded(object sender, OddNumberAddedArgument argument)
        {
            int number = argument.OddNumberAdded;
            listBoxOddNumbers.Items.Add(number);
        }

        private NumberStore numberStore= new NumberStore();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            numberStore.AddNumberToStore(number);
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            numberStore.OddNumberAdded += NumberStore_OddNumberAdded;
            labelEventStatus.Text = "Event enabled";
        }

        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            numberStore.OddNumberAdded -= NumberStore_OddNumberAdded;
            labelEventStatus.Text = "Event disabled";
        }
    }
}
