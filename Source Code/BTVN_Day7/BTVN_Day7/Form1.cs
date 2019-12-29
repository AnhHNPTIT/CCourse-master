using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_Day7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var enteredString = txtString.Text;
            try
            {
                if (CheckString(enteredString))
                {
                    MessageBox.Show("You have entered 10 characters correctly!");
                }
            }
            catch (TooShortStringException exception)
            {
                MessageBox.Show($"Error message: {exception.FriendlyMessage} and Danger: {exception.LevelOfDanger}");
            }
            catch (TooLongStringException exception)
            {
                MessageBox.Show($"Error message: {exception.FriendlyErrorMessage} and Length: {exception.StringLength}");
            }
            catch (Exception)
            {
                MessageBox.Show("Ban da bi loi nao do, chua doan duoc!");
            }
            finally
            {
                MessageBox.Show("Check string length has been completed!");
            }
        }

        private bool CheckString (string stringToCheck)
        {
            if (stringToCheck.Length < 10)
            {
                var exception = new TooShortStringException();
                exception.FriendlyMessage = "Ban da nhap it hon 10 ky tu";
                exception.LevelOfDanger = 100;
                throw exception;
            }
            else if (stringToCheck.Length > 10)
            {
                var exception = new TooLongStringException();
                exception.FriendlyErrorMessage = "Ban da nhap lon hon 10 ky tu";
                exception.StringLength = stringToCheck.Length;
                throw exception;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(200);
            //numbers.Add("1233456"); => error
            List<string> names = new List<string>();
            names.Add("Linh");
            names.Add("Hoang Ngoc Anh");
            names.Max(s=>s.Length);
            //names.Add(1); => error

            //Nullable<int> age = null;
            int? age = null;
            if (age.HasValue)
            {
                MessageBox.Show("chua co tuoi!");
            }


        }
    }
}
