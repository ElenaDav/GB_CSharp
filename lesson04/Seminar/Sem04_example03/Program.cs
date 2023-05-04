// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

System.Console.WriteLine("Put a number N: "); //4
int numberN = int.Parse(Console.ReadLine());

int GetFactorial(int number) 
{
  int factorial = 1;

  for (int i = 1; i <= numberN; i++)
    factorial *= i;
    return factorial;
}

System.Console.WriteLine($"Sum numbers from 1 to {numberN} is {GetFactorial(numberN)}");