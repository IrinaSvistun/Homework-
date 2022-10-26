
void CubeArray(int N)
{
    int[] cubearray = new int[N];
    int count = 1;
    while (count < N + 1)
    {
        cubearray[count - 1] = Convert.ToInt32(Math.Pow(count, 3));
        Console.Write(cubearray[count - 1] + ", ");
        count++;
    }
}
Console.WriteLine("Введите целое положительное число");
int N = int.Parse(Console.ReadLine()!);
if (N > 0)
{
    Console.WriteLine("Таблица кубов чисел от 1 до " + N);
    CubeArray(N);
}
else Console.WriteLine("Проверьте соответствие введенных данных условию");

