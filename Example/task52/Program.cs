// Функции
void InputArray1(int[,] Array1)
{
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        for(int j = 0; j < Array1.GetLength(1); j++)
        {            
            Array1[i,j] = new Random().Next(0,10);            
        }
    }
}

void SredArifColumn(int[,] Array1)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < Array1.GetLength(1); j++)
    {        
        double Sum = 0;
        for (int i = 0; i < Array1.GetLength(0); i++)
        {
            Sum = (Sum + Array1[i, j]);
        }
        double SredArif = Sum / Array1.GetLength(0);
        Console.Write($"{Math.Round(SredArif, 2)}; ");        
    }
}

void PrintArray1(int[,] Array1)
{
    //int count = 0;    
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        Console.Write("[ ");
        for(int j = 0; j < Array1.GetLength(1); j++)
        {            
            Console.Write(String.Format("{0,3}", Array1[i, j])+ " ");            
        }
        Console.Write("]");
        Console.WriteLine();
    }      
}
// текст программы

Console.WriteLine("введите количество строк массива");
int LineSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int ColumnSize = Convert.ToInt32(Console.ReadLine());
int[,] Array1 = new int[LineSize,ColumnSize];

InputArray1(Array1);

Console.WriteLine("Массив, заполненный введенными числами: ");
PrintArray1(Array1);
SredArifColumn(Array1);