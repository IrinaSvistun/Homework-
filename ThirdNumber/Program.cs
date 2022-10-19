void PrintThirdDigit(int A)
{
    if (A < 0) A = -1 * A;
    if (A < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (A > 999)
        {
            A = A / 10;
        }
        int ThirdDigit = A % 10;
        Console.WriteLine("Третья цифра заданного числа -> " + ThirdDigit);
    }
}
Console.WriteLine("Введите число");
if (!int.TryParse(Console.ReadLine()!, out int number))
{
    Console.WriteLine("Введите ЧИСЛО!!!");
    return;
}

PrintThirdDigit(number);
