using System;

namespace task13
{
    class Program
    {
        static string func(string x) { return x.Substring(2, 1); }
        static void Main(string[] args)
        {
            
            Console.WriteLine ("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            string text = a.ToString();
            if (a < 100) 
            {
                Console.WriteLine ("третьей цифры нет!");
            }    
            else
            {        
                Console.Write("Третья цифра: "+ func(text));
            } 
        }
    }
}
