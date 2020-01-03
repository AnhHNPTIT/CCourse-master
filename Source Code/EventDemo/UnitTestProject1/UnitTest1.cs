using System;
using EventDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static int k = 0;
        public TestContext TestContext { get; set; }
        [DataSource("Provider=SQLOLEDB;DataSource=(local);Integrated Security=SSPI;initial catalog=Training;Persist Security Info=False","TestSum")]
        [TestMethod]
        public void TestFromDB()
        {
            // Access the data
            int x = Convert.ToInt32(TestContext.DataRow["firstNumber"]);
            int y = Convert.ToInt32(TestContext.DataRow["secondNumber"]);
            int expected = Convert.ToInt32(TestContext.DataRow["sum"]);
            int actual = MathUtil.Add2Numbers(x, y);
            Assert.AreEqual(expected, actual, "x:<{0}> y:<{1}>", new object[] { x, y });           
        }

        [TestMethod]
        public void TestKValue()
        {
            Assert.AreEqual(999, k);
        }

        [ClassInitialize]
        public static void TestClassInit(TestContext context)
        {
            k = 999;
        }
        // với thuộc tính ClassInitialize luôn được chạy đầu tiên

        [TestMethod]
        public void TestXOfN()
        {
            long expected = 8;
            long actual = MathUtil.XOfN(2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXOfZero()
        {
            long expected = 1;
            long actual = MathUtil.XOfN(100, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestXOfNagitive()
        {
            try
            {
                Assert.AreEqual(1, MathUtil.XOfN(100, -2));
            } 
            catch(ArgumentException ex)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestAdd()
        {
            long expected = 3;
            long actual = MathUtil.Add2Numbers(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul()
        {
            long expected = 2;
            long actual = MathUtil.Mul(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMulWithZero()
        {
            long expected = 0;
            long actual = MathUtil.Mul(100, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMulWithOne()
        {
            long expected = 100;
            long actual = MathUtil.Mul(100, 1);
            Assert.AreEqual(expected, actual);
        }

    }
}
