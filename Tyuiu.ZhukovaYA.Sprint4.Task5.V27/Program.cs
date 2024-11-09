using System;
using Tyuiu.ZhukovaYA.Sprint4.Task5.V27.Lib;
namespace Tyuiu.ZhukovaYA.Sprint4.Task5.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы (генератор случайных чисел)                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайны*");
            Console.WriteLine("*ыми значениями в диапазоне от -5 до 7. Найти количество отрицательных эле*");
            Console.WriteLine("*ементов.                                                                 *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i,j] = random.Next(-5, 7);
                    Console.WriteLine($"Элемент массива [{i},{j}]: {array[i,j]}");
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine($"кол-во отрицательных элементов: {ds.Calculate(array)}");
            Console.ReadKey();

        }
    }
}