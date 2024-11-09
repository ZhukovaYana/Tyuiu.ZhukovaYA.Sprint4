using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhukovaYA.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
           int res = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) res = res * array[i];
            }
            return res;
        }
    }
}
