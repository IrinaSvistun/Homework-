int Exponentiation(int a, int b)
{
    
    int result = Convert.ToInt32(Math.Pow(a, b));
    return result;
}
Console.WriteLine("Введите 2 числа");
Console.Write("a=");
int a = int.Parse(Console.ReadLine()!);
Console.Write("b=");
int b = int.Parse(Console.ReadLine()!);
Console.Write(a + " в степени " + b + " равно " + Exponentiation(a, b));


