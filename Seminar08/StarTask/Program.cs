﻿/* Задача со звездочкой. Написать функцию Sqrt(x) - квадратного корня, 
которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
Нельзя использовать встроенные функции библиотеки Math! */
/* Пояснение алгоритма - Если число целое, то можно вычитать из числа
 все нечетные числа по порядку, пока остаток не станет меньше 
 следующего вычитаемого числа или равен нулю, и посчитать 
 количество выполненных действий. Если число не является целым, 
 то таким образом можно узнать только целую часть числа.

Пример: число 25

25-1=24
24-3=21
21-5=16
16-7=9
9-9=0

Выполнено 5 действий, т.е. корень из 25 равен 5. */
int newSQRT(int digit)
{
    int result = 0;
    int a = 1;
    while (a <= digit)
    {
        digit -= a;
        a += 2;
        result += 1;
    }
    return result;
}
Console.WriteLine("Введите целое число для поиска целой части квадратного корня: ");
int digit = int.Parse(Console.ReadLine());
Console.WriteLine($"Целя часть квадратного корня от числа {digit}: {newSQRT(digit)}");
