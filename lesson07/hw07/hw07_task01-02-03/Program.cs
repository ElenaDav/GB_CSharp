/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void FillDoubleArray(double[,] array)
{
  Random rnd = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = Convert.ToDouble(Math.Round(rnd.NextDouble(), 1));
    }
  }
}

void PrintDoubleArray(double[,] array)
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

System.Console.WriteLine("Put M: ");
int m1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Put N: ");
int n1 = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m1, n1];

FillDoubleArray(array);
PrintDoubleArray(array);

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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
  // Random rnd = new Random();
  // int[,] array = new int[m, n];
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

void GetNumber(int[,] array)
{
  System.Console.WriteLine("Put a number: ");
  int number = ReadInt("Number");
 
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(array[i, j] != number)
        System.Console.WriteLine($"{number} -> такого числа в массиве нет");
      else System.Console.WriteLine(number); 
    }
  }
}


System.Console.WriteLine("Put M: ");
int m2 = ReadInt("M");
System.Console.WriteLine("Put N: ");
int n2 = ReadInt("N");
int[,] ourArray = new int[m2, n2];

CreateTwoArray(ourArray);
PrintTwoArray(ourArray);
GetNumber(ourArray);


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

double GetAverage(int[,] array)
{
  double average = 0; 
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      average += array[i, j];    
      average = average / array.GetLength(0);
    }
  }
  return average;
}      

System.Console.WriteLine("Put M: ");
int m3 = ReadInt("M");
System.Console.WriteLine("Put N: ");
int n3 = ReadInt("N");
int[,] arrayForAverage = new int[m3, n3];

CreateTwoArray(arrayForAverage);
PrintTwoArray(arrayForAverage);
System.Console.WriteLine(GetAverage(arrayForAverage));

/* ко 2 заданию
System.Console.WriteLine("Put a number: ");
int number = ReadInt("Number");
if (m2 > ourArray.GetLength(0) || n2 > ourArray.GetLength(1))
{
  Console.WriteLine("такого элемента нет");
}
else
{
  Console.WriteLine($"значение элемента {m2} строки и {n2} столбца равно {ourArray[m2-1,n2-1]}");
}*/