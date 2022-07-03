//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distanse(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double LineD =  Math.Round (Distanse(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {LineD}");
