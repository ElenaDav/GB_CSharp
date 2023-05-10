// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
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

void OperationTwoNumbers(int[] numbers)
{
  int halfSizeArr = numbers.Length / 2;
  int lastIndex = numbers.Length - 1;

  for (int i = 0; i < halfSizeArr; i++)
  {
    int result = numbers[i] * numbers[lastIndex - i];
    System.Console.WriteLine($"{numbers[i]} * {numbers[lastIndex - i]} = {result}");
  }
  if (numbers.Length % 2 != 0)
  {
    System.Console.WriteLine($"Number without pair - {numbers[halfSizeArr]}");
  }
}
void GetArray()
{
  int size = 5;
  int[] array = new int[size];
  FillArray(array, 0, 9);
  PrintArray(array);
  OperationTwoNumbers(array);
}

GetArray();