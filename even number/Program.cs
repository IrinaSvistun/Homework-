Console.Write("Является ли число четным? Введите число:");
int a = int.Parse(Console.ReadLine()!);
if (a%2==0)
{
    Console.Write(a + " - да");
}
else
{
    Console.Write(a + " - нет");
}