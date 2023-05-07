// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
// равна 29, сумма отрицательных равна -20

void FillArray(int[] numbers)
{
  Random rnd = new Random();

  // перебираем массив и добавляем в него случайные числа в диапозоне от -9 до 9
  for (int i = 0; i < numbers.Length; i++)
  {
    numbers[i] = rnd.Next(-9, 10);
  }
}

void PrintArray(int[] numbers)
{
  // выводим на экран наш массив
  for (int i = 0; i < numbers.Length; i++)
  {
    Console.Write($"{numbers[i]} ");
  }
  Console.WriteLine();
}

int FindSumEl_Positive(int[] numbers)
{
  int sum = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] > 0)
      sum += numbers[i];
  }
  return sum;
}

int FindSumEl_Negative(int[] numbers)
{
  int subtr = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if (numbers[i] < 0)
      subtr += numbers[i];
  }
  return subtr;
}


void GetArray()
{
  // инициализируем  массив (в неи сейчас 12 нулей) и константу случайных чисел
  int size = 12;
  int[] array = new int[size];
  //вызываем методы, которые создали выше
  FillArray(array);
  PrintArray(array);
  // можно сначала созать переменную и потом передать ее
  int sum = FindSumEl_Positive(array);
  System.Console.WriteLine($"Sum positive elements of array is {sum}");
  // можно без создания переменной сразу вызвать и передать нашу функцию
  System.Console.WriteLine($"Sum negative elements of array is {FindSumEl_Negative(array)}");
}

GetArray();