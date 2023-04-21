// Напишите программу, которая будет принимать на вход число и проверять кратно
// ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
  Console.WriteLine($"Число {num} кратно числам 7 и 23");
}
else
{
  Console.WriteLine($"Число {num} не кратно числам 7 и 23");
}