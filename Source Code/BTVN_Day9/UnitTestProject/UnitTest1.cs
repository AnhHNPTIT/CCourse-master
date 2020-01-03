using System;
using BTVN_Day9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Provider=SQLOLEDB;DataSource=(local);Integrated Security=SSPI;initial catalog=Training;Persist Security Info=False", "TestCountDigit")]
        
        [TestMethod]
        public void TestFromDB()
        {
            // Access the data
            string str = Convert.ToString(TestContext.DataRow["string"]);
            int expected = Convert.ToInt32(TestContext.DataRow["countDigit"]);
            int actual = StringUtil.CountDigitInString(str);
            Assert.AreEqual(expected, actual, "str:<{0}>", new object[] {str});
        }

        [TestMethod]
        public void TestCountDigit()
        {
            string str = "abc123";
            long expected = 3;
            long actual = StringUtil.CountDigitInString(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCountDigitWithNullString()
        {
            try
            {
                Assert.AreEqual(0, StringUtil.CountDigitInString(""));
            }
            catch (ArgumentException ex)
            {
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Assert.AreEqual(0, StringUtil.CountDigitInString("@#$/123"));
            }
            catch (ArgumentException ex)
            {
                return;
            }
            Assert.Fail();
        }
    }
}
