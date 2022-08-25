Console.WriteLine("Введите пятизначное число - проверим, палиндром ли это: ");
int inputdigit = int.Parse(Console.ReadLine());
int firstdigit = 0;
int reversedigit = 0;
int temp = inputdigit;
for (int i = 4; i >= 0; i--)
{
    firstdigit = temp % 10;
    reversedigit += Convert.ToInt32(firstdigit * Math.Pow(10, i));
    temp = temp / 10;
}
Console.WriteLine("Проверили: " + (reversedigit ==  inputdigit ? "Это палиндром" : "Это НЕ палиндром"));
