Console.Clear();
Console.WriteLine("Hello, Methods!");
int [] myarray = { 8, 2, 0, 1, 8, 4, 0, 3, 6};
void PrintArray(int [] array)//подпрограмма, выводит элементы массива
{// на экран(любого какой укажем в имени)
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");//без пробела, сольется
    }
    System.Console.WriteLine();
}
void SelectionSort(int[]array)//метод сортировки массива, будет
{//работать с любым именем массива
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j]< array[minPosition]) minPosition =j;
        }
    int temporary = array[i];
    array[i]=array[minPosition];
    array[minPosition]=temporary;
    }
}
PrintArray(myarray);//вызов подпрограммы
SelectionSort(myarray);
PrintArray(myarray);
