// Задача 35: Задайте одномерный массив из 10 элементов, состоящий из случайных чисел. Найдите 
// количество элементов массива, значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int HowManyNumbers(int[] number)
{
  int count = 0;
  for (int i = 0; i < number.Length; i++)
  {
    if (number[i] >= 10 && number[i] <= 99)
    {
      count ++;
    }
  }
  return count;
}

void GetArray()
{
  System.Console.WriteLine("How long is the array?");
  int n = int.Parse(Console.ReadLine());
  int[] ourArray = new int[n];
  FillArray(ourArray, -30, 99);
  PrintArray(ourArray);

  Console.WriteLine($"The array contains {HowManyNumbers(ourArray)} numbers from 10 to 99");
}

GetArray();