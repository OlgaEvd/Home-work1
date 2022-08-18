//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//массив размером 2 x 2 x 2

//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите размер трёхмерного массива [X, Y, Z]: ");
Console.WriteLine ("");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

int maxNum = 89;//При значении больше выдают ошибку

if (x * y * z > maxNum)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[maxNum];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}

void PrintMassive3D (int[,,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {arr[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
}

int[,,] resultNums = Create3DMassive(x, y, z);
PrintMassive3D (resultNums);



