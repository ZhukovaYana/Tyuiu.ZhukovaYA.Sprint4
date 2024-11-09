using Tyuiu.ZhukovaYA.Sprint4.Task6.V21.Lib;

namespace Tyuiu.ZhukovaYA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "12345678", "1234567", "123456789" };
            Assert.AreEqual(1, ds.Calculate(array));
        }
    }
}