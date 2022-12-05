int[,] RandomFill2DArray(int rows, int columns)
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
void Print2DArray(int[,] input)
{
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
int[,] SortRow2DArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        int length = input.GetLength(1);
        int k = 0;
        for (int j = 0; j < length - k + 1; j++)
        {
            k = j;
            int max = input[i, j];
            int p = j;
            while (j < length)
            {
                if (max < input[i, j])
                {
                    max = input[i, j];
                    p = j;
                }
                j++;
            }
            j = k;
            int temple = input[i, j];
            input[i, j] = max;
            input[i, p] = temple;
        }
    }
    return input;
}
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] newarray = RandomFill2DArray(rows, columns);
Console.WriteLine("Введен массив: ");
Print2DArray(newarray);
int[,] sorted2Darray = SortRow2DArray(newarray);
Console.WriteLine("Результат сортировки массива по строкам: ");
Print2DArray(sorted2Darray);



