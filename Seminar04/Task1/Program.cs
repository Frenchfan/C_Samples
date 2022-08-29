Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());

int GetNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;        
    }
    return sum;
}

Console.WriteLine($"{GetNums(num)}");