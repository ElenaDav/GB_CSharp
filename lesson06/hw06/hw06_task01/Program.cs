/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь. 1, -7, 567, 89, 223-> 3*/

void CreateArray(string[] args)
  {
    int i = 0;
    while (i < args.Length)
      {
        Console.WriteLine("Put a number: ");
        /* Вводим элементы массива с клавиатуры и заполняем ими массив */
        args[i] = Console.ReadLine();
        i++;
      }
   // Вывод содержимого массива
      // for (i = 0; i < args.Length; i++)
      //   Console.Write(args);
  }

int HowMuchNumbers(int[] number)
{
  int count = 0;
  for (int i = 0; i < number.Length; i++)
  {
        if (number[i] > 0)
  {
    count++;
  }
  }
  return count;
}

// Задаем с клавиатуры число элементов массива
Console.WriteLine("How much numbers do you want puting? ");
int m = int.Parse(Console.ReadLine());

// Объявляем одномерный массив string с m-элементами 
string[] array = new string[m];
CreateArray(array);

// Из массива string преобразуем в массив int
  int[] ints = Array.ConvertAll(array, int.Parse);

  Console.WriteLine($"You have {HowMuchNumbers(ints)} positive of numbers");