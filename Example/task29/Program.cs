using System;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int lenMas = Convert.ToInt32(Console.ReadLine());

            int[] RanArray = new int[lenMas];
            for (int i = 0; i < RanArray.Length; i++)
            {
                RanArray[i] = new Random().Next(1,9);
                Console.Write(RanArray[i] + " ");
            }
        }
    }
}
