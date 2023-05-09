// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Put a first number: ");
int numb = int.Parse(Console.ReadLine());
System.Console.WriteLine("Put a second number: ");
int n = int.Parse(Console.ReadLine());

int GetPow(int numA, int numB)
{
  int mathPowNumber = 1;
    for (int i = 0; i < n; i++)
  {
    mathPowNumber *= numb;
  }
  return mathPowNumber;
}

System.Console.WriteLine(GetPow(numb, n));