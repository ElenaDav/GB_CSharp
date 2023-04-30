// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Put any number: ");

int anyNum = int.Parse(Console.ReadLine());
for (int i = 1; i <= anyNum; i++) Console.Write($"{i * i * i} ");