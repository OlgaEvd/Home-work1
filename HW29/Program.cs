//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, 
//заполненный псевдослучайными числами и выводит их на экран.

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] arr = new int[8];

void PrintArr(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(0, 8);

        Console.Write($"{array[i]} ");
    }
}

PrintArr(arr);
Console.WriteLine("]");
