using Tyuiu.ZhukovaYA.Sprint4.Task0.V11.Lib;
namespace Tyuiu.ZhukovaYA.Sprint4.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (статичесчкий ввод)                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическ*");
            Console.WriteLine("*кими значениями в диапазоне от 0 до 9 подсчитать произведение нечетных эл*");
            Console.WriteLine("*лементов массива. {8, 9, 5, 4, 3, 2, 1, 0, 5, 7}.                        *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Элемент массива {i}:");
                array[0] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine($"произведение нечетных элементов: {ds.GetMultOddArrEl(array)}");
            Console.ReadKey();
        }
    }
}