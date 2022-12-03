Console.Clear();
Console.WriteLine("Hello, Method Return!");
int date()
{
    return DateTime.Now.Year;//покажет текущий год
}
int year = date();
System.Console.WriteLine(year);//вызываем переменную в которую сохранили
//выше описанный метод