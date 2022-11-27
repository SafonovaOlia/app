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
// текст программы
int LineSize = 4;
int ColumnSize = 4;

Console.WriteLine("введите позицию элемента (M, N) в двумерном массиве");
Console.WriteLine("введите номер строки ");
int LineM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца ");
int ColumnN = Convert.ToInt32(Console.ReadLine());


if (LineM > LineSize | ColumnN > ColumnSize | LineM < 0 | ColumnN < 0)
{
    Console.WriteLine($" элемента по адресу ({LineM}:{ColumnN}) не существует! Введите в диапазоне ({LineSize}:{ColumnSize})");
}
else
{
    int[,] Array1 = new int[LineSize,ColumnSize];
    InputArray1(Array1);
    Console.WriteLine("Массив, заполненный введенными числами: ");
    PrintArray1(Array1);
    Console.WriteLine();
    Console.WriteLine($" Элемент по адресу ({LineM}:{ColumnN}) = {Array1[LineM-1, ColumnN-1]}");
}