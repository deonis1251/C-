Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine(SumNumbers(firstNumber, secondNumber));

int SumNumbers(int a, int b)
{
	int temp = 0;
	if (a > b)
	{
		temp = a;
		a = b;
		b = temp;
	}
	if (b == a) return 0;
	else return (b + a)*(b - a + 1)/2;
}
