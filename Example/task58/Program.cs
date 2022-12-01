// Функции
void InputArray(int[,] Array)
{
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {            
            Array[i,j] = new Random().Next(1,10);            
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

void СompositionArray(int[,] Array1, int[,] Array2, int[,] ProizvArray)
{        
    for(int i = 0; i < ProizvArray.GetLength(0); i++)
    {
        for(int j = 0; j < ProizvArray.GetLength(1); j++)
        {
            int Sum = 0;
            for(int z = 0; z < ProizvArray.GetLength(1); z++)
            {               
                Sum += Array1[i, z]*Array2[z, j]; 
                //Console.WriteLine($"Массив: {Sum} = {Array1[i, z]} * {Array2[z, j]}  i={i}, j={j}, z={z}" );
            }
            ProizvArray[i, j] = Sum;
        }
    }      
}

// текст программы
int LineSize = 2;
int ColumnSize = 2;
int[,] Array1 = new int[LineSize,ColumnSize];
int[,] Array2 = new int[LineSize,ColumnSize];
int[,] ProizvArray = new int[LineSize,ColumnSize];
InputArray(Array1); 
InputArray(Array2);
//Array1[0,0] = 2;
//Array1[0,1] = 4;
//Array1[1,0] = 3;
//Array1[1,1] = 2;

//Array2[0,0] = 3;
//Array2[0,1] = 4;
//Array2[1,0] = 3;
//Array2[1,1] = 3;

Console.WriteLine("Массив 1, заполненный числами: ");
PrintArray1(Array1);
Console.WriteLine("Массив 2, заполненный числами: ");
PrintArray1(Array2);

СompositionArray(Array1,Array2,ProizvArray);
Console.WriteLine("Произведение 2-х матриц:");
PrintArray1(ProizvArray);
