int PrintSecondDigitFromLeft(int A)
{
    int SecondDigit = -1;
    if (A < 0) A = -1 * A;
    if (A < 10) Console.Write("Второй цифры нет");
    if (A > 9)
    {
        while (A > 99)
        {
            A = A / 10;
        }
        SecondDigit = A % 10;
    }
    return SecondDigit;
}

Console.WriteLine("Введите целое число");
if (!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("У меня две новости и обе плохие(  Либо в вашем числе слишком много разрядов для этого искусственного интеллекта, либо вы не знаете что такое целое число.");
    return;
}
Console.WriteLine(PrintSecondDigitFromLeft(n));

