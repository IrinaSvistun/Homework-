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
void PrintArray(int[] array)
{
    var str = string.Join("; ", array);
    Console.WriteLine("[" + str + "]");
}
int[] SummInRows(int[,] input)
{
    int[] summArray = new int[input.GetLength(0)];
    for (int i = 0; i < input.GetLength(0); i++)
    {
        int summInRows = 0;
        for (int j = 0; j < input.GetLength(1); j++)
        {
            summInRows = summInRows + input[i, j];
        }
        summArray[i] = summInRows;
    }
    return summArray;
}
int FindMinIndex(int[] array)
{
    int count = 0;
    int min = array[count];
    int minIndex = 0;
    while (count < array.Length)
    {
        if (array[count] < min)
        {
            min = array[count];
            minIndex = count + 1;
        }
        count++;
    }
    return minIndex;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] newarray = RandomFill2DArray(rows, columns);
Console.WriteLine("Введен массив: ");
Print2DArray(newarray);
int[] summArray = SummInRows(newarray);
Console.Write("Сумма элементов в строках: ");
PrintArray(summArray);
int result = FindMinIndex(summArray);
Console.WriteLine("Строка с наименьшей суммой элементов: " + result + " строка");




