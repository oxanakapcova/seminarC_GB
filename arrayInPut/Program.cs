//Console.Clear();
Console.WriteLine("Hello, Array InPut!");
//программа будет работать для любой длины массива,
//который также введет пользователь
System.Console.WriteLine("Enter amount of elemets:\t");
int amount = int.Parse(Console.ReadLine());
int [] myarray = new int [amount];

for (int i = 0; i < myarray.Length; i++)
{
    System.Console.Write($"Enter number {i} :\t");
    myarray[i]=int.Parse(Console.ReadLine());
}
System.Console.WriteLine("\nYour array is:\t");
for (int i = 0; i < myarray.Length; i++)
{
    System.Console.WriteLine(myarray[i]);
}
