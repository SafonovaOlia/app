using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            static int func(int x) { return (x / 10) % 10; }
            Console.WriteLine ("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine ());
            Console.Write("вторая цифра: "+ func(a));

            //Вар2 - тоже рабочий!!!
            //Console.WriteLine ("Введите число: ");
            //int a = Convert.ToInt32(Console.ReadLine ());
            //string text = a.ToString();
            //text = text.Substring(1, 1);
            //Console.Write("вторая цифра: "+ text);
        }
    }
}
