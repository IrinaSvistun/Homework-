void RandomFillArray(int[] array, int n)
{
    int count = 0;
    Random random = new Random();
    while (count < n)
    {
        array[count] = random.Next(0, 2);
        count++;
    }
}
void PrintArray(int[] array)
{
    var str = string.Join(" ,", array);
    Console.Write("Введен массив: ");
    Console.Write("[" + str + "]");
}
bool Counter(int[] array, int n)
{
    int count = 0;
    int zero = 0;
    int one = 0;
    while (count < n)
    {
        if (array[count] == 0) zero++;
        else one++;
        count++;
    }
    return one > zero;
}
int n = 8;
int[] newarray = new int[n];
RandomFillArray(newarray, n);
PrintArray(newarray);
if (Counter(newarray, n)) Console.WriteLine("TRUE");
else Console.WriteLine("FALSE");


