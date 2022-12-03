Console.Write("Напишиет цисло: ");
int a = int.Parse(Console.ReadLine());
int count = a.ToString().Length;
int result = -1;
if (count > 2)
{
    while(a > 999)
    {
        a = a / 10;
    }
    result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нет третьего числа");
}