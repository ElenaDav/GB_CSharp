// Напишите программу, которая выводит случайное число из отрезка (10, 99) и 
// показывает наибольшую цифру числа

int random = new Random().Next(10, 100);
Console.WriteLine(random);

int firstNum = random / 10;
int secondNum = random % 10;

if (firstNum > secondNum)
{
  Console.WriteLine(firstNum);
}
else
{
  Console.WriteLine(secondNum);
}