Console.Clear();
Console.WriteLine("Hello, Palindrome!");
System.Console.WriteLine("Enter 5digits number: ");
int value = int.Parse(Console.ReadLine());
while (value<10000 || value > 99999)
{
Console.WriteLine("Your number is not 5digits number.\nTry again!");
value = int.Parse(Console.ReadLine());
}
int value1 = value/10000;
int value2 = (value/1000)%10;
int value4 =(value%100)/10;
int value5 = value%10;

if (value1 ==value5 && value2 ==value4)
{
   System.Console.WriteLine("it is palindrome!"); 
}
else
{
    System.Console.WriteLine("it is not palindrome.");
}
