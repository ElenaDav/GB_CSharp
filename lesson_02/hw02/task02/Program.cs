// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> Третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите трехзначное число: ");
int num = 0;
while (!int.TryParse(System.Console.ReadLine(), out num))
{
Console.WriteLine("This is not a number");
}

string anyNum = Convert.ToString(num);

if (anyNum.Length > 2)
{
  Console.WriteLine($"Третье число {anyNum[2]}");
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
