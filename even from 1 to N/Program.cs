Console.Write("Введите целое положительное число:");
int n = int.Parse(Console.ReadLine()!);
int count = 0;
while (count<n-1)
{
    count = count + 2;
    Console.Write(count + "; ");
}
