Console.Clear();
Console.Write("Введите кол-во кустов: ");
int countBushes = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[countBushes];
int resultSumma = 0;

for (int i = 0; i < arrayFirst.Length; i++)
arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < arrayFirst.Length - 1; i++)
{
if (arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1] > resultSumma)
resultSumma = arrayFirst[i - 1] + arrayFirst[i] + arrayFirst[i + 1];
}
if (arrayFirst[0] + arrayFirst[1] + arrayFirst[countBushes - 1] > resultSumma)
resultSumma = arrayFirst[0] + arrayFirst[1] + arrayFirst[countBushes - 1];

if (arrayFirst[0] + arrayFirst[countBushes - 1] + arrayFirst[countBushes - 2] > resultSumma)
resultSumma = arrayFirst[0] + arrayFirst[countBushes - 1] + arrayFirst[countBushes - 2];

Console.WriteLine(resultSumma);
