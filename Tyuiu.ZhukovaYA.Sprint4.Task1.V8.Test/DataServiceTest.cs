using Tyuiu.ZhukovaYA.Sprint4.Task1.V8.Lib;

namespace Tyuiu.ZhukovaYA.Sprint4.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ints = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0 };
            Assert.AreEqual(5, ds.Calculate(ints));
        }
    }
}