void HandFillArray(int[] array, int n)
{
    Console.WriteLine("Задайте массив из 8 целых чисел");
    int count = 0;
    while (count < n)
    {
        Console.Write("Введите " + count + " элемент массива - ");
        array[count] = int.Parse(Console.ReadLine()!);
        count++;
    }
}
void PrintArray(int[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введен массив: ");
    Console.Write("[" + str + "]");
}

int n = 8;
int[] newarray = new int[n];
HandFillArray(newarray, n);
PrintArray(newarray);
