using ShapesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5
{
    public static class MyExtensionClass
    {
        public static int CountDigits(this string content)
        {
            int count = 0;
            for(int i = 0; i < content.Length; i++)
            {                
                if(content[i] >= '0' && content[i] <= '9')
                {
                    count++;
                }
            }
            return count;
        }

        public static bool OddDigits(int number)
        {
            return (number % 2 != 0);
        }

        public static int CountOddDigits(this string content)
        {
            int count = 0;
            for(int i = 0; i < content.Length; i++)
            {
                if (content[i] >= '0' && content[i] <= '9')
                {
                    var temp = Convert.ToInt32(content[i]);
                    if (OddDigits(temp))
                    {
                        count++;
                    }   
                }
            }
            return count;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetLastest(int k)
        {
            k = 200;
        }

        private void GetLastestByRef(ref int k)
        {
            k = 200;
        }

        private void GetLastestByOut(out int k)
        {
            k = 3000;
        }
        private string testOptionalParameters(string name = "unknown", int age = 20)
        {
            return $"{name} and {age}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Shape shape1;
            //Random rand = new Random();
            //if (rand.Next(0, 2) == 1)
            //{
            //    shape1 = new Triangle { A = 300 };
            //}
            //else
            //{
            //    shape1 = new Circle { Radius = 400 };
            //}

            //if (shape1 is Triangle)
            //{
            //    var tr = (Triangle)shape1;
            //    MessageBox.Show($"shape1 is a triangle {tr.A}");
            //}
            //else
            //{
            //    var ci = (Circle)shape1;
            //    MessageBox.Show($"shape1 is a circle Radius = {ci.Radius}");
            //}

            var testMessage = "abc245cds";
            int testCountDigits = testMessage.CountDigits();
            int testCountOddDigits = testMessage.CountOddDigits();

            MessageBox.Show(testCountDigits.ToString());
            MessageBox.Show(testCountOddDigits.ToString());

            //int testData = 20;
            //GetLastest(testData);
            //MessageBox.Show(testData.ToString());
            //GetLastestByRef(ref testData);
            //MessageBox.Show(testData.ToString());
            //GetLastestByOut(out testData);
            //MessageBox.Show(testData.ToString());
            //MessageBox.Show(testOptionalParameters(name: "Canh"));
            //var a = Convert.ToDouble(textBox1.Text);
            //var b = Convert.ToDouble(textBox2.Text);
            //var c = Convert.ToDouble(textBox3.Text);

            //var triangle = new Triangle();
            //triangle.A = a;
            //triangle.B = b;
            //triangle.C = c;

            //var triangle = new Triangle { A = a, B = b, C = c };
            //MessageBox.Show(triangle.CalculateArea().ToString());

            //var tr1 = new Triangle { A = 2, B = 2, C = 2 };
            //var tr2 = new Triangle { A = 4, B = 4, C = 4 };
            //var myList = new List<Triangle>();
            //Triangle maxTriangle = myList.Max();
            //myList.Add(tr2);
            //myList.Add(tr1);
            //myList.Sort(new CalculateAreaComparer());
            //foreach (var item in myList)
            //{
            //    MessageBox.Show(item.CalculateArea().ToString());
            //}


            //var tr1 = new Triangle { A = 1, B = 1, C = 1 };
            //var tr2 = new Triangle { A = 3, B = 4, C = 5 };
            //var tr3 = new Triangle { A = 4, B = 4, C = 4 };
            //var cir1 = new Circle { Radius = 1.5 };
            //var cir2 = new Circle { Radius = 2.0 };
            //var cir3 = new Circle { Radius = 2.5 };
            //var myList = new List<Shape>();
            //int countTri = 0;
            //int countCir = 0;

            //myList.Add(tr1);
            //myList.Add(cir3);
            //myList.Add(cir1);
            //myList.Add(tr2);
            //myList.Add(tr3);
            //myList.Add(cir2);
            //foreach(var item in myList)
            //{
            //    if(item is Triangle)
            //    {
            //        countTri++;
            //    }
            //    else
            //    {
            //        countCir++;
            //    }
            //}
            //MessageBox.Show($"The number of triangle(s) in myList is {countTri.ToString()}");
            //MessageBox.Show($"The number of circle(s) in myList is {countCir.ToString()}");


        }
    }
}
