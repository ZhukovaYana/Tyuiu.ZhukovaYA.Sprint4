using Tyuiu.ZhukovaYA.Sprint4.Task1.V8.Lib;
namespace Tyuiu.ZhukovaYA.Sprint4.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 12 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных элементов*");
            Console.WriteLine("*в массива  С клавиатуры: 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4.             *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Элемент массива {i}:");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine($"Сумма нечетных элементов: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}