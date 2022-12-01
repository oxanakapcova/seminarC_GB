Console.Clear();
Console.WriteLine("Hello, Palindrome!");
System.Console.WriteLine("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = n;
int newNumber = 0, i = Convert.ToString(n).Length - 1;
while (i >= 0)
{
newNumber += (n % 10 * Convert.ToInt32(Math.Pow(10, i)));
n = n / 10;
i--;
}
Console.WriteLine(newNumber == result);