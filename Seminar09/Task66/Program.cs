/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int NumbersSumUp(int m, int n)
{
    return m <= n ? m + NumbersSumUp(++m, n): 0;
}


Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в интервале [{numberM};{numberN}] составляет: {NumbersSumUp(numberM, numberN)}");