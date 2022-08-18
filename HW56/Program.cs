//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void LineMin (int[,] arr)
{
int minsum = Int32.MaxValue;
int indexLine = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("Строка с наименьшей суммой элементов №: " + (indexLine) + ", сумма равна: " + (minsum));


}

int [,] matrix =  CreateArrayInt(m,n, 1, 9);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
LineMin (matrix);
