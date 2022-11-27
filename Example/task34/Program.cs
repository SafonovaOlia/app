// Функции
void InputArray1(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(100,1000);
    }
}
void PrintArray1(int[] Array1)
{
    int count = 0;
    Console.Write("[ ");
    for(int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Array1[i] + " ");
        if (Array1[i] % 2 == 0)
        count++;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"где, Всего чисел: {Array1.Length}, из них чётные: {count}");
}
// текст программы
Console.WriteLine("Введите размер массива");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[ArraySize];

InputArray1(Array1);
Console.Write("Массив, заполненный случайными положительными трёхзначными числами: ");
PrintArray1(Array1);