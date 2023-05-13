/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник сo сторонами такой длины.*/

  int AB = ReadInt("AB: ");
  int BC = ReadInt("BC: ");
  int CA = ReadInt("CA: ");

  HasTriangle(AB, BC, CA);

int ReadInt(string argument) // проверка на число
{
  Console.Write(argument);
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
  System.Console.WriteLine("It is not a number!");
  Console.Write(argument);
  }
  return i;
}

void HasTriangle(int ab, int bc, int ca)
{
  if (ab + bc > ca && bc + ca > ab && ab + ca > bc)
    System.Console.WriteLine("It is a triangle");
  else System.Console.WriteLine("It is NOT a triangle");
}