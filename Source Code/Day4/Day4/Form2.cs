using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        public bool IsFileExists(string pathFile)
        {
            return File.Exists(pathFile);
        }

        public string ReadDataFile(string pathFile)
        {
            FileStream fileTest = new FileStream(pathFile, FileMode.Open);
            StreamReader readerFile = new StreamReader(fileTest, Encoding.UTF8);
            return readerFile.ReadToEnd();
        }

        public int CheckOccurrencesOfSearchText(string message, string textSearch)
        {
            string[] speartor = { " " };
            string[] data = message.Split(speartor, StringSplitOptions.RemoveEmptyEntries);
            var searchResult = from word in data
                               where word.ToLowerInvariant().Contains(textSearch.ToLowerInvariant())
                               select word;

            return searchResult.ToList().Count;
        }

        public void PrintResultOfCheckTextInMessage(string message, string textSearch)
        {
            int wordCount = CheckOccurrencesOfSearchText(message, textSearch);
            if ( wordCount == 0)
            {
                MessageBox.Show($"Not Found TextSearch", "SearchAString");
            }
            else
            {
                MessageBox.Show($"Text {textSearch} found {wordCount} times", "SearchAString");
            }
        }

        private bool isTextBoxEmpty(TextBox textBoxName)
        {
            return (textBoxName.Text.Length <= 0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (fromMessageCheckBox.Checked) 
            {
                if (isTextBoxEmpty(textSearchTextBox) || isTextBoxEmpty(messageTextBox))
                {
                    MessageBox.Show("Enter text to search!", "SearchAString");
                }
                else
                {
                    PrintResultOfCheckTextInMessage(messageTextBox.Text, textSearchTextBox.Text);
                }
            }
            if (fromFileCheckBox.Checked)
            {
                if (isTextBoxEmpty(textSearchTextBox))
                {
                    MessageBox.Show("Enter text to search!", "SearchAString");
                }
                string pathFile = openFileDialog1.FileName;
                if (pathFile != null && IsFileExists(pathFile))
                {
                    PrintResultOfCheckTextInMessage(ReadDataFile(pathFile), textSearchTextBox.Text);
                }
                else
                {
                    MessageBox.Show("Choose file to search!", "SearchAString");
                }
            }
        }
    }
}
