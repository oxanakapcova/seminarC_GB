// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Factorial!");
System.Console.WriteLine("Enter number: ");
int value = Convert.ToInt32(Console.ReadLine());
int Factorial = 1;
for (int i = 1; i<=value; i++)
{ 
    Factorial *= i;
}
System.Console.WriteLine(Factorial);


