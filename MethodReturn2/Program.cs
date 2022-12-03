Console.Clear();
Console.WriteLine("Hello, Method Return!");
string Method(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string res = Method(10, "(-)");
System.Console.Write(res);
/*
создать метод: тип данных Метод();
описать метод: {}
сохранить в переменную: тип_данных имя = Метод(ввести значения,);
вызывать
*/
