int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
int result = AkkermanFunction(m, n);
Console.WriteLine(result);
