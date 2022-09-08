//Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
Dictionary<char, int> map = new Dictionary<char, int>()
    {
        {'I', 1 },
        {'V', 5 },
        {'X', 10 },
        {'L', 50 },
        {'C', 100 },
        {'D', 500 },
        {'M', 1000 }
    };
int Parse(string roman)
{
    int result = 0;
    for (int i = 0; i < roman.Length; i++)
    {
        if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
        {
            result -= map[roman[i]];
        }
        else
        {
            result += map[roman[i]];
        }
    }
    return result;
}
bool IsSubtractive(char c1, char c2)
{
    return map[c1] < map[c2];
}
int arabicNumber;
Console.WriteLine("Введите римское число: ");
string roman = Console.ReadLine();
arabicNumber = Parse(roman);
Console.WriteLine($"Римскому числу {roman} соответствует арабское: {arabicNumber}");

