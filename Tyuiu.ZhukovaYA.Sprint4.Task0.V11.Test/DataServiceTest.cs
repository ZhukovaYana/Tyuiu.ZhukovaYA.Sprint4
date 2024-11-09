using Tyuiu.ZhukovaYA.Sprint4.Task0.V11.Lib;

namespace Tyuiu.ZhukovaYA.Sprint4.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ints = { 1, 1, 1, 1, 0, 1, 0, 0, 0, 0 };
            Assert.AreEqual(0, ds.GetMultOddArrEl(ints));
        }
    }
}