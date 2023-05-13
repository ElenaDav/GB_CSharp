// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива. - [3,21 7,04 22,93 -2,71,78,24] -> 75,53

// double массив создать

void FillArray(double[] numbers, int minValue = -10, int maxValue = 10)
{
  maxValue++;
  Random rnd = new Random();
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = rnd.Next(minValue, maxValue);
  }
}

void PrintArray(double[] numbers)
{
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"{numbers[i]} ");
  }
  Console.WriteLine();
}

double Difference(double[] difference)
{
  double minValue = difference[0];
  double maxValue = difference[0];
  for (int i = 1; i < difference.Length; i++)
  {
    if (maxValue < difference[i])
    {
      maxValue = difference[i];
    }
    if (minValue > difference[i])
    {
      minValue = difference[i];
    }
  }
  return maxValue - minValue;
}

void GetArray()
{
  int size = 10;
  double[] array = new double[size];
  FillArray(array);
  PrintArray(array);

  System.Console.WriteLine($"Difference beetween max and min is {Difference(array)}");
}

GetArray();