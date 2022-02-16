using System;

namespace lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.  найти разность между максимальным и минимальным элементами массива.
            //2.  поменять местами макс и мин массива
            //3.  отсортировать массив
            Console.WriteLine("программа Караевоцй Вики 2-1 ИС:");

            int[] Mass = new int[10]; //объявление массива на 10 элементов
            int max = 0;
            int min=0;
            int Raz=0;
            Random rnd = new Random();

            for (int i = 0; i < Mass.Length; i++)
            {
                Mass[i] = rnd.Next(20);
                Console.Write(Mass[i] + " ");
                if (min > Mass[i])
                    min = Mass[i];
                if (max < Mass[i])
                    max = Mass[i];
            }
            Console.WriteLine(); //оформление
            Console.WriteLine("**********************");

            Console.WriteLine("минимальное число массива: " + min);   // вывод максимального числа
            Console.WriteLine("максимальное число массива: " + max);   // вывод минимального числа
            Console.WriteLine("их разность: " + Raz);

            Console.WriteLine("**********************");

            Array.Sort(Mass);  // сортировка
            for (int i = 0; i < Mass.Length; i++) // вывод отсортированного массива
                Console.Write(" " + Mass[i]);
            Console.WriteLine();

            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
