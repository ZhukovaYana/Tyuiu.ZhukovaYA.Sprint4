using Tyuiu.ZhukovaYA.Sprint4.Task7.V4.Lib;

namespace Tyuiu.ZhukovaYA.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8, ds.Calculate(2, 2, "3456"));
        }
    }
}