// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine());
int d = (firstNum % secondNum);

if (d == 0)
{
  Console.WriteLine($"Число {firstNum} кратно числу {secondNum}");
}
else
{
  Console.WriteLine($"Число {firstNum} не кратно числу {secondNum}, остаток от деления равен {d}");
}
