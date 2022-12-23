Console.WriteLine("Введите количество чисел: ");
int count = int.Parse(Console.ReadLine());
int[] array = new int[count];
int plus = 0;
for (int i = 0; i < count; i++)
{
    Console.Write("Введите {0} -й элемент: ", i + 1);
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        plus++;
    }
}
Console.WriteLine("Количество отчицательных чисел = " + plus);