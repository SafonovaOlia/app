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
            Console.Write(String.Format("{0,4}", Array1[i, j])+ " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }      
}

void SortingArray1(int[,] Array1)
{        
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        for(int j = 0; j < Array1.GetLength(1); j++)
        {
            for(int z = 0; z < Array1.GetLength(1)-1; z++)
            {
                if (Array1[i, z] < Array1[i, z + 1])
                {
                    int Max = Array1[i, z + 1];
                    Array1[i, z + 1] = Array1[i, z];
                    Array1[i, z] = Max;                    
                }
            }
        }
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
SortingArray1(Array1);
Console.WriteLine("Отсортированный массив по строкам, по убыванию:");
PrintArray1(Array1);
