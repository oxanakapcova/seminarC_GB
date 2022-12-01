Console.Clear();
Console.WriteLine("Hello, Math_Pow!");
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
НЕ ИСПОЛЬЗОВАТЬ MATH.POW
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
System.Console.WriteLine("Enter number A:\t");
ulong a = ulong.Parse(Console.ReadLine());
System.Console.WriteLine("Enter pow number:\t");
ulong b = ulong.Parse(Console.ReadLine());
ulong result =1;
for (ulong i = 0; i <b; i++)
{
    result =result * a;
}
System.Console.WriteLine("Result is:\t"+result);
//если число будет очень большое то вернется 0