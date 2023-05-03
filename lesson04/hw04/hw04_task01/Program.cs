// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Put a first number: ");
int firstNumb = int.Parse(Console.ReadLine());
System.Console.WriteLine("Put a second number: ");
int secondNumb = int.Parse(Console.ReadLine());

double mathPowNumb = Math. Pow(firstNumb, secondNumb);
System.Console.WriteLine(mathPowNumb);