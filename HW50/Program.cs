//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

Console.Write("Введите кол-во строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());


Console.Write("Введите строку:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;


int[,] arr = new int[n, m];


void CreateArrayInt(int[,] arr)
{
var rnd =  new Random ();
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(9, 99);
        }
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

void Position (int [,]arr)
{

if (pos1 < 0 || pos1 > arr.GetLength(0) - 1 || pos2 < 0 || pos2 > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadLine();
}

Console.WriteLine("Исходный массив:");
CreateArrayInt(arr);
PrintArray(arr);
Position (arr);

