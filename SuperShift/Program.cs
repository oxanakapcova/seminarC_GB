Console.Clear();
Console.WriteLine("Hello, SuperShift!");
int[] myarray = { 5, 3, 7, 4, 6 };
int[] newarray = new int[5];
for (int i = 0; i <= 3; i++)
{
    newarray[0] = myarray[1];
    newarray[1] = myarray[2];
    newarray[2] = myarray[3];
    newarray[3] = myarray[4];
    newarray[4] = myarray[0];
}
System.Console.WriteLine($"[{string.Join(", ", newarray)}]");


