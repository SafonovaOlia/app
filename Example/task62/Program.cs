// Функции
void InputArray(int[,] Array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= Array.GetLength(0) * Array.GetLength(1))
    {
        Array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= Array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > Array.GetLength(1) - 1)
            j--;
        else
            i--;
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

// текст программы
//int LineSize = 2;
//int ColumnSize = 2;
Console.WriteLine("введите количество строк массива");
int LineSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int ColumnSize = Convert.ToInt32(Console.ReadLine());


int[,] Array1 = new int[LineSize,ColumnSize];
InputArray(Array1); 
//InputArray(Array2);

Console.WriteLine("Массив, заполненный спирально: ");
PrintArray1(Array1);
