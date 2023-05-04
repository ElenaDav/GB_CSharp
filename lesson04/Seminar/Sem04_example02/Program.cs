// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// 1 способ

int ReadNum(string argument)
{
  Console.Write(argument);
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
    Console.WriteLine("it's not a number");
  }
  return i;
}

int [] ArrayNum(int number)
{
  string str = number.ToString();
  int[] S = new int [str.Length];

  for (int i = 0; i < str.Length; i++)
  {
    S[i] = int.Parse(str[i].ToString());
  }
  return S;
}

int num = ReadNum("Put a number: ");
System.Console.WriteLine(ArrayNum(num).Length);