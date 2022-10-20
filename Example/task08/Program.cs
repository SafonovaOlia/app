using System;

namespace task08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine ());
            int i = 1;
            while( i < N)
            {
                if (i % 2 > 0) 
                {

                }    
                else
                {            
                    Console.Write(i+", ");
                }    
                i=i+1;
            }
        }
    }
}
