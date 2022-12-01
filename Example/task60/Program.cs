// Функции
void InputArray(int[,,] Array)
{
    int KolElement = Array.GetLength(0)*Array.GetLength(1)*Array.GetLength(2);
    int[] temp = new int[KolElement];
    for(int i = 0; i < KolElement; i++)
    {
        temp[i] = new Random().Next(10,100);         
        for (int j = 0; j < i; j++)
        {
            if (temp[i]== temp[j])
            {
                //int ppp = temp[j];
                //Console.Write($"i={i}, j={j}, temp={temp[i]} ");
                temp[i] = new Random().Next(10,100); 
                j=0;
                //Console.Write($" После изменения i={i}, j={j}, temp={temp[i]} было={ppp}");                
            }
        } 
    }

    int count = 0;
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Array[i, j, z] = temp[count];
                count++;
            }               
        }
    }
}
void PrintArray1(int[,,] Array1)
{
    //int count = 0;    
    for(int i = 0; i < Array1.GetLength(0); i++)
    {
        //Console.Write("[ ");
        for(int j = 0; j < Array1.GetLength(1); j++)
        {
            //Console.Write($"X({i}) Y({j}) ");
            for(int z = 0; z < Array1.GetLength(2); z++)
            {
                //Console.Write($"Z({z})= {String.Format("{0,4}", Array1[i, j, z])} ");
                Console.Write($"{String.Format("{0,3}", Array1[i, j, z])}({i},{j},{z}) ");
            }
        }
        //Console.Write("]");
        Console.WriteLine();
    }      
}


// текст программы
Console.WriteLine("введите количество строк массива");
int LineSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int ColumnSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите глубину массива");
int WidthSize = Convert.ToInt32(Console.ReadLine());
int[,,] Arraycube = new int[LineSize,ColumnSize,WidthSize];

InputArray(Arraycube); 

Console.WriteLine("Массив 1, заполненный числами: ");
PrintArray1(Arraycube);