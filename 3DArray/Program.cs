int[,,] HandFill3DArray(int rows, int columns, int multi)
{
    int[,,] array = new int[rows, columns, multi];
    int k = 1;
    var size = rows*columns*multi;
    for (int z = 0; z < multi; z++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < multi; i++)
            {
                Console.WriteLine("Введите элемент " + k + " из " + size + ": ");
                array[i, j, z] = int.Parse(Console.ReadLine()!);
                k++;
            }
        }
    }
    return array;
}
void Print3DArray(int[,,] input)
{
    for (int z = 0; z < input.GetLength(2); z++)
    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                Console.Write(input[i, j, z]);
                Console.Write($"({i},{j},{z})");
                if (j != input.GetLength(1) - 1) Console.Write(" ; ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите невторяющиеся двухзначные числа - элементы массива 2*2*2: ");
int[,,] newarray = HandFill3DArray(2, 2, 2);
Console.WriteLine("Сформирован трехмерный массив: ");
Print3DArray(newarray);


