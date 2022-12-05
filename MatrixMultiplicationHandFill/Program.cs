int[,] HandFill2DArray(int rows, int columns)
{
       int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        Console.WriteLine ("строка " + (i + 1));
        for (int j = 0; j < columns; j++)
        {
            Console.Write ("столбец " + (j + 1) + ": ");
                array[i, j] = int.Parse(Console.ReadLine()!);
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

int[,] MatrixMultiplication(int[,] input1, int[,] input2)
{
    int[,] multiplicationResult = new int[input1.GetLength(0), input2.GetLength(1)];
    for (int i = 0; i < input1.GetLength(0); i++)
    {
        for (int j = 0; j < input2.GetLength(1); j++)
        {
            int result = 0;
            for (int n = 0; n < input1.GetLength(1); n++)
            {
                result = result + input1[i, n] * input2[n, j];
            }
            multiplicationResult[i, j] = result;
        }
    }
    return multiplicationResult;
}
Console.WriteLine("Введите количество строк матрицы А: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов Матрицы А: ");
int columnsA = int.Parse(Console.ReadLine()!);
int rowsB = columnsA;
Console.WriteLine("Введите количество столбцов Матрицы B: ");
int columnsB = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите элементы мартицы A: ");
int[,] newarrayA = HandFill2DArray(rowsA, columnsA);
Console.WriteLine ("Введите элементы мартицы B: ");
int[,] newarrayB = HandFill2DArray(rowsB, columnsB);
Console.WriteLine("Введена матрица A: ");
Print2DArray(newarrayA);
Console.WriteLine("Введена матрица B: ");
Print2DArray(newarrayB);
int[,] multiplicationMatrix = MatrixMultiplication(newarrayA, newarrayB);
Console.WriteLine("Результат произведения матриц А и В: ");
Print2DArray(multiplicationMatrix);




