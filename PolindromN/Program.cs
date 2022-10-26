void PolindromCheck(int number)
{
    int rest = 1; // остаток после деления
    int digit = 10;
    int N = 0;//количество элементов в множестве
    while (rest > 0)
    {
        rest = number / digit;
        digit = digit * 10;
        N = N + 1;
    }
    int[] array = new int[N];
    int count = 0;
    digit = 10;
    while (count < N / 2)
    {
        array[count] = (number / (Convert.ToInt32(Math.Pow(digit, count)))) % 10;
        array[N - 1 - count] = (number / (Convert.ToInt32(Math.Pow(digit, (N - 1 - count))))) % 10;
        if (array[count] == array[N - 1 - count]) count++;
        else
        {
            Console.WriteLine("нет");
            break;
        }
        if (count == N / 2) Console.WriteLine("да");
    }
}
Console.WriteLine("Введите положительное число");
int number = int.Parse(Console.ReadLine()!);
if (number > 0) PolindromCheck(number);
else Console.WriteLine("Проверьте сответствие условию и повторите!");