using System;

namespace task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите три числа: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            int b = Convert.ToInt32(Console.ReadLine ());
            int c = Convert.ToInt32(Console.ReadLine ());
            int max = a;
            if (b > max) max = b;    
            if (c > max) max = c;           
            Console.Write("Максимальное число: "+max);
        }
    }
}
