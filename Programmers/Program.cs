void PrintProgrammersAmount(int A)
{
    int SecondDigit = (A / 10) % 10;
    if (SecondDigit == 1) Console.WriteLine(A + " программистов");
    if (SecondDigit != 1)
    {
        if (A % 10 == 1) Console.WriteLine(A + " программист");
        if (A % 10 > 1 && A % 10 < 5) Console.WriteLine(A + " программиста");
        if (A % 10 > 4 || A % 10 == 0) Console.WriteLine(A + " программистов");
    }
}
Console.WriteLine("Введите количество программистов в комнате");
if (!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("Проверьте правильность введенных данных и повторите");
    return;
}
PrintProgrammersAmount(n);
