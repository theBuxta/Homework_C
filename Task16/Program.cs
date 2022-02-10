// Дано число обозначающее день недели 
// Выяснить является номер дня недели выходным

int a = int.Parse(Console.ReadLine());
Console.WriteLine(day(a)); 
string day(int a)
{
    if(a == 6 || a == 7) 
    return $"{a} - выходной день";
    
    else if(a < 1 || a > 7)
    return $"{a} - некорректно введен день недели";
    
    else 
    return $"{a} - рабочий день";  
}