Console.Clear();
Console.WriteLine("Hello, Amount of numbers elements");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int size = 1;
while (n / 10 != 0)
{
n /= 10;
size++;
}
Console.WriteLine(size);