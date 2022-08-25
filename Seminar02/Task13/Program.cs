Console.WriteLine("Введите не менее, чем трехзначное число");
int a = int.Parse(Console.ReadLine());
if (a < 100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    Console.WriteLine($"Третья цифра числа {a} справа налево - {a / 100 % 10}");
}

