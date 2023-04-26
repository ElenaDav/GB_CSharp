// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

System.Console.WriteLine($"Put xA coordinate: ");
double xA = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put xB coordinate: ");
double xB = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put yA coordinate: ");
double yA = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put yB coordinate: ");
double yB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
System.Console.WriteLine($"The distance beetween to points is {distance}");