double[] array = new double[10];
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < 10; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    Console.Write(array[i] + " ");
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine();
Console.WriteLine(max - min);