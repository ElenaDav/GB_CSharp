// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int digit = ReadInt("digit");
string digitStr = digit.ToString();

int ReadInt(string digit)
{
    Console.WriteLine($"Put a {digit}: ");
  int num;
  while (!int.TryParse(System.Console.ReadLine(), out num))
  {
  Console.WriteLine("This is not a number");
  }
  return num;
}

if (isFiveDigits(digit))
{
  Console.WriteLine(GetDigits(digitStr));
}
else
Console.WriteLine("Oooops");

int digitLength = (int)Math.Log10(digit) + 1;

bool isFiveDigits(int digitLength)
{
  if (digitLength > 5 || digitLength < 5)
  {
    return false;
  }
  return true;
}

int GetDigits(string digitStr)
{
  int result = digitStr;
  if (digitStr[0] == digitStr[4] && digitStr[1] == digitStr[3])
  {
    Console.WriteLine("It is true");
  }
  else
  {
    Console.WriteLine("It is not true");
  }
  return result;
}