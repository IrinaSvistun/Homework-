double[,] MatrixRandomFillArray(int rows, int columns)
{
    Random random = new Random();
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(random.NextDouble(),1);
        }
    }
    return array;
}
void PrintArray(double[,] input)
{
    Console.WriteLine ("Введен массив: ");
    for (int i = 0; i < input.GetLength(0); i++)
    {
        for (int j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i,j]);
            if (j!=input.GetLength(1)-1) Console.Write(" ; ");

        }
        Console.WriteLine();
    }
}

double[,] newarray = MatrixRandomFillArray(3, 4);
PrintArray(newarray);



