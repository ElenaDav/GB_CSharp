// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] numbers, int minValue = -10, int maxValue = 10)
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

int SumNumbers(int[] numbers)
{
  int sum = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (i % 2 != 0)
    {
      sum += numbers[i];
    }
  }
  return sum;
}

void GetArray()
{
  int size = 10;
  int[] array = new int[size];
  FillArray(array);
  PrintArray(array);
  System.Console.WriteLine($"Сумма чисел с нечетным индексом в массиве {SumNumbers(array)}"); 
}

GetArray();