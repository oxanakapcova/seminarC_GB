Console.Clear();
Console.WriteLine("Hello, Nested Loops!");

for (int i = 1; i <= 10; i++)
{
    for (int j = 5; j <= 10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i*j}");
    }
    System.Console.WriteLine();
}
