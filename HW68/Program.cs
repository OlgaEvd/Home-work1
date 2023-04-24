// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

int m = InputNumbers("Введите число m: ");
int n = InputNumbers("Введите число n: ");

int functionAkkerman = Akk(n, m);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Akk(n - 1, 1);
    else return Akk(n - 1, Akk(n, m - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}