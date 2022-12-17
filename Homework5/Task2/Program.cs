int[] array = new int[10];
int sum = 0;
for(int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.WriteLine(sum);