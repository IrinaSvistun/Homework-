int SummOfDigitsNumbers(int n)
{
    int summ = 0;
    int digitnumber = n % 10;
    while (n > 0)
    {
        summ = summ + digitnumber;
        n=n/10;
        digitnumber = n % 10;
    }
    return summ;
}

Console.WriteLine("Введите целое положительное число N");
Console.Write("N=");
int n = int.Parse(Console.ReadLine()!);
if (n > 0)
{
    Console.WriteLine("Сумма цифр числа " + n + " равна " + SummOfDigitsNumbers(n));
}
else Console.WriteLine("Проверьте соответствие введенных данных условию");


