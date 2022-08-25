Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число (проверим, является ли оно квадратным корнем из первого): ");
int b = int.Parse(Console.ReadLine());
bool flag = (b * b == a);
if (flag) 
{
    Console.WriteLine($"Первое число {a} является квадратом второго числа {b}");
}
else 
{
    Console.WriteLine($"Первое число {a} НЕ является квадратом второго числа {b}");

}