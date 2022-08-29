Console.WriteLine("Введите число А: ");
int num = int.Parse(Console.ReadLine());

int HowManyDigits(int number)
{
    int digits = 0;    
    while (number > 1) {
        number /= 10;
        digits++;
    }
    return digits;
}

Console.WriteLine($"{HowManyDigits(num)}");