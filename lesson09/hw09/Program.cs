// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8*/

string NumbersRec(int m, int n)
{
  if (m <= n) return $"{m} " + NumbersRec(m + 1, n);
  else return string.Empty;
}
System.Console.WriteLine(NumbersRec(1, 5));
System.Console.WriteLine(NumbersRec(4, 8));

System.Console.WriteLine();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersRec(int m, int n)
{
  if (m > n) return 0;
  else return SumNumbersRec(m + 1, n) + m;
}
System.Console.WriteLine(SumNumbersRec(1, 15));
System.Console.WriteLine(SumNumbersRec(4, 8));

System.Console.WriteLine();

// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int AkkermanNumbersRec(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AkkermanNumbersRec(m - 1, 1);
  else return AkkermanNumbersRec(m - 1, AkkermanNumbersRec(m, n - 1));
}
System.Console.WriteLine(AkkermanNumbersRec(2, 5));