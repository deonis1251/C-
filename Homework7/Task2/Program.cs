Console.Write("Введите строку: ");
int str = int.Parse(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int column = int.Parse(Console.ReadLine()) - 1;
int n = 5; 
int m = 7; 
Random random = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}
if (str < 0 | str > array.GetLength(0) - 1 | column < 0 | column > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", array[str, column]);
}