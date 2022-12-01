Console.Clear();
Console.WriteLine("Hello, Method!");
// Найти максимум среди 2-х чисел

int maxNumbers(int n, int m)
{
if (n > m)
return n;
return m;
}

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {maxNumbers(n, m)}");
