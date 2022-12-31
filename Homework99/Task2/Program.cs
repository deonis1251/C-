Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(firstNumber, secondNumber));

int SumNumbers(int a, int b)
{
    a = firstNumber;
    b = secondNumber;
    if(a > b)
	{
		b = firstNumber;
		a = secondNumber;
	}
	return (b + a)*(b - a + 1)/2; // по формуле суммы членов арифметической прогрессии
}
