int ReadInt(string argument) // проверка на число
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

// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

// Task53();

void ChangeString(int[,] array)
{
  int tempArray = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      tempArray = array[0, j];
      array[0, j] = array[array.GetLength(0) - 1, j];
      array[array.GetLength(0) - 1, j] = tempArray;
    }
  }
}

void Task53()
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
  ChangeString(array);
  PrintTwoArray(array);
}


// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки 
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.

Task55();
int[,] ChangeStringsToColumns(int[,] array)
{
  int[,] tempArray = new int[array.GetLength(1), array.GetLength(0)];
  if (array.GetLength(0) != array.GetLength(1))
    {
      System.Console.WriteLine("Strings not equal columns!");
    }
  else
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
      tempArray[j, i] = array[i, j];
      }
    }
  }
    PrintTwoArray(tempArray);
    return tempArray;
}

void Task55()
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
  ChangeStringsToColumns(array);
}

/* Задача 57: Составить частотный словарь элементов двумерного массива. Частотный 
словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/

