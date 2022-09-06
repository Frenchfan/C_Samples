// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double[] GetCoord(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
} 
Console.WriteLine("!!!Для простоты проверки пользователь вводит только целые! числа, но в результате могут получиться и вещественные числа");
Console.WriteLine("Введите значение b1: ");
int digitb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
int digitk1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int digitb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int digitk2 = int.Parse(Console.ReadLine());
double[] newCoord = GetCoord(digitb1, digitk1, digitb2, digitk2);
Console.WriteLine($"Точка пересечения 2-х прямых, заданных уравнениями y = {digitk1}*x + {digitb1} и y = {digitk2}*x + {digitb2} имеет координаты ({newCoord[0]};{newCoord[1]})");