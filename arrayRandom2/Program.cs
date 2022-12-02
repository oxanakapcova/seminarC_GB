Console.Clear();
Console.WriteLine("Hello, Random Array!");
int [,] myarray = new int[3,4];
Random myrandom = new Random();//переменная 
for (int h = 0; h < myarray.GetLength(0) ; h++)
{
    for (int w = 0; w < myarray.GetLength(1); w++)
    {
        myarray[h,w] = myrandom.Next(100);//заполнили переменной случайными
    }//числами до 100
}
for (int h = 0; h < myarray.GetLength(0) ; h++)
{//в этой части вывод на консоль
    for (int w = 0; w < myarray.GetLength(1) ; w++)
    {
        System.Console.Write(myarray[h,w]+"\t");
    }
    System.Console.WriteLine();//отделяет строки
}
