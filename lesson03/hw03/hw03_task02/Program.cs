// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine($"Put xA coordinate: ");
double xA = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put xB coordinate: ");
double xB = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put yA coordinate: ");
double yA = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put yB coordinate: ");
double yB = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put zA coordinate: ");
double zA = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Put zB coordinate: ");
double zB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));

System.Console.WriteLine($"The distance beetween to points is {distance}");