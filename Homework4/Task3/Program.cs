Console.Write("Выедите количество элементов в массиве: ");
int countArr = int.Parse(Console.ReadLine());
int[] array = new int[countArr];
double result = 0;
int index = countArr - 1;
for (int i = 0; i < countArr; i++)
{
    if(index >= 0)
    {
        array[i] = new Random().Next(0, 15);
        result = result + array[i] * Math.Pow(15, index);
        if (array[i] == 10) Console.Write("A");
        if (array[i] == 11) Console.Write("B");
        if (array[i] == 12) Console.Write("C");
        if (array[i] == 13) Console.Write("D");
        if (array[i] == 14) Console.Write("E");
        if (array[i] < 10) Console.Write(array[i]);
    }
    index = index - 1;
}
Console.Write(" = ");
Console.WriteLine(result + " ");