/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9 */
int Akkerman(int n, int m)
{
    if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}


Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для {numberN} и {numberM} составляет: {Akkerman(numberN, numberM)}");