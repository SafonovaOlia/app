// Функции
void InputArray1(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Console.Write($"Введите чисело №{i+1}: ");
        Array1[i] = Convert.ToInt32(Console.ReadLine());
        //Array1[i] =  Convert.ToDouble(new Random().Next(10,100)) / 10;
    }
}
void PrintArray1(int[] Array1)
{
    int count = 0;
    Console.Write("[ ");
    for(int i = 0; i < Array1.Length; i++)
    {
        Console.Write(Array1[i] + " ");
        if (Array1[i] > 0)
        count = count + 1;
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"Всего чисел: {Array1.Length}, Количество чисел больше 0: {count}");
}
// текст программы
Console.WriteLine("Введите количество чисел: ");
int ArraySize = Convert.ToInt32(Console.ReadLine());
int[] Array1 = new int[ArraySize];

InputArray1(Array1);
Console.Write("Массив, заполненный введенными числами: ");
PrintArray1(Array1);