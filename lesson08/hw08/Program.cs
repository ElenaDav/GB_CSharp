int ReadInt(string argument)
{
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
  System.Console.WriteLine("It is not a number!");
  }
  return i;
}

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

// /* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива*/
// Task54();
void Task54()
{
  System.Console.WriteLine("Put M: ");
  int m2 = ReadInt("M");
  System.Console.WriteLine("Put N: ");
  int n2 = ReadInt("N");
  int[,] array = new int[m2, n2];

  System.Console.WriteLine();
  CreateTwoArray(array);
  PrintTwoArray(array);
  System.Console.WriteLine();
  SortArray(array);
}

void SortArray(int[,] array)
{
  // int[,] newArray = new int[0, 0];
  int temp = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = j + 1; k < array.GetLength(1); k++)
      {
        if (array[i, j] < array[i, k])
        {
          temp = array[i, j];
          array[i, j] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  } PrintTwoArray(array);
}

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

// Task56();
void Task56()
{
  System.Console.WriteLine("Put M: ");
  int m2 = ReadInt("M");
  System.Console.WriteLine("Put N: ");
  int n2 = ReadInt("N");
  int[,] array = new int[m2, n2];

  System.Console.WriteLine();
  CreateTwoArray(array);
  PrintTwoArray(array);
  System.Console.WriteLine();
  SumStringOfArray(array);
  System.Console.WriteLine($"Наименьшая сумма в {MinSumRow(array)} строке.");
}

void SumStringOfArray(int[,] array)
{
  int[] sumArray = new int[array.GetLength(0)];
  Console.WriteLine($"Сумма по строке:");
  for (int i = 0; i < array.GetLength(0); i++)
  { int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
    }
    System.Console.Write($"{sum} ");
    sum = 0;
  }

  System.Console.WriteLine();
}

int MinSumRow(int[,] array)
{
  int[,] sumArray = new int[array.GetLength(0), array.GetLength(1)];
  int minSum = sumArray[0, 0];
  int minRow = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (sumArray[i, j] < minSum)
      {
        minSum = sumArray[i, j];
        minRow = i + 1;  
      }
    }
  }
  return minRow;
}

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
Task58();
void Task58()
{
  System.Console.WriteLine("Put M1: ");
  int m1 = ReadInt("M");
  System.Console.WriteLine("Put N1: ");
  int n1 = ReadInt("N");
  int[,] array01 = new int[m1, n1];

  System.Console.WriteLine();
  CreateTwoArray(array01);
  PrintTwoArray(array01);
  System.Console.WriteLine();

  System.Console.WriteLine("Put M2: ");
  int m2 = ReadInt("M");
  System.Console.WriteLine("Put N2: ");
  int n2 = ReadInt("N");
  int[,] array02 = new int[m2, n2];

  System.Console.WriteLine();
  CreateTwoArray(array02);
  PrintTwoArray(array02);
  System.Console.WriteLine();
  System.Console.WriteLine(OperationArray(array01) * OperationArray(array02));
}

int OperationArray(int[,] array)
{
  int[] operationArray = new int[array.GetLength(0)];
  int operation = 1;
  Console.WriteLine($"Произведение массива:");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      operation *= array[i, j];
    }
    System.Console.Write($"{operation} ");
  }

  System.Console.WriteLine();
  return operation;
}

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

