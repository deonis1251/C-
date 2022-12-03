Console.Write("Напишите число: ");
int m = int.Parse(Console.ReadLine());
for(int n = 1; n <= m; n++)
{
    if(n % 2 == 0) 
    {
        Console.WriteLine(n);
    }
}