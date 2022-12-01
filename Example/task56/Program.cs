// Функции
void InputArray1(int[,] Array1)
{
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        for(int j = 0; j < Array1.GetLength(1); j++)
        {            
            Array1[i,j] = new Random().Next(10,100);            
        }
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
            //Console.Write(Array1[i,j] + " ");
            Console.Write(String.Format("{0,3}", Array1[i, j])+ " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }      
}

int MinLineArray1(int[,] Array1, int i)
{
    int SumLine = 0;
    for(int j = 0; j < Array1.GetLength(1); j++)
    {
            SumLine = SumLine + Array1[i, j];
    } 
    return SumLine;    
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

int SumLine = 0;
int NomLine = 0;
int MinLine = MinLineArray1(Array1, 0);;         
for(int i = 1; i < Array1.GetLength(0); i++)
{
    SumLine = MinLineArray1(Array1, i);
    //Console.WriteLine($"Sum № {i} : {SumLine} ");      
    if (SumLine < MinLine)
    {
        MinLine = SumLine;            
        NomLine = i;                    
    }
}  
Console.WriteLine($" Номер строки с наименьшей суммой элементов: {NomLine}");