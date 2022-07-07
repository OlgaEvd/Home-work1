//задача 31 Задать массив и 12 элементов
// промежуток [-9, 9]
//сумма отрицательных и положит элементов массива

//int[] array = new int[12];
//var rnd = new Random();
//int index = 0;
//while(index < array.Length)
//{
//  array[index] = rnd.Next(-9, 10);
//    Console.Write($"{array[index]} ");
//index++;
//}
//int sumPos = 0;
//int sumNeg = 0;
//for(int i = 0; i < array.Length; i++)
//{
//if (array[i] < 0)
//{
//   sumNeg = sumNeg + array[i];
//}
//else
//{
// sumPos  = sumPos+array[i];
//}
//}
//Console.WriteLine();
//Console.WriteLine($"Сумма положительных чисел равна: {sumPos}");
//Console.WriteLine($"Сумма отрицательных чисел равна: {sumNeg}");

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();
    int index = 0;

    while (index < array.Length)
    {
        array[index] = rnd.Next(-9, 10);
        index++;
    }
    return array;
}

int[] GetSumNegPosElem(int[] arr)
{
    int sumPos = 0;
    int sumNeg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumNeg = sumNeg + arr[i];
        }
    else
    {
        sumPos = sumPos + arr[i];
    }
        }
    return new[] {sumPos, sumNeg};
}

void printArray(int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < arr.Length - 1) Console.Write(arr[i] + ",");
    else Console.Write(arr[i] + "]");
}

}
int [] array = CreateArrayRndInt(12);
printArray(array);
int [] getSumNegPosElem = GetSumNegPosElem(array);

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел равна: {getSumNegPosElem[0]}");
Console.WriteLine($"Сумма отрицательных чисел равна: {getSumNegPosElem[1]}");