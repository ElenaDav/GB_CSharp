// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int x = ReadInt("x");
int y = ReadInt("y");

if (isCoordinatesCorrect(x, y))
  Console.WriteLine(GetQuarter(x, y));
else
  Console.WriteLine("Oooops");


int ReadInt(string argument)
{
  Console.Write($"Input {argument}: ");

  int i;

  while (!int.TryParse(Console.ReadLine(), out i))
  {
    Console.WriteLine("it's not a number");
  }

  return i;
}

int GetQuarter(int x, int y)
{
  if (x > 0 && y > 0)
  {
    return 1;
  }
  else if (x < 0 && y > 0)
  {
    return 2;
  }
  else if (x < 0 && y < 0)
  {
    return 3;
  }
  else
  {
    return 4;
  }
}

bool isCoordinatesCorrect(int x, int y)
{
  if (x == 0 || y == 0)
  {
    return false;
  }
  return true;
}