// Функции

int NaturalNum(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNum(n, m + 1)}, ");
    return m;
}

// текст программы
Console.WriteLine("введите число");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;

if (n < 1)
{
    Console.WriteLine("Введите положительное число");
}
Console.Write($"Все натуральные числа в промежутке от {n} до {m}:->  "); 
Console.Write($"{NaturalNum(n, m)}");   
