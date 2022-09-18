/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */
void NumbersRec(int m, int n)
{
    Console.Write(m);
    if (m < n)
    {
        Console.Write(", ");
        NumbersRec(++m, n);
    }
}
void ShowNumbers(int start, int end, string linetoPrint)
{
    if (start == end)
    {
        linetoPrint = start.ToString() + linetoPrint;
        Console.Write($"{linetoPrint}");
    }
    else
    {
        linetoPrint = ", " + end.ToString() + linetoPrint;
        ShowNumbers(start, end - 1, linetoPrint);
    }
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NumbersRec(numberM, numberN);

Console.WriteLine("\nВведите число M: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int end = int.Parse(Console.ReadLine());
ShowNumbers(start, end, "");
