Console.WriteLine("Введите номер четверти: ");
string quarter = int.Parse(Console.ReadLine()) switch{
    1 => "x > 0, y > 0",
    2 => "x < 0, y > 0",
    3 => "x < 0, y < 0",
    4 => "x > 0, y < 0",    
    _=> "Четвертей только 4"
};
Console.WriteLine(quarter);
