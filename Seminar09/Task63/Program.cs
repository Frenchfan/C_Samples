// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
void ShowNumbers(int digit, string linetoPrint) 
{
    if (digit == 1) 
    {        
        linetoPrint = digit.ToString() + linetoPrint;
        Console.Write($"{linetoPrint}");
    }
    else 
    {
        linetoPrint = ", " + digit.ToString() + linetoPrint;
        ShowNumbers(digit - 1, linetoPrint);
    }
}
void NumbersRec(int n, int current = 1)
{
    Console.Write(current);
    if (current < n)
    {
        Console.Write(", ");
        NumbersRec(n, ++current);
    }
}

Console.Write("Введите число n: ");
int number = Convert.ToInt32(Console.ReadLine());
NumbersRec(number);



Console.WriteLine("\nВведите число > 1");
int digit = int.Parse(Console.ReadLine());
if (digit < 1) 
{
    Console.WriteLine("Нужно было ввести число > 1");
}
else
{
    ShowNumbers(digit, "");
}