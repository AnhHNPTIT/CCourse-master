using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day9
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string> { "1", "Ha", "Hai", "Phong", "Cuong", "Trang", "Yen", "Thu", "Van", "Manh" };
        List<int> numbers = new List<int> { 3, 5, 1, 8, 2 };

        public Form1()
        {
            InitializeComponent();
        }

        static bool NameLongerThan3(string name)
        {
            return (name.Length > 3);
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //var query = names.Where(new Func<string, bool>(NameLongerThan3));
            //var query = names.Where(x => x.Length > 3);
            //var query = names.Where(NameLongerThan3);

            //var query = names.Where(name => name.Length > 4)
            //                 .OrderBy(name => name.Length) // sắp xếp theo độ dài trước
            //                 .ThenBy(name => name);        // sắp xếp theo anphabet của tên sau


            //var query = names.Select(name => name.ToUpper());

            //var query = numbers.Select(number => number * 2 + 1);

            var query = names.Select(name => name[name.Length - 1]); // trả về ký tự cuối cùng của tên
            foreach (var item in query)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            var query = names.Where(name => name.Length > 3);
            MessageBox.Show(query.First()); // first name which longer than 3 characters

            query = names.Where(name => name.Length > 13);
            MessageBox.Show(query.First()); // first name which longer than 13 characters => Exception
            MessageBox.Show(query.FirstOrDefault()); // first name which longer than 13 characters => null or 0 dependence {int, string, byte,...}
        }

        private void btnElementAt_Click(object sender, EventArgs e)
        {
            var query = names.ElementAt(3);
            MessageBox.Show(query);
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            // bỏ qua 3 phần tử và hiển thị phần tử đầu tiên
            //var query = names.Skip(3).First(); 

            // trong khi không tìm thấy ký tự 'r' tiếp tục bỏ qua (skip)
            var query = names.SkipWhile(name => !name.Contains("r"));
            foreach (var item in query)
            {
                MessageBox.Show(item);
            }  
        }

        private void btnAllAny_Click(object sender, EventArgs e)
        {
            // có phải tất cả tên đều >= 3 ký tự
            //var query = names.All(name => name.Length >=3);

            // có phải một trong các tên >= 3 ký tự
            var query = names.Any(name => name.Equals("1"));
            if (query)
            {
                MessageBox.Show(query.ToString());
            }
            
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            var cohort1 = new Int32[] { 3, 5, 1, 8, 2, 51 };
            var cohort2 = new Int32[] { 23, 45, 51, 86, 21 };

            // không lấy phần tử trùng nhau
            //var query = cohort1.Distinct();

            // cohort1 + cohort2
            //var query = cohort1.Union(cohort2);

            // lấy giao của cohort1 với cohort2
            //var query = cohort1.Intersect(cohort2);

            // lấy ngoại trừ
            var query = cohort1.Except(new int[] { 8, 51 });
            foreach (var item in query)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            var db = new TrainingEntities();
            // lấy tất cả các SP là Laptop(id= 1)
            var query = db.Products.Where(p => p.categoryId == 1);
            foreach (var item in query)
            {
                listBox1.Items.Add(item.productName);
            }
        }

        private void btnLINQ1_Click(object sender, EventArgs e)
        {
            var db = new TrainingEntities();
            var query = from P in db.Products
                        where P.categoryId == 1
                        select P.productName; // select P
            foreach (var item in query)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnLINQ2_Click(object sender, EventArgs e)
        {
            var db = new TrainingEntities();
            var query = from P in db.Products
                        where P.categoryId == 1
                        select new { NameInUpper = P.productName.ToUpper() };
            foreach (var item in query)
            {
                listBox1.Items.Add(item.NameInUpper);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var db = new TrainingEntities();
            var query = from Pro in db.Products
                        join Cate in db.categories
                        on Pro.categoryId equals Cate.categoryId
                        select new { Cate.name, Pro.productName };
            foreach (var item in query)
            {
                listBox1.Items.Add(item.name + " " + item.productName);
            }
        }
    }
}
