// Функции
void InputArray1(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(-10,100);
    }
}
void PrintArray1(int[] Array1)
{
    int Sum = 0;
    Console.Write("[ ");
    for(int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Array1[i] + " ");
        if (i % 2 != 0)
        Sum = Sum + Array1[i];
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего чисел: {Array1.Length}, Сумма элементов, стоящих на нечётных позициях: {Sum}");
}
// текст программы
Console.WriteLine("Введите размер массива");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[ArraySize];

InputArray1(Array1);
Console.Write("Массив, заполненный случайными числами: ");
PrintArray1(Array1);