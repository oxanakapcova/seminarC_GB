// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Method void!");
/*void message(string msg)
{
    System.Console.WriteLine(msg);
}
message("text message");
*/
void message2(string msg, int count)
{
int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
message2(msg:"i want to see this",count: 5);