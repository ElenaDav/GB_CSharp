// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y)

int quarter = ReadNum("number");
// string coordinateX, coordinateY;

if (isCoordinatesCorrect(quarter))
  Console.WriteLine(GetCoordinate(coordinateX, coordinateY));
else
  Console.WriteLine("Oooops");

int ReadNum(string argument)
{
  Console.Write($"Put a number from 1 to 4 {argument}: ");
  int i;
  while (!int.TryParse(Console.ReadLine(), out i))
  {
    Console.WriteLine("it's not a number");
  }
  return i;
}

int GetCoordinate(string coordinateX, string coordinateY)
{
  int num;

  if (num == 1)
  {
    coordinateX = "from 0 to +infinity";
    coordinateY = "from 0 to +infinity";
  }
  else if (num == 2)
  {
    coordinateX = "from -infinity to 0";
    coordinateY = "from 0 to +infinity";
  }
    else if (num == 3)
  {
    coordinateX = "from -infinity to 0";
    coordinateY = "from -infinity to 0";
  }
  else
  {
    coordinateX = "from 0 to +infinity";
    coordinateY = "from -infinity to 0";
  }
}

bool isCoordinatesCorrect(int i)
{
  if (i < 1 || i > 4)
  {
    return false;
  }
  return true;
}