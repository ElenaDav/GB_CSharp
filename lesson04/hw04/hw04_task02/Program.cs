// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Put a number: ");
int numb = int.Parse(Console.ReadLine());

int sum = 0;
int mult = 1;

while (numb > 0)
{
  int digit = numb % 10;
  sum = sum + digit;
  mult = mult * digit;
  numb = numb / 10;
}

System.Console.WriteLine(sum);
System.Console.WriteLine(mult);