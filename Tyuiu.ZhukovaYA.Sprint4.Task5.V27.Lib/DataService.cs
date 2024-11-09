using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhukovaYA.Sprint4.Task5.V27.Lib
{
    public class DataService : ISprint4Task5V27
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] < 0) res ++;
                }
            }
            return res;
        }
    }
}
