using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            void CheckingNumber(string Str1)
            {
                if (Str1[0]==Str1[4] || Str1[1]==Str1[3])
                {
                    Console.WriteLine($"Является ли оно палиндромом: Да {Str1} - палиндром.");
                }
                else Console.WriteLine($"Является ли оно палиндромом: Нет {Str1} - НЕ палиндром.");
            }
            Console.Write("Введите число: ");
            string Str1 = Console.ReadLine();
            if (Str1!.Length == 5)
            {
                CheckingNumber(Str1);
            }
            else Console.WriteLine("Введи правильное число");
        }
    }
}
