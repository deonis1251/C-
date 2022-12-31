Console.Write("Введите число больше 1: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(Numbers(number)); 

string Numbers(int number)
{
    string result = string.Empty;
    for (int i = 1; i <= number; number--)
    {
        result += $"{number} ";
    }
    return result;
}
