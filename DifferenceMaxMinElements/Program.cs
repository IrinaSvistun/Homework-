void HandFillArray(double[] array, int n)
{
    Console.WriteLine("Задайте массив из N вещественных чисел");
    int count = 0;
    while (count < n)
    {
        Console.Write("Введите " + count + " элемент массива - ");
        array[count] = Convert.ToDouble(Console.ReadLine()!);
        count++;
    }
}
void PrintArray(double[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введен массив: ");
    Console.WriteLine("[" + str + "]");
}
double DifferenceMaxMinElements(double[] array, int n)
{
    int count = 0;
    double max = array[count];
    double min = array[count];
    while (count < n)
    {
        if (array[count] > max) max = array[count];
        else if (array[count] < min) min = array[count];
        count++;
    }
    return max - min;
}
Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine()!);
double[] newarray = new double[n];
HandFillArray(newarray, n);
PrintArray(newarray);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + DifferenceMaxMinElements(newarray, n));


