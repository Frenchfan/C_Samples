// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
void Fibonacci(int amount) 
{
    int[] myArray = new int[amount];
    myArray[0] = 0;
    myArray[1] = 1;
    for (int i = 2; i < amount; i++)
    {
        myArray[i] = myArray[i-1] + myArray[i-2];
    }
    Console.WriteLine($"Последовательность Фибоначчи {String.Join(" ", myArray)}");
}

Console.WriteLine("Введите число");
int amount = int.Parse(Console.ReadLine());
Fibonacci(amount);