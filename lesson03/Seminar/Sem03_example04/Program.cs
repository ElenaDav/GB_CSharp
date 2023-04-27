// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

System.Console.WriteLine("Put any number: ");
int anyNum = int.Parse(Console.ReadLine());
for (int i = 1; i <= anyNum; i++) Console.Write($"{i * i} ");