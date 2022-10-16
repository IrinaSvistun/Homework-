Console.WriteLine("Введите 3 числа для сравнения:");
Console.Write("a=");
int a = int.Parse(Console.ReadLine()!);
Console.Write("b=");
int b = int.Parse(Console.ReadLine()!);
Console.Write("c=");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b>max) max=b;
if (c>max) max=c;
Console.Write("max=" + max);
   