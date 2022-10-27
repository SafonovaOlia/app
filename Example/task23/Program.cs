using System;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            void CalCube(int[] cube, int Ccount)
            {
                int i = 0;  
                while (i <  Ccount)
                {
                    cube[i] = Convert.ToInt32(Math.Pow(i, 3));
                    i++;
                }
            }
            Console.Write("Введите число: ");
            int cube = Convert.ToInt32(Console.ReadLine());
            int[] arry = new int[cube+1];
            int count = arry.Length;
            CalCube(arry, count);

            int i = 1;
            while(i < count)
            {
                Console.Write(arry[i]+ ", ");
                i++;
            }
        }
    }
}
