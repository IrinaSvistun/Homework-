Console.WriteLine("Введите 2 числа для сравнения:");
Console.Write("a=");
int a = int.Parse(Console.ReadLine()!);
Console.Write("b=");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.Write("max=" + a);
    Console.Write("; min=" + b);
}
else
{
    Console.Write("max=" + b);
    Console.Write("; min=" + a);
}