// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 2 способ 

Console.WriteLine("Put a num");
int number = 0;
  while (!int.TryParse(Console.ReadLine(), out number))
  { Console.WriteLine("it's not a num"); }

  int NumberDigit(int num)
  {
    num = Math.Abs(num);
    int count = 0;
    while (num > 0)
    {
      num = num / 10;
      count++;
    }
    return count;
  }

  int NumbDigit = 0;
  NumbDigit = NumberDigit(number);
  System.Console.WriteLine(NumbDigit);