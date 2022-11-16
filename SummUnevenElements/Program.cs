void RandomFillArray(int[] array, int n)
{
    Console.WriteLine("Введите минимальное допустимое значение элемента массива:");
    int minValue = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите максимально допустимое значение элемента массива:");
    int maxValue = int.Parse(Console.ReadLine()!);
    int count = 0;
    Random random = new Random();
    while (count < n)
    {
        array[count] = random.Next(minValue, maxValue);
        count++;
    }
}
void PrintArray(int[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введен массив: ");
    Console.WriteLine("[" + str + "]");
}
int SummUnevenElementsCounter(int[] array, int n)
{
    int count = 1;
    int summ = 0;
    while (count < n)
    {
        summ = summ + array[count];
        count = count + 2;
    }
    return summ;
}
Console.WriteLine("Введите количество элементов массива:");
int n = int.Parse(Console.ReadLine()!);
int[] newarray = new int[n];
RandomFillArray(newarray, n);
PrintArray(newarray);
Console.WriteLine("Сумма элементов множества, стоящих на нечетных позициях равна: " + SummUnevenElementsCounter(newarray, n));


