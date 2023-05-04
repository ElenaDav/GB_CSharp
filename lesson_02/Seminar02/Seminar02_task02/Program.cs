// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//Первый вариант решения

int random = new Random().Next(100, 1000);
Console.WriteLine(random);
int delete = 2;
string str = random.ToString();
random = int.Parse(str.Remove(str.Length - delete, 1));
Console.WriteLine(random);

//Второй вариант решения

int random02 = new Random().Next(100, 1000);
Console.WriteLine(random02);
int firstNum = random02 / 100;
// int secondNum = (random / 10) % 10;
// Console.WriteLine(secondNum);
int thirdNum = random02 % 10;
Console.WriteLine($"Число без второй цифры: {firstNum}{thirdNum}");
