﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

void CreateArrayDouble(double[,] array)
{
    var rnd =  new Random ();
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = rnd.NextDouble()*20;
    }
  }
}

void PrintArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double Number = Math.Round(array[i, j], 1);
        Console.Write(Number + "   ");
      }
      Console.WriteLine();
  }
}

CreateArrayDouble(array);

PrintArray(array);

Console.WriteLine();