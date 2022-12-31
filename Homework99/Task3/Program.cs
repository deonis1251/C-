Console.Write("Введите первое не отрицательное число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе не отрицательное число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Функция Аккермана равна {Akkerman(firstNumber, secondNumber)}");


int Akkerman(int a, int b)
{
  if (a == 0) return b + 1;
  else if (b == 0) return Akkerman(a - 1, 1);
  else return Akkerman(a - 1, Akkerman(a, b - 1));
}