// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void FillArray(int[] numbers, int minValue = 100, int maxValue = 1000)
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

int EvenNumber(int[] numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

void GetArray()
{
  int size = 7;
  int[] array = new int[size];
  FillArray(array);
  PrintArray(array);
  System.Console.WriteLine($"Четных чисел в массиве {EvenNumber(array)}"); 
}

GetArray();