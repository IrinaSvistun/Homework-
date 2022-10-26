void PolindromCheck(int number)
{
    int[] array = new int[5];
    int count = 0;
    int digit = 1;
    while (count < 5)
    {
        array[count] = (number / digit) % 10;
        digit = digit * 10;
        count++;
    }
    if (array[0] == array[4] && array[1] == array[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine()!);
if (number > 9999 && number < 100000) PolindromCheck(number);
else Console.WriteLine("Проверьте сответствие условию и повторите!");