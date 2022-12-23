Console.WriteLine("Найдите точки пересечения двух прямых: ");
Console.WriteLine("1.y = k1 * x + k2");
Console.WriteLine("2. y = t1 * x + t2");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите t1: ");
double t1 = double.Parse(Console.ReadLine());
Console.Write("Введите t2: ");
double t2 = double.Parse(Console.ReadLine());
if (k1 == t1)
{
    Console.WriteLine("Прямые параллельны и никогда не пересекутся");
}
if (k1 != t1)
{
    double x = (t2 - k2) / (k1 - t1);
    double y = k1 * x + k2;
    Console.Write("Коордитаны пересечения прямых: ");
    Console.WriteLine("(" + x + ", " + y + ")"); 
}