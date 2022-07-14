//Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int count = 0;
int[] CreateArray(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(0, 100);
        Console.Write($"{array[index]} ");
        index++;
    }
    return array;
}


int sumElement(int [] arr)
{

   for (int j = 0; j < arr.Length; j++)
{
    if(arr[j] > 9 & arr[j] < 100) count = count + 1;
}
 return arr [count];
}


int[] array = CreateArray(123);
Console.WriteLine();

int sum = sumElement(array);
Console.Write(count);