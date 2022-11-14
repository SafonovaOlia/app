using System;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberA = ReadInt("Введите число: ");
            int numberB= ReadInt("Введите степень: ");
            ToDegree(numberA, numberB);


            // Функция возведения в степень
            void ToDegree(int a, int b)
            {
                int result = 1;
                for (int i = 1; i <= b; i++)
                {
                    result = result * a;
                }
                Console.WriteLine(a + " в степени " + b + " = " + result);
            }

            // Функция ввода
            int ReadInt(string message)
            {
                Console.WriteLine(message);
                return Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}