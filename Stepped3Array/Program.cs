// многомерные массивы
Console.WriteLine("Hello, Stepped Arrays!");
Console.Clear();
int[,,] steppedArray = new int[2, 3, 5];
//                          pages, lines, columns
int[,,] newstepped =
{
    {
        {2,9,89},
        {1,8,23}
    },
    {
        {4,23,56},
        {1,4,1}
    }
};// manual initialization of stepped array
System.Console.WriteLine(newstepped[1, 0, 2]);
//use loop for(какая размерность столько и циклов)
int[,,] loops = new int[2, 3, 4];
Random random = new Random();
for (int i = 0; i < loops.GetLength(0); i++)
{
    for (int j = 0; j < loops.GetLength(1); j++)
    {
        for (int k = 0; k < loops.GetLength(2); k++)
        {
            loops[i, j, k] = random.Next(100);
        }
    }
}
for (int i = 0; i < loops.GetLength(0); i++)
{
    System.Console.WriteLine("Pages number is " + (i + 1));
    for (int j = 0; j < loops.GetLength(1); j++)
    {
        for (int k = 0; k < loops.GetLength(2); k++)
        {
            System.Console.Write(loops[i, j, k] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
