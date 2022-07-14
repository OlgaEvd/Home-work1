//Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


 Console.WriteLine("Введите число: ");
 int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
int[] array = new int [size];
var rnd = new Random();
int index = 0;

while (index < array.Length)
    {
        array[index] = rnd.Next(1,5);
        Console.Write($"{array[index]} ");
        index++;
    }
    return array;
}

string sort (int[] arr, int num)
{
string res = "Нет, массив не содержит данное число";

        for (int i = 0; i < arr.Length; i++)
    {       
        if (arr [i]  == num)
       res =  "Да, массив содержит данное число";
    } 
    return res;
}

int [] array = CreateArray(5);
Console.WriteLine();
string result = sort(array,number);
Console.WriteLine(result);