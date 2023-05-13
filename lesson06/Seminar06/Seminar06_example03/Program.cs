/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/


  // ConvertNumber(number);

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

// Решение через Stack
Stack<int> convertNumber = new Stack<int>();
System.Console.WriteLine("TODO");
int number = ReadInt("Put any number: ");

while (number >= 1)
{
  convertNumber.Push(number % 2);
  number = number / 2;
}

while (convertNumber.TryPop(out int i))
{
  System.Console.Write(i);
}

/* Метод через преобразование в строку
string ConvertNumber(int number)
{
  string byBit = "";
  while (number >= 1)
  {
    byBin = ((number % 2).ToString() + byBin);
    number = number / 2;
  }
  return byBin;
}
*/

/* Другой метод конвертации, но он сложнее
void ConvertNumber(int number)
{
  int i = 0;
  int[] byBin = new int[10];

  while (number >= 1)
  {
    byBin[i] = number % 2;
    i++;
    number = number / 2;
  }
  
  for (int j = (byBin.Length - (byBin.Length -i) - 1); j >- 0; j--)
  {
    System.Console.Write($"{byBin[j]} ");
  }
}
*/