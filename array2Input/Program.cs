Console.Clear();
Console.WriteLine("Hello, Array Input!");
int [,] myarray;
int line, column;
System.Console.WriteLine("Enter amount of lines: ");
line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter amount of columns: ");
column = Convert.ToInt32(Console.ReadLine());
myarray = new int [line,column];

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        System.Console.Write("Y"+i+"; X"+j+"\t");
        myarray[i,j] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine();
}//заполнили массив с консоли

for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1) ; j++)
    {
       System.Console.Write(myarray[i,j]+"\t"); 
    }
    System.Console.WriteLine();
}//вывели на консоль массив