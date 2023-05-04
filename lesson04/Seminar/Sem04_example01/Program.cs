// Задача 24: Напишите программу, которая принимает на вход число (А) и
// выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.WriteLine("Put a number A: ");
int numberA = int.Parse(Console.ReadLine());

int GetSum(int number) 
{
  int sum = 0;

  for (int i = 1; i <= numberA; i++)
    sum += i;
    return sum;
}

System.Console.WriteLine($"Sum numbers from 1 to {numberA} is {GetSum(numberA)}");