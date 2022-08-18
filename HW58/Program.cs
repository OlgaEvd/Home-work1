//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите размерность матриц: ");
int r = Convert.ToInt32(Console.ReadLine());


int[,] CreateArrayInt(int r, int min, int max)
{
    int[,] array = new int[r, r];
    var rnd = new Random();
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < r; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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


int[,] matrixA = CreateArrayInt(r, 1, 9);
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();


int[,] matrixB = CreateArrayInt(r, 1, 9);
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
 
 int[,] matrixC = new int [r,r];

void Product (int[,] arr)
{
for (int i = 0; i < r; i++)
{
    for (int j = 0; j < r; j++)
    {
        for (int k = 0; k < r; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
}


Console.WriteLine("Произведение двух матриц ");
Product(matrixC);
PrintArray(matrixC);
Console.WriteLine();

