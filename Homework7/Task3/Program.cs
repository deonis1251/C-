int[,] array = new int[3, 4];
Random random = new Random();
for(int i = 0; i < 3; i++ )
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = random.Next(0, 11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine($"{ sum / array.GetLength(0) }");
}