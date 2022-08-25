Console.WriteLine("Введите номер дня недели");
string dayofweek = int.Parse(Console.ReadLine()) switch{
    1 => "Понедельник",
    2 => "Вторник",
    3 => "Среда",
    4 => "Четверг",
    5 => "Пятница",
    6 => "Суббота",
    7 => "Воскресенье",
    _=> "Неверно указан день"
};
Console.WriteLine(dayofweek);