Console.Write("Введи число: ");

int number = int.Parse(Console.ReadLine()??"");

string numberString = Convert.ToString(number);

if (numberString.Length > 2)
{
  Console.WriteLine("Третья цифра:" + numberString[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}