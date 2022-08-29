Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());

int MultiplyNums(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)
    {
        sum *= i;        
    }
    return sum;
}

Console.WriteLine($"{MultiplyNums(num)}");