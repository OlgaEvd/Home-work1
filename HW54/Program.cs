//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:  В итоге получается вот такой массив:
//1 4 7 2                    7 4 2 1
//5 9 2 3                    9 5 3 2
//8 4 2 4                    8 4 4 2
Console.Write("Введите кол-во строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());


int [,] CreateArrayInt(int n, int m, int min, int max)
{
    int[,] array = new int[m, n];
    var rnd =  new Random ();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(min, max+1);
        }
    }
    return array;
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

void SortLineMaxMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int c = 0; c < arr.GetLength(1) - 1; c++)
        {
            if (arr[i, c] < arr[i, c + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = arr[i, c];
                arr[i, c] = arr[i, c + 1];
                arr[i, c + 1] = temp;
            }
        }
    }
}
}

int [,] matrix =  CreateArrayInt(m,n, 10, 99);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
Console.WriteLine("Массив с упорядоченными значениями (От большего к меньшему)");
SortLineMaxMin(matrix);
PrintArray(matrix);
