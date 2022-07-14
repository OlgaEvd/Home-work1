//Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 
int[] CreateArray(int size)
{
int[] array = new int [size];
var rnd = new Random();
int index = 0;

while (index < array.Length)
    {
        array[index] = rnd.Next(-100,100);
        Console.Write($"{array[index]} ");
        index++;
    }
    return array;
}

  int[] Change(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = -arr[i];
        Console.Write($"{newArr[i]} ");
        }
    return newArr;
}
int [] array = CreateArray(4);
Console.WriteLine();
int[] array1 = Change(array);

