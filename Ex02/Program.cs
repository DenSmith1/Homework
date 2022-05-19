// Домашнее задание 1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(2);
//     Console.Write($"{array[i]} ");
// }


// Домашнее задание 2. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

// int[] array = new int[12];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 9);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine("");

// int SumPoz = 0;
// int SumNeg = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) 
//     {
//         SumPoz = SumPoz + array[i];
//     }
//     else 
//         SumNeg = SumNeg + array[i];
// }

// Console.WriteLine($"Сумма положительных элементов массива = {SumPoz}");
// Console.WriteLine($"Сумма отрицательных элементов массива = {SumNeg}");


// Домашнее задание 3. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

// Console.Write("Введите размер массива: ");
// int arrSize =  int.Parse(Console.ReadLine() ?? "0");

// int[] array = new int[arrSize];
// for (int i=0; i<arrSize; i++)
// {
//     array[i] =  new Random().Next(100,999);
//     Console.Write($"{array[i]} ");
// }

// Console.WriteLine ("");

// int Chet = 0;
// int NeChet = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]%2 == 0) Chet = Chet +1;  
//     else NeChet = NeChet +1;
// }
// Console.WriteLine ($"Четных чисел - {Chet}");
// Console.WriteLine ($"Нечетных чисел - {NeChet}");


// Домашнее задание 4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] array = new int[123];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 100);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine("");
// int Count=0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i]>=10 && array[i]<=99)
//     {
//         Count++;
//     }
// }
//  Console.WriteLine ($"Количество элементов отрезка [10,99] = {Count}");

// Домашнее задание 5. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Write("Введите размер массива: ");
int arrLength = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[arrLength];

for (int i = 0; i < arrLength; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine("");

for (int i = 0; i < arrLength/2; i++)
{
    Console.WriteLine($"Произведение {array[i]} и {array[arrLength-i-1]} = {array[i] * array[arrLength-i-1]}");
}

