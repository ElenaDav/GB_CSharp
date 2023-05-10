/* Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

void FillArray(int[] numbers)
{
  Random rnd = new Random();
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = rnd.Next(-10, 10);
  }
}

void PrintArray(int[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"{numbers[i]} ");
  }
  Console.WriteLine();
}

void HasNumber(int[] numbers)
{
  System.Console.WriteLine("Put any number");
  int n = int.Parse(Console.ReadLine());
  bool flag = false;

  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] == n)
    {
      flag = true;
    }
  }
  if(flag) System.Console.WriteLine("YES");
  else System.Console.WriteLine("NO");
}

void GetArray()
{
  System.Console.WriteLine("How long is the array?");
  int n = int.Parse(Console.ReadLine());
  int[] ourArray = new int[n];
  FillArray(ourArray);
  PrintArray(ourArray);

  HasNumber(ourArray);
}

GetArray();