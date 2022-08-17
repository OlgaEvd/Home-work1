//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите кол-во строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];


void CreateArray(int[,] array)

{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(9, 99);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("   ");
            if (j < arr.GetLength(1)) Console.Write(arr[i, j] + "   ");
            else Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}


void SumMiddle(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{sum / arr.GetLength(0)}   ");
    }
}

CreateArray(array);

PrintArray(array);

SumMiddle(array);