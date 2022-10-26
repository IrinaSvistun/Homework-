double DestinationBetweenDots(int N, int[] dotA, int[] dotB)
{
    int count = 0;
    double summ = 0;
    while (count < N)
    {
        summ = summ + Math.Pow(dotB[count] - dotA[count], 2);
        count++;
    }
    return Math.Sqrt(summ);
}

int[] ArrayInput(int N)
{
    int count = 0;
    int[] dot = new int[N];
    while (count < N)
    {
        Console.Write("Значение " + (count + 1) + ": ");
        dot[count] = int.Parse(Console.ReadLine()!);
        count++;
    }
    return dot;
}

Console.Write("Введите количество измерений N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите параметры точки А:");
int[] dotA = ArrayInput(N);
Console.WriteLine("Введите параметры точки B:");
int[] dotB = ArrayInput(N);
Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Round(DestinationBetweenDots(N, dotA, dotB), 3));
