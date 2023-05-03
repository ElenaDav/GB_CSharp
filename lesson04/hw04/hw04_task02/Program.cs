// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Put a number: ");
int firstNumb = int.Parse(Console.ReadLine());
string firstNumbStr = firstNumb.ToString();

int sum = 0;
for (int i = 0; i < firstNumbStr.Length; i++)
{
  sum = firstNumbStr[i] + i;
  // return sum;
}
System.Console.WriteLine(sum);