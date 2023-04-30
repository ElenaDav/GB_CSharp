// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int digit = ReadInt("digit");
string digitStr = digit.ToString();

void CheckingNumber(string digitStr){
  if (digitStr[0]==digitStr[4] || digitStr[1]==digitStr[3]){
    Console.WriteLine($"Your number: {digitStr} - NOT a polindrome.");
  }
  else Console.WriteLine($"Your number: {digitStr} - IS a polindrome!");
}

if (digitStr.Length == 5){
  CheckingNumber(digitStr);
}
else Console.WriteLine($"Put a five-digits number");

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