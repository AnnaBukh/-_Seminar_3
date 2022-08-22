// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("введите координату точки 1 Х1"); 
 Console.Write("X1: ");
 int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату точки 1 Y1");
 Console.Write("Y1: ");
 int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату точки 3 Z1");
 Console.Write("Z1: ");
 int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координату точки 2 Х2");
 Console.Write("X2: ");
 int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату точки 2 Y2");
 Console.Write("Y2: ");
 int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату точки 2 Z2");
 Console.Write("Z2: ");
 int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2-x1)*(x2-x1)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine("Расстояние между точками равно {0: #.##}", result);
//System.Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));