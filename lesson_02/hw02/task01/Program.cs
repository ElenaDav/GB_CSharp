// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Первый вариант решения

System.Console.WriteLine("Введите трехзначное число: ");
int num = 0;
while (!int.TryParse(System.Console.ReadLine(), out num))
{
Console.WriteLine("This is not a number");
}

int secondNum = (num / 10) % 10;
Console.WriteLine(secondNum);