
Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
      System.Console.WriteLine("Enter command");
      var command = Console.ReadLine();
      switch (command)
        {
            case "task25":
                Task25();
                break;
            case "task27":
                Task27();
                break;
            case "task29":
                Task29();
                break;
            case "task31":
                Task31();
                break;
            case "task32":
                Task32();
                break;
            case "task33":
                Task33();
                break;
            case "task34":
                Task34();
                break;
            case "task36":
                Task36();
                break;
            case "task38":
                Task38();
                break;
            case "exit":
                isWork = false;
                break;
        }
    }
}

/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.*/

void Task25()
{
    int number = ReadInt("number");
    int pow = ReadInt("pow");

    Console.WriteLine("Pow: ");
    System.Console.WriteLine(GetPow(number, pow));
    
    Console.WriteLine("Pow Pecursion: ");
    System.Console.WriteLine(GetPowRecursion(number, pow));
}
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

void Task27()
{
    int number = ReadInt("number");
    System.Console.WriteLine(GetDigitNumbers(number));
}
/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайныхцелых чисел 
и выводит их на экран.*/

void Task29()
{
    int min = ReadInt("min element of array");
    int max = ReadInt("max element of array");
    int[] newArray = FillArray(8, min, max);
    
    System.Console.WriteLine(string.Join(", ", newArray));
}
/*
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.
*/
void Task31()
{
    System.Console.WriteLine("start Task31");
    int length = 12, min = -9, max = 9;
    int[] newArray = FillArray(length, min, max);
    // PrintArray(newArray);
    GetSumPositiveAndNegativeElementsArray(newArray);
    System.Console.WriteLine("end Task31");
}
/*
Задача 32: Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
void Task32()
{
    System.Console.WriteLine("start Task32");
    int length = ReadInt("length of array");
    int min = ReadInt("min element of array");
    int max = ReadInt("max element of array");
    int[] newArray = FillArray(length, min, max);
    // PrintArray(newArray);
    int[] changeArray = GetChangeElementsArray(newArray);
    // PrintArray(changeArray, "change elements of array");
    System.Console.WriteLine("end Task32");
}
/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да
*/
void Task33()
{
    System.Console.WriteLine("start Task33");
    int length = ReadInt("length of array");
    int min = ReadInt("min element of array");
    int max = ReadInt("max element of array");
    int[] newArray = FillArray(length, min, max);
    // PrintArray(newArray);
    int element = ReadInt("element");
    bool flag = (GetFindElementsArray(newArray, element));
    System.Console.WriteLine($"Element: {element} {flag}");
    System.Console.WriteLine("end Task33");
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Task34()
{
  int length = ReadInt("Length");
  int[] array = FillArray(length, 100, 1000);
  System.Console.WriteLine(string.Join(", ", array));
  System.Console.WriteLine(GetCount(array));
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите 
// сумму элементов с нечётными индексами.

void Task36()
{
  int length = ReadInt("Length");
  int minValue = ReadInt("minValue");
  int maxValue = ReadInt("maxValue");
  int[] array = FillArray(length, minValue, maxValue);
  System.Console.WriteLine(string.Join(", ", array));
  System.Console.WriteLine(GetSum(array));
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
void Task38()
{
  int length = ReadInt("Length");
  int minValue = ReadInt("minValue");
  int maxValue = ReadInt("maxValue");
  double[] array = FillDoubleArray(length, minValue, maxValue);
  System.Console.WriteLine(string.Join(", ", array));
  System.Console.WriteLine(DoubleDifference(array));
}


int ReadInt(string message)
{
    System.Console.Write($"Enter {message}: ");
    int number;
    while (!int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.WriteLine($"It's not a number.");
    }
    return number;
}

int GetPow(int number, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= number;
    }
    return result;
}

int GetPowRecursion(int number, int pow)
{
  if (pow <= 1)
  {
    return number;
  }
    return number * GetPowRecursion(number, pow - 1);
}

int GetDigitNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
    return array;
}

double[] FillDoubleArray(int length, int minValue, int maxValue)
{
  maxValue++;

  double[] array = new double[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);
  }
  return array;
}

// void PrintArray(int[] numbers)
// {
//   for (int i = 0; i < numbers.Length; i++)
//   {
//     Console.Write($"{numbers[i]}, ");
//   }
//   Console.WriteLine();
// }

int[] GetArraySortToModul(int[] array)
{
    int minElemetn = Math.Abs(array[0]);
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

void GetSumPositiveAndNegativeElementsArray(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
    System.Console.WriteLine($"Sum positive elements of array: {sumPositive}");
    System.Console.WriteLine($"Sum negative elements of array: {sumNegative}");
}

int[] GetChangeElementsArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

bool GetFindElementsArray(int[] array, int element)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element && flag == false) flag = true;
    }
    return flag;
}

int GetCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}

int GetSum(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 != 0)
    {
      sum += array[i];
    }
  }
  return sum;
}

double DoubleDifference(double[] array)
{
  double minValue = array[0];
  double maxValue = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (maxValue < array[i])
    {
      maxValue = array[i];
    }
    else if (minValue > array[i])
    {
      minValue = array[i];
    }
  }
  return Math.Round(maxValue - minValue, 2); //округление до сотых
}

