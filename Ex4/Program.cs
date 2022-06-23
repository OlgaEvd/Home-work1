// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine(    );
Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max)max=b;
if (c>max)max=c;

Console.WriteLine($"{max} максимальное число:", max);