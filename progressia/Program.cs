Console.Clear();
Console.WriteLine("Hello, Progressia!");
Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Результат: {(n + 1) / 2 * n}");//формула прогрессии
//1+2+3+..+n=(n+1)/2*n; double!!!