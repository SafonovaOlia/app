using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите два числа суки: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            int b = Convert.ToInt32(Console.ReadLine ());
            if (b > a)
            {
                Console.Write("Максимальное число: "+b);
            }
            else
            {
                Console.Write("Максимальное число: "+a);
            }  
        }
    }
}

