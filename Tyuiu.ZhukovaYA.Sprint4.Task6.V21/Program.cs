using Tyuiu.ZhukovaYA.Sprint4.Task6.V21.Lib;
namespace Tyuiu.ZhukovaYA.Sprint4.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жукова Яна Андреевна | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Класс Array                                                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПБ-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан строковый массив данных [\"Facebook\", \"Twitter\", \"Instagram\", \"Snapcha*");
            Console.WriteLine("*at\", \"LinkedIn\", \"Pinterest\", \"Reddit\"] используя класс Array подсчитайте*");
            Console.WriteLine("*е количество элементов, длина которых меньше 8.                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент массива {i}: {array[i]}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine($"количество элементов, длина которых меньше 8: {ds.Calculate(array)}");
            Console.ReadKey();

        }
    }
}