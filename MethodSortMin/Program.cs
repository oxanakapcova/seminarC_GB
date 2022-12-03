// Сортировка массива от макс к мин, заполнение случайными числами,
//задание длинны массива пользователем
Console.WriteLine("Hello, Methods!");
int [] myarray;
System.Console.WriteLine("Enter amount of elements: ");
myarray = new int [Convert.ToInt32(Console.ReadLine())];
//запросили у пользователя количество элементов массива
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i]=new Random().Next(100);
}
System.Console.WriteLine($"[{string.Join(", ",myarray)}]");
System.Console.WriteLine();
//заполнили случайными числами
void SelectionSort(int[]array)//создали и назвали метод
{
    for (int i = 0; i < array.Length ; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length ; j++)
        {
            if (array[j]>array[maxPosition])
            maxPosition = j;
            
        }//логика метода
    int temporary = array[i];
    array[i]=array[maxPosition];
    array[maxPosition]=temporary;
    }
}

SelectionSort(myarray);
System.Console.WriteLine($"[{string.Join(", ",myarray)}]");