Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i < b + 1; i++)
{
    result = result * a;
}
Console.WriteLine(result);