using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhukovaYA.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array)
        {
            return Array.FindAll(array, a => a.Length < 8).Length;
        }
    }
}
