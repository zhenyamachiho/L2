Console.WriteLine("Введите число обозначающее день недели: ");
int a = int.Parse(Console.ReadLine()??"");

if (a == 6 || a == 7) Console.WriteLine("Выходной");
else Console.WriteLine("Не выходной");