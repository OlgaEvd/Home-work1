//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//-1, -7, 567, 89, 223-> 3

Console.Write($"Введи число М (количество целых чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNum = new int[m];

void Numbers(int m)
{

for (int i = 0; i < m; i++)
  {
    Console.WriteLine($"Введи {i+1} число: ");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int SumPosNum(int[] arrayNum)
{
  int count = 0;
  for (int i = 0; i < arrayNum.Length; i++)
  {
    if(arrayNum [i] > 0 ) count += 1; 
  }
  return count;
}

Numbers(m);

Console.WriteLine($"Введено чисел больше нуля: {SumPosNum (arrayNum)} ");


