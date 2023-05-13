// Задача 45: Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.

void FillArray(int[] numbers, int minValue, int maxValue)
{
  maxValue++;
  Random rnd = new Random();
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = rnd.Next(minValue, maxValue);
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

int[] GetCopy(int[] array)
{
  int[] copyArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    copyArray[i] = array[i];
  }
  return copyArray;
}

void GetArray()
{
  System.Console.WriteLine("How long is the array?");
  int n = int.Parse(Console.ReadLine());
  int[] ourArray = new int[n];
  FillArray(ourArray, -30, 99);
  PrintArray(ourArray);
  PrintArray(GetCopy(ourArray));
}

GetArray();