int Recurtion(int m, int n)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n==m) return m;
    return m + Recurtion((m + 1), n);
}

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int result = Recurtion(m, n);
Console.WriteLine(result);
