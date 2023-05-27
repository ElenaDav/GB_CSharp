/* Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/

void CreateAndPrintMatrix(int m, int n)
{
  Random rnd = new Random();
  int[,] array = new int[m, n];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int add = rnd.Next(1,10);
      array[i, j] = add;
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

// System.Console.WriteLine("Put M: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Put N: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// CreateAndPrintMatrix(m1, n1);

/*Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: A = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

void CreateTwoArray(int[,] array)
{
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = rnd.Next(1,10);
    }
  }
}

void PrintTwoArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
  }
}

int ReadInt(string argument) // проверка на число
{
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
  System.Console.WriteLine("It is not a number!");
  }
  return i;
}

void CreateArrayMN(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = i + j;
    }
  }
}

// System.Console.WriteLine("Put M: ");
// int m2 = ReadInt("M");
// System.Console.WriteLine("Put N: ");
// int n2 = ReadInt("N");
// int[,] array = new int[m2, n2];

// CreateArrayMN(array);
// PrintTwoArray(array);

/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */

/* Задача 49: Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */

void CreatePowElements(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else Console.ForegroundColor = ConsoleColor.White;
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

// System.Console.WriteLine("Put M: ");
// int m3 = ReadInt("M");
// System.Console.WriteLine("Put N: ");
// int n3 = ReadInt("N");

// CreatePowElements(m3, n3);

/* Задача 51: Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

int SumDiagonalElements(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j)
      {
        sum += array[i, j];
      }
    }
  }
  System.Console.WriteLine(sum);
  return sum;
}

// System.Console.WriteLine("Put M: ");
// int m4 = ReadInt("M");
// System.Console.WriteLine("Put N: ");
// int n4 = ReadInt("N");
// int[,] array4 = new int[m4, n4];

// CreateTwoArray(array4);
// PrintTwoArray(array4);
// SumDiagonalElements(array4);