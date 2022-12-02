Console.Clear();
Console.WriteLine("Hello, Array!");
//вывод в формате строки
string [,] myarray = new string [3,5];

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        System.Console.WriteLine("Y: "+i+" x: "+j);
        myarray[i,j]= Console.ReadLine();
    }
}
System.Console.WriteLine();//для красоты вывода
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
      System.Console.Write(myarray[i,j]+"\t\t");  
    }
    System.Console.WriteLine();
}
