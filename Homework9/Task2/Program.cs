int[,] matrix = new int[5, 3];
FillArrayRandom(matrix);
PrintArray(matrix);
MinSumStr(matrix);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinSumStr(int[,] array)
{
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum += array[0, i];
    }
    int sumString = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumString += array[i, j];
        }
        if (sumString < minSum)
        {
            minSum = sumString;
        }
        sumString = 0;
    }
    Console.WriteLine($"Минимальная сумма строки равна {minSum}");
}