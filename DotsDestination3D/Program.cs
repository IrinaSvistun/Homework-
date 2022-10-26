double DestinationBetweenDots(int[] dotA, int[] dotB)
{
    return Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2));
    //AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
}
int[] dotA = new int[3];
int[] dotB = new int[3];

Console.WriteLine("Введите параметры точки А:");
Console.Write("xa = ");
dotA[0] = int.Parse(Console.ReadLine()!);
Console.Write("ya = ");
dotA[1] = int.Parse(Console.ReadLine()!);
Console.Write("za = ");
dotA[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите параметры точки B:");
Console.Write("xb = ");
dotB[0] = int.Parse(Console.ReadLine()!);
Console.Write("yb = ");
dotB[1] = int.Parse(Console.ReadLine()!);
Console.Write("zb = ");
dotB[2] = int.Parse(Console.ReadLine()!);
Console.Write ("Расстояние между точками: ");
Console.WriteLine(Math.Round(DestinationBetweenDots(dotA, dotB), 2));
