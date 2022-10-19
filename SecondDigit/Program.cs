int PrintSecondDigit(int A)
{
    int SecondDigit = (A / 10) % 10;
    return SecondDigit;
}

Console.WriteLine("Введите трехзначное число");
if (!int.TryParse(Console.ReadLine()!, out int number))
{
    Console.WriteLine("Введите трехзначное ЧИСЛО!!!");
    return;
}
if (number > 99 && number < 1000)
    Console.WriteLine("Вторая цифра числа - " + PrintSecondDigit(number));
else
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число!!!");
