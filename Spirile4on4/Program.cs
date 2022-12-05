int[,] SpirileFill4on4(int n)
{
    int[,] array = new int[4, 4];

    for (int j = 0; j < 4; j++)
    {
        array[0, j] = n;
        n++;
    }
    for (int i = 1; i < 4; i++)
    {
        array[i, 3] = n;
        n++;
    }
    for (int j = 2; j >= 0; j = j - 1)
    {
        array[3, j] = n;
        n++;
    }
    for (int i = 2; i > 0; i = i - 1)
    {
        array[i, 0] = n;
        n++;
    }
    for (int j = 1; j < 3; j++)
    {
        array[1, j] = n;
        n++;
    }
    for (int j = 2; j > 0; j = j - 1)
    {
        array[2, j] = n;
        n++;
    }
    return array;
}
void Print2DArray(int[,] input)
{
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {                     
            if (input[i, j]<10) Console.Write("0" +input[i, j] + " ");
            else  Console.Write(input[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число для спирального заполнения массива размером 4*4: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = SpirileFill4on4(n);
Console.WriteLine("Получен массив: ");
Print2DArray(array);