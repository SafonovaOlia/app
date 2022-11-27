// Функции
void InputArray1(double[,] Array1)
{
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        for(int j = 0; j < Array1.GetLength(1); j++)
        {
            //Console.Write($"Введите чисело №{i+1}: ");
            Array1[i,j] = Convert.ToDouble(new Random().Next(-1000,1000))/100;            
        }
    }
}
void PrintArray1(double[,] Array1)
{
    //int count = 0;    
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        Console.Write("[ ");
        for(int j = 0; j < Array1.GetLength(1); j++)
        {
            //Console.Write(Array1[i,j] + " ");
            Console.Write(String.Format("{0,5}", Math.Round(Array1[i, j], 2))+ " ");
            //if (Array1[i] > 0)
            //count = count + 1;            
        }
        Console.Write("]");
        Console.WriteLine();
    }   
    //Console.WriteLine($"Всего чисел: {Array1.Length}, Количество чисел больше 0: {count}");
}
// текст программы
Console.WriteLine("введите количество строк массива");
int LineSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int ColumnSize = Convert.ToInt32(Console.ReadLine());
double[,] Array1 = new double[LineSize,ColumnSize];

InputArray1(Array1);
Console.WriteLine("Массив, заполненный случайными числами: ");
PrintArray1(Array1);


