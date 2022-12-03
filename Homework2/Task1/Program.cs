Console.Write("Напишиет трёхзначное цисло: ");
int a = int.Parse(Console.ReadLine());
int count = a.ToString().Length;
int result = -1;
if(count > 3 || count < 3)
{
    Console.WriteLine("Вы ввели не трёхзначиное число");
}
else 
{
   result = ((a / 10) % 10);
}
Console.WriteLine(result);