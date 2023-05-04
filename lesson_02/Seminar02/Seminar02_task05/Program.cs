// Напишите программу, которая будет принимать на вход два числа и выводить, является ли одно число квадратом другого.
// 25, 5 -> да 
// 8, 9 -> нет
// 16, 4 -> да
// 5, 25 -> да

System.Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());

if (firstNum * firstNum == secondNum || secondNum * secondNum == firstNum)
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No");
}