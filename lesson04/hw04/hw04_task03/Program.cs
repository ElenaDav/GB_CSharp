// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
System.Console.WriteLine("Put 8 numbers: ");
int numb = int.Parse(Console.ReadLine());

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
  array[i] = new ;
}

System.Console.WriteLine(string.Join("  ", array));
*/
int AddNumbs(string add)
{
  System.Console.WriteLine("Put 8 numbers: ");
  string numbsStr = Console.ReadLine();
  int numbs = int.Parse(numbsStr);
  return numbs;
}

int[] EightNumbsArray(int eight)
{
  int[] array = new int[8];
  Random rnd = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    
  }
  return array;
}

void PrintArray(int[] array)
{
  System.Console.Write("[");

  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  // System.Console.Write($"{array[array.Length - 1]}, ");

  System.Console.Write("]");
}

int addNumbs = AddNumbs("Put 8 numbers:");
// System.Console.WriteLine(addNumbs);
int[] array = new int[addNumbs];
// System.Console.WriteLine(array);
PrintArray(array);