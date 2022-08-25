Console.WriteLine("Введите номер дня недели, а я подскажу, выходной ли это: ");
int dayofweek = int.Parse(Console.ReadLine()) switch{
    > 0 and < 6 => "Рабочий день",    
    >= 6 and <= 7 => "Да, это выходной, гоу отдыхать",    
    _=> "Неверно указан день"
};
Console.WriteLine(dayofweek);
