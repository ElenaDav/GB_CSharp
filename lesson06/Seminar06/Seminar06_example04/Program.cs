/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int N = ReadInt("Put a number: ");
GetNumbersFib(N);

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

void GetNumbersFib(int n)
{
  int[] array = new int[n];
  array[0] = 0;
  array[1] = 1;

  for (int i = 2; i < array.Length; i++)
  {
    array[i] = array[i - 1] + array[i - 2];
  }
  System.Console.WriteLine(string.Join(" , ", array));
}

// Рекурсия с фибоначчи
// int Fibonachi(int n)
// {
//     if (n == 0 || n == 1) return n;
//     return Fibonachi(n - 1) + Fibonachi(n - 2);
// }

// int fib45 = Fibonachi(45);
// System.Console.WriteLine(fib45);

