/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */
int PowNumber(int a, int b)
{
    return b == 1 ? a : a *= PowNumber(a, --b);
}

Console.Write("Введите число a: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numB == 0) Console.WriteLine(1);
else if ((numB == 1) || (numA == 1 || numA == 0)) Console.WriteLine(numA);
else Console.WriteLine(PowNumber(numA, numB));
