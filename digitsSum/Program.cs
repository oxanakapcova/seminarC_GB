/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Sum of digits!");
System.Console.Write("Enter number:\t");
int value = Convert.ToInt32(Console.ReadLine());
int sumDigits = 0;
while(value>=1)
{
sumDigits += value%10;
value = (value - value%10)/10;
}
System.Console.WriteLine(sumDigits);