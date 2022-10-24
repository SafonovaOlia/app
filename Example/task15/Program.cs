using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            if (a <6) 
            {
                Console.Write("является ли этот день выходным: Нет ");
            }    
            else
            { 
                if (a < 8) 
                {
                    Console.Write("является ли число чётным: Да ");  
                } 
                else
                {
                    Console.Write("Такого дня недели не существует ");  
                }
            }   
        }
    }
}
