int a = 1234;
int sum = 0;
sum = sum + (a % 10);
a = (a - (a % 10)) / 10;
Console.WriteLine(sum);
Console.WriteLine(a);
System.Console.WriteLine();

