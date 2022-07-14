//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//Пример
//[345, 897, 568, 234] -> 2

int count = 0;
int[] CreateArray(int size)
{
int[] array = new int [size];
var rnd = new Random();
int index = 0;

while (index < array.Length)
    {
        array[index] = rnd.Next(100,999);
        Console.Write($"{array[index]} ");
        index++;
    }
    return array;
}

int sumPolElement(int [] arr)
{

   for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) 
    count = count + 1;
}
 return arr [count];
}




int [] array = CreateArray(4);
Console.WriteLine();
int sum = sumPolElement(array);
Console.Write(count);