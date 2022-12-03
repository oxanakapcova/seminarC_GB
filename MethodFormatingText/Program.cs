//замена символовов в тексте
Console.Clear();
Console.WriteLine("Hello, Methods!");

string text = "Однажды в студенную, зимнюю пору"
+" я из лесу вышел."
+" Был сильный мороз!"
+" Гляжу, поднимается медленно в гору"
+" лошадка, везущая хворосту воз....";
//string s = "qwerty";
//            012345
//s[3] is r
string replace(string text,  char oldValue, char newValue)
{
    string result = string.Empty;//0
    int length = text.Length;//длина строки, всего текста, как массив
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = replace(text, ' ','|' );
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = replace(newText, 'л', 'Л');
System.Console.WriteLine(newText);


