// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет явялется ли этот день выходным.
// 6 -> да
// 6 -> да
// 1 -> нет

System.Console.WriteLine("Введите день недели: ");
int num = 0;
while (!int.TryParse(System.Console.ReadLine(), out num))
{
Console.WriteLine("This is not a number");
}

if (num == 6 || num == 7)
{
  Console.WriteLine("YES");
}
else if (num <= 5 && num > 0)
{
  Console.WriteLine("NO"); 
}
else
{
  Console.WriteLine("This is not a day of the week");
}