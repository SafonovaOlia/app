// Функции
void InputArray1(double[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] =  Convert.ToDouble(new Random().Next(10,100)) / 10;
    }
}
void PrintArray1(double[] Array1)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    Console.Write("[ ");
    for(int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Array1[i] + " ");
        if (Array1[i] > max)
        max = Array1[i];
        if (Array1[i] < min)
        min = Array1[i];
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего чисел: {Array1.Length}, Разница между максимальным и минимальным: {max-min}");
}
// текст программы
Console.WriteLine("Введите размер массива");
int ArraySize = Convert.ToInt32(Console.ReadLine());
double[] Array1 = new double[ArraySize];

InputArray1(Array1);
Console.Write("Массив, заполненный случайными вещественными числами: ");
PrintArray1(Array1);