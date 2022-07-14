//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0



int sum = 0;
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


int SumIndexNechet(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + arr[i];
    }
    return sum;
}


int[] array = CreateArray(4);
Console.WriteLine();

int sumresult = SumIndexNechet(array);
Console.WriteLine(sum);
