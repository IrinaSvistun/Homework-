void Recurtion(int n)
{
    if (n > 1)
    {
        Console.Write(n +", ");
        Recurtion(n-1);
    }
    if (n==1) Console.Write(n);
}

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine()!);
Recurtion(n);
