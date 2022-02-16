using System;

namespace lab2_5
{

    class Program
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="Mass"></param>
        static void Raz(int[] Mass) // метод разности макс и мин элементов массива
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            Random rnd = new Random();
            for (int i = 1; i < Mass.Length; i++)
            {
                if (min > Mass[i])
                    min = Mass[i];
                if (max < Mass[i])
                    max = Mass[i];
            }

            Console.WriteLine("минимальное число массива: " + min); // вывод максимального числа
            Console.WriteLine("максимальное число массива: " + max); // вывод минимального числа
            Console.WriteLine($"их разность: {max - min}");
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Mass"></param>
        static void Sort(int[] Mass)
        {
            Array.Sort(Mass); // метод сортировки
            for (int i = 0; i < Mass.Length; i++)
                Console.Write(Mass[i]+" ");
            Console.WriteLine();
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="Mass"></param>
        static void BubbleSort(int[] Mass) // метод пузырька
        {
            for (int i = 0; i < Mass.Length; i++)
            {
                for (int j = i + 1; j < Mass.Length; j++)
                {
                    if (Mass[i] > Mass[j])
                    {
                        int temp = Mass[i];
                        Mass[i] = Mass[j];
                        Mass[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Mass.Length; i++)
                Console.Write(Mass[i] + " ");
        }
        static void Main(string[] args)
        {

            //1. найти разность между максимальным и минимальным элементами массива.
            //2. поменять местами макс и мин массива
            //3. отсортировать массив

            Console.WriteLine("программа Караевоцй Вики 2-1 ИС:");

            Console.Write("введите длину массива: "); //спрашиваем длину массива
            int n = int.Parse(Console.ReadLine());
            int[] Mass = new int[n]; //объявление массива на n элементов


            Console.WriteLine("вывод массива:");
            Random rnd = new Random();
            for (int i = 1; i < Mass.Length; i++)
            {
                Mass[i] = rnd.Next(20);
                Console.Write(Mass[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("**********************"); //оформление


            Console.WriteLine("ищем разность между макс и мин элементом массива:");
            Raz(Mass); //разность макс и мин элементов массива

            Console.WriteLine("сортированный массив:");
            Sort(Mass); //сортировка
            Console.WriteLine("**********************"); //оформление

            Console.WriteLine("вывод методом пузырька:");
            BubbleSort(Mass); //метод пузырька
            Console.WriteLine();


            Console.WriteLine("Нажмите enter, чтобы выйти");
            Console.ReadKey(); //выходим из программы
        }
    }
}
