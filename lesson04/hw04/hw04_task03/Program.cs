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
int AddNums(string add)
{
  System.Console.WriteLine("Put 8 numbers: ");
  string numbsStr = Console.ReadLine();
  int numbs = int.Parse(numbsStr);
  return numbs;
}

// int[] EightNumbs(int eight)
// {
//   int[] array = new int[8];
//   while (array.Length != 7)
//   {
//     System.Console.WriteLine("Put 8 numbers");
//   }
//   return array;
// }

void PrintArray(int[] array)
{
  System.Console.Write("[");

  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write($"{array[i]}, ");
  }
  System.Console.Write($"{array[array.Length - 1]}, ");

  System.Console.Write("]");
}

int addNumbs = AddNums("Put 8 numbers:");
// System.Console.WriteLine(addNumbs);
int[] array = new int[addNumbs];
// System.Console.WriteLine(array);
PrintArray(array);