Console.WriteLine("Напишите координаты первой точки: ");
Console.Write("X1= ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1= ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите координаты второй точки: ");
Console.Write("X2= ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y2= ");
int y2 = int.Parse(Console.ReadLine());
double xdis = 0;
double ydis = 0;
double dis = 0;
if (x1 <= x2)
{
    xdis = Math.Abs(0 - x1 + x2);
}
else 
{
    xdis = Math.Abs(0 - x2 + x1);
}
if (y1 <= y2)
{
    ydis = Math.Abs(0 - y1 + y2);
}
else 
{
    ydis = Math.Abs(0 - y2 + y1);
}
dis = Math.Sqrt(xdis * xdis + ydis * ydis);
Console.Write("Distance = ");
Console.WriteLine(dis);