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
void PrintArray(int[,] input)
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
void FindElement(int[,] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            if (input[i, j] == n)
            {
                Console.WriteLine("Позиция элемента в массиве: [" + (i+1) + ", " + (j+1) + "]");
                count++;
            }
        }
    }
    if (count == 0) Console.WriteLine("Данного элемента нет в масссиве");
}
Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] newarray = MatrixRandomFillArray(rows, columns);
PrintArray(newarray);
Console.WriteLine("Введите элемент, который нужно найти в массиве: ");
int n = int.Parse(Console.ReadLine()!);
FindElement(newarray, n);



