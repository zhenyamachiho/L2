Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()??"");

Console.WriteLine($"Вторая цифра: {a / 10 % 10}");
