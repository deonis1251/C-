Console.WriteLine("Bведите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10000;
int a5 = a % 10;
int a2 = a / 1000 % 10;
int a4 = a % 100 / 10;
if (a > 9999 & a < 100000)
{
    if (a1 == a5)
    {
        if (a2 == a4)
        {
            Console.WriteLine("Число является полиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является полиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Число не является полиндромом.");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число.");
}