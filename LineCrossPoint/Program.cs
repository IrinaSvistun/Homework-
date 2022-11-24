void HandFill(double[] array, int n)
{
    Console.Write("Введите b" + n + ": ");
    array[1] = Convert.ToDouble(Console.ReadLine()!);
    Console.Write("Введите k" + n + ": ");
    array[0] = Convert.ToDouble(Console.ReadLine()!);
}
void PrintArray(double[] array)
{
    var str = string.Join(" ,", array);
    Console.WriteLine("[" + str + "]");
}
double[] LineCrossPoint(double[] array1, double[] array2)
{
    double[] crosspoint = new double[2];
    crosspoint[0] = Math.Round(-1 * (array2[1] - array1[1]) / (array2[0] - array1[0]), 2);
    crosspoint[1] = Math.Round(-1 * (array1[0] * array2[1] - array2[0] * array1[1]) / (array2[0] - array1[0]), 2);
    return crosspoint;
}

Console.WriteLine("Введите коэфaициенты уравнения прямой y=k1*x + b1");
double[] line1 = new double[2];
HandFill(line1, 1);
Console.WriteLine("Введите коэфaициенты уравнения прямой y=k2*x + b2");
double[] line2 = new double[2];
HandFill(line2, 2);
if (line2[0] - line1[0] == 0) Console.WriteLine("Введенные прямые параллельны");
else
{
    double[] crosspoint = LineCrossPoint(line1, line2);
    Console.Write("Координаты точки пересечения: ");
    PrintArray(crosspoint);
}
