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

// Task55();

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

// Dictionary - словарь с ключом и значением
// каждый ключ уникален

// в данной задаче у нас ключем является число, а количество его значение
// Dictionary<int, int> dict =  new Dictionary<int, int>();

// int[,] array = ReadArray();
// // PrintTwoArray(array);

// for (int i = 0; i < array.GetLength(0); i++)
// {
//   for (int j = 0; j < array.GetLength(1); j++)
//   {
//     if (dict.ContainsKey(array[i, j]))
//  {
//     dict[array[i, j]]++;
//   }
//   else
//   {
//     dict.Add(array[i, j], 1);
//   }
//   }
// }

// foreach (var item in dict.OrderBy(x => x.Key)) // посчитать сколько чисел и отсортировать их по ключам
// {
//   System.Console.WriteLine($"{item.Key} --- {item.Value}");
// }

// int[,] ReadArray()
// {
//   System.Console.WriteLine("Input");
//   int length01 = int.Parse(Console.ReadLine());
//   int length02 = int.Parse(Console.ReadLine());

//   int[,] array = new int[length01, length02];

//   for (int i = 0; i < length01; i++)
//   {
//     for (int j = 0; j < length02; j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
    
//   }
//   return array;
// }

/* Задача 59: Задайтедвумерный массив из целых чисел. Напишите программу, которая 
удалит строку и столбец, на пересечении которых расположен наименьший элемент
массива. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7*/

Task59();

void Task59()
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
  PrintTwoArray(DeleteStringAndColumn(array, FindMinElement(array)));
}

int[] FindMinElement(int[,] array)
{
  int[] minElement = new int [] {0, 0};
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < array[minElement[0], minElement[1]])
      {
        minElement[0] = i;
        minElement[1] = j;
      }
    }
  }
  return minElement;
}

int[,] DeleteStringAndColumn(int[,] array, int[] min)
{
  int xShift = 0;
  int yShift = 0;
  int[,] minSize = new int[array.GetLength(1) - 1, array.GetLength(0) - 1];

  for (int i = 0; i < minSize.GetLength(0); i++)
  {
    if (min[0] == i)
    {
      xShift = 1;
    }
    for (int j = 0; j < minSize.GetLength(1); j++)
    {
      if (min[1] == j)
    {
      yShift = 1;
    }
    minSize[i, j] = array[i + xShift, j + yShift];
  }
  yShift = 0;
}
return minSize;
}

