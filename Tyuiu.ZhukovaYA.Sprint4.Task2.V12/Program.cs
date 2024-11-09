using Tyuiu.ZhukovaYA.Sprint4.Task2.V12.Lib;
namespace Tyuiu.ZhukovaYA.Sprint4.Task2.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 14 элементов заполненный случайным*");
            Console.WriteLine("*ми в диапазоне от 4 до 9 подсчитать сумму нечетных элементов массива.    *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Элемент массива {i}: ");
                array[i] = random.Next(4,9);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            Console.WriteLine($"сумма нечетных элементов: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}