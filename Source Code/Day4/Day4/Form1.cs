using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testRefactoring()
        {
            var ten = "Anh";
            var diaChi = "Ha Dong";
            var thanhPho = "ha noi";
            PrintInfoInUpper(ten); 
            PrintInfoInUpper(diaChi);
            PrintInfoInUpper(thanhPho);
        }

        private static void PrintInfoInUpper(string infor)
        {
            var inforUpper = infor.ToUpper();
            MessageBox.Show(inforUpper);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userChoice = MessageBox.Show($"Xin chao {textBox1.Text}", "Tieu de", MessageBoxButtons.AbortRetryIgnore);
            if(userChoice == DialogResult.Abort)
            {
                MessageBox.Show("You selected Abort");
            }
            else
            {
                MessageBox.Show("You not selected Abort");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Enter name!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedName = listBox1.SelectedItem.ToString();
            MessageBox.Show($"user change item to {selectedName}!");
        }
    }
}
