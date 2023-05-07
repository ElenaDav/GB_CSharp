/* Задача 32: Напишите программу замены элементов массива: положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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

int[] GetPlusOrMinus(int[] newArray)
{
  for (int i = 0; i < newArray.Length; i++)
  {
    newArray[i] = -newArray[i];
  }
  return newArray;
}

void GetArray()
{
  System.Console.WriteLine("How long is the array?");
  int n = int.Parse(Console.ReadLine());
  int[] ourArray = new int[n];

  FillArray(ourArray);
  PrintArray(ourArray);

  int[] newArray =  GetPlusOrMinus(ourArray);
  PrintArray(newArray);
}

GetArray();

