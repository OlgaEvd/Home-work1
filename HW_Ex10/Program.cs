// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Программа, которая выдаёт вторую цифру трехзначного числа");
Console.WriteLine("");
Console.Write("Введите трехзначное число : ");

void SecondNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    string result = Convert.ToString(num);
    Console.WriteLine("Вторая цифра этого числа -> " + result[1]);
}
SecondNumber();