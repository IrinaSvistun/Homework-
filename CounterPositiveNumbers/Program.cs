void HandFillArray(double[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Введите " + (i + 1) + " число: ");
        array[i] = Convert.ToDouble(Console.ReadLine()!);
    }
}
void PrintArray(double[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введены числа: ");
    Console.WriteLine("[" + str + "]");
}
int CounterPositiveNumbers(double[] array, int n)
{
    int count = 0;
    for (int i = 0; i < n; i++) if (array[i] > 0) count++;
    return count;
}
Console.WriteLine("Введите количество чисел для проверки (М): ");
int m = int.Parse(Console.ReadLine()!);
double[] newarray = new double[m];
HandFillArray(newarray, m);
PrintArray(newarray);
Console.WriteLine("Количество введенных положительных чисел: " + CounterPositiveNumbers(newarray, m));


