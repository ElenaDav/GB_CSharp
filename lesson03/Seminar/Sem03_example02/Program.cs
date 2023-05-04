// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y)

int quarter = ReadNum("number");

if (isCoordinatesCorrect(quarter))
  Console.WriteLine(GetCoordinate(coordinates));
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

int GetCoordinate(string coordinates)
{
  if (quarter == 1)
  {
    Console.WriteLine($"coordinateX from 0 to +infinity, coordinateY from 0 to +infinity"); 
  }
  else if (quarter == 2)
  {
    Console.WriteLine($"coordinateX from -infinity to 0, coordinateY from 0 to +infinity"); 
  }
    else if (quarter == 3)
  {
    Console.WriteLine($"coordinateX from -infinity to 0, coordinateY from -infinity to 0"); 
  }
  else
  {
    Console.WriteLine($"coordinateX from 0 to +infinity, coordinateY from -infinity to 0"); 
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