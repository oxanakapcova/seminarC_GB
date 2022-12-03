Console.Clear();
Console.WriteLine("Hello, Stepped Arrays!");
//int [,]myarray = new int[3,5];
int[][] steppedarray = new int[3][];
steppedarray[0] = new int[2];
steppedarray[1] = new int[5];
steppedarray[2] = new int[9];
Random random = new Random();
for (int i = 0; i < steppedarray.Length; i++)
{
    for (int j = 0; j < steppedarray[i].Length ; j++)//обращаемся к массиву
    { //с нужным нам индексом!!!
        steppedarray[i][j] = random.Next(10,100);
    }
}// заполнили массив случайными числами
for (int i = 0; i < steppedarray.Length; i++)
{
    for (int j = 0; j < steppedarray[i].Length; j++)
    {
        Console.Write(steppedarray[i][j]+"\t");
    }
    System.Console.WriteLine();
}//вывели на консоль в виде таблицы



//int rank = myarray.Rank;//покажет мерность массива//1

