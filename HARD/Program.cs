void PrintSecondDigitFromLeft(int A)
{
    if (A < 0) A = -1 * A;
    if (A < 10) Console.WriteLine("Второй цифры нет");
    if (A > 9 && A < 100)
    {
        int SecondDigit = A % 10;
        Console.WriteLine("Вторая цифра заданного числа -> " + SecondDigit);
    }
    if (A > 99)
    {
        while (A > 99)
        {
            A = A / 10;
        }
        int SecondDigit = A % 10;
        Console.WriteLine("Вторая цифра заданного числа -> " + SecondDigit);
    }
}

Console.WriteLine("Введите целое число");
if (!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("У меня две новости и обе плохие(  Либо в вашем числе слишком много разрядов для этого искусственного интеллекта, либо вы не знаете что такое целое число.");
    return;
}
PrintSecondDigitFromLeft(n);
