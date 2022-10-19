bool DayOfTheWeek (int n)
{
    return n > 0 && n < 6;
}

Console.WriteLine("Введите целое число, соответствующее дню недели");
int day = int.Parse(Console.ReadLine()!);
if (DayOfTheWeek (day)) Console.WriteLine("Нет, это будний день( Иди на работу!");
else Console.WriteLine("Да, это выходной! Выбирай что первое - ДЗ или уборка?");

