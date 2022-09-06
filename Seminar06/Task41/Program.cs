// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int CountPositive(int[] myArray) 
 {
    int counter = 0;
    foreach (int i in myArray) 
    {
        if (i > 0) counter++;
    }
    return counter;  
 }
int[] InputChain(int digit)
{
    int[] result = new int[digit];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент последовательности");
        result[i] = int.Parse(Console.ReadLine());
    }
    return result;
} 
int CountPositiveNoArray(int digit) 
 {
    int result = 0;
    for (int i = 1; i <= digit; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент последовательности");
        int inputdigit = int.Parse(Console.ReadLine());
        if (inputdigit > 0) result++;
    }
    return result; 
 }
Console.WriteLine("Вариант 1 - с массивом");
Console.WriteLine("Введите кол-во чисел: ");
int digitM = int.Parse(Console.ReadLine());
Console.WriteLine($"В последовательности {CountPositive(InputChain(digitM))} положительных элемента (-ов)");
Console.WriteLine("Вариант 2 - без массива (что гораздо проще :)");
Console.WriteLine("Введите кол-во чисел: ");
digitM = int.Parse(Console.ReadLine());
Console.WriteLine($"В последовательности {CountPositiveNoArray(digitM)} положительных элемента (-ов)");