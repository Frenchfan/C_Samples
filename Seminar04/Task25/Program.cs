//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!
int myPow(int number, int power)
{
    int res = number;
    for (int i = 2; i <= power; i++)
    {
        res *= number;
    }
    return res;
}

Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B (степень, в которую возводим A): ");
int pow = int.Parse(Console.ReadLine());
Console.WriteLine($"{myPow(num, pow)}");