using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhukovaYA.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0) res += matrix[i,j];
                }
            }
            return res;
        }
    }
}
