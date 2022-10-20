using System;

namespace task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            if (a % 2 > 0) 
            {
                Console.Write("является ли число чётным: Нет ");
            }    
            else
            {            
                Console.Write("является ли число чётным: Да ");
            }     
        }
    }
}
