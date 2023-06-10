/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

string NumberRec(int numb)
{
  if (numb >= 1) return NumberRec(numb - 1) + $"{numb} " ;
  else return string.Empty;
}
// System.Console.WriteLine(NumberRec(6));

/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8*/

string NumbersRec(int m, int n)
{
  if (m <= n) return $"{m} " + NumbersRec(m + 1, n);
  else return string.Empty;
}
// System.Console.WriteLine(NumbersRec(1, 5));

/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/

int SumOfNumbers(int numb)
{
  if (numb / 10 > 0) return numb % 10 + SumOfNumbers(numb / 10);
  else return numb % 10;
}
// System.Console.WriteLine(SumOfNumbers(453));

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int PowerOfNumber(int a, int b)
{
  if (b == 0) return 1;
  else return a * PowerOfNumber(a, b - 1);
}
System.Console.WriteLine(PowerOfNumber(2, 3));
