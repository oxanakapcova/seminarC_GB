Console.WriteLine("Hello, array Random!");
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < 8; i++)
array[i] = new Random().Next(0, 2);//диапозон от первого включительно
//до второго не включая
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
