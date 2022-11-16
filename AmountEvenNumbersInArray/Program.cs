void RandomFillArray(int[] array, int n)
{
    int count = 0;
    Random random = new Random();
    while (count < n)
    {
        array[count] = random.Next(100, 1000);
        count++;
    }
}
void PrintArray(int[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введен массив: ");
    Console.WriteLine("[" + str + "]");
}
int Counter(int[] array, int n)
{
    int count = 0;
    int evennumber = 0;
    while (count < n)
    {
        if (array[count] % 2 == 0) evennumber++;
        count++;
    }
    return evennumber;
}
Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] newarray = new int[n];
RandomFillArray(newarray, n);
PrintArray(newarray);
Console.WriteLine("Количество четных трехзначных чисел равно: " + Counter(newarray, n));


