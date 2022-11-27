int[,] MatrixRandomFillArray(int rows, int columns)
{
    Random random = new Random();
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 20);
        }
    }
    return array;
}
void PrintMatrixArray(int[,] input)
{
    Console.WriteLine("Введен массив: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1) Console.Write(" ; ");

        }
        Console.WriteLine();
    }
}
void PrintArray(double [] array)
{
    var str = string.Join("; ", array);
    Console.Write("Среднее арифметическое элементов в столбцах: ");
    Console.Write("[" + str + "]");
}
double [] EverageInColumn(int[,] input)
{    
    double [] averageArray = new double [input.GetLength(1)];
    for (int j = 0; j < input.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < input.GetLength(0); i++)
        {
           summ = summ +input[i,j];           
        }
        averageArray [j] = Math.Round(summ/input.GetLength(0),1);
    }
    
    return averageArray;
}
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] newarray = MatrixRandomFillArray(rows, columns);
PrintMatrixArray(newarray);
double [] averageArray = EverageInColumn(newarray);
PrintArray(averageArray);



