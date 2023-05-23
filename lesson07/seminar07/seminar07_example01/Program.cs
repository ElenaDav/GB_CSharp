/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

// void FillArray(int[] numbers)
// {
//   Random rnd = new Random();
//   for (int i = 0; i < numbers.Length; i++)
//   {
//     numbers[i] = rnd.Next(1, 10);
//   }
// }

// void PrintArray(int[] numbers)
// {
//   for (int i = 0; i < numbers.Length; i++)
//   {
//     Console.Write($"{numbers[i]} ");
//   }
//   Console.WriteLine();
// }

void CreateAndPrintMatrix(int m, int n)
{
  Random rnd = new Random();
  int[,] array = new int[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int add = rnd.Next(1,10);
      array[i, j] =add;
    }
  }
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

System.Console.WriteLine("Put M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Put N: ");
int n = Convert.ToInt32(Console.ReadLine());

CreateAndPrintMatrix(m, n);