/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний
элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] CreateArray(int length, int minValue, int maxValue)
{
  int[] array = new int[length];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

int ReadInt(string argument) // проверка на число
{
  Console.Write(argument);
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
  System.Console.WriteLine("It is not a number!");
  Console.Write(argument);
  }
  return i;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

void RevertArray(int[] array)
{
  for (int i = 0; i < array.Length / 2; i++)
  {
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
  }
}

  int length = ReadInt("Length: ");
  int min = ReadInt("Min Value: ");
  int max = ReadInt("Max Value: ");

  int[] array = CreateArray(length, min, max);

  PrintArray(array);
  RevertArray(array);
  PrintArray(array);