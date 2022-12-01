Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}