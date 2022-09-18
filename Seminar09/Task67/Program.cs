/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */
int SumRec(int n)
{
    return n == 0 ? 0 : n % 10 + SumRec(n / 10);
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = SumRec(num);
Console.WriteLine(sum);
