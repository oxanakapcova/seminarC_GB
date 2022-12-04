Console.Clear();
Console.WriteLine("Hello, Methods!");
//modificator|type|name|(arguments)
static        int  sum  (int value1, int value2)
{//method body
    int result = value1 + value2;//return v1+v2; |same but shorter
    return result;//ключевое слово которое впоследствии вызывается
}//created method sum

int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
//variable|= name of method|(arguments)|;
c          = sum            (a, b);
System.Console.WriteLine(c);//variable