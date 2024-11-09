﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhukovaYA.Sprint4.Task2.V12.Lib
{
    public class DataService : ISprint4Task2V12
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) res += array[i];
            }
            return res;
        }
    }
}
