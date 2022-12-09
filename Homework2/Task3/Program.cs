Console.Write("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine());
while (day > 0 & day < 8)
{
    if (day < 6)
        {
            Console.WriteLine("Wokr day");
        }
    else
        {
            Console.WriteLine("Day off");
        }
}
Console.WriteLine("Day is absent");
