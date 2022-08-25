Console.WriteLine("Введите координаты первой точки, сначала - x: ");
int firstx = int.Parse(Console.ReadLine());
Console.WriteLine("теперь - y: ");
int firsty = int.Parse(Console.ReadLine());
Console.WriteLine("теперь - z: ");
int firstz = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки, сначала - x: ");
int secondx = int.Parse(Console.ReadLine());
Console.WriteLine("теперь - y второй точки: ");
int secondy = int.Parse(Console.ReadLine());
Console.WriteLine("теперь - z: ");
int secondz = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(firstx - secondx, 2) + Math.Pow(firsty - secondy, 2) + Math.Pow(firstz - secondz, 2));
Console.WriteLine($"Расстояние между точками ({firstx},{firsty},{firstz}) и ({secondx},{secondy},{secondz}) составляет {distance:f2}");

