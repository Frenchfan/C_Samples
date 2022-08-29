//Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число для подсчета суммы цифр: ");
int num = int.Parse(Console.ReadLine());

int SummingDigits(int number)
{
    int sum = 0;    
    while (number > 1) 
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine($"{SummingDigits(num)}");
