// Домашнее задание 1. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// Console.WriteLine("Введите значения для 1 прямой (y = k1 * x + b1): ");
// Console.Write("k1: "); int k1 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("b1: "); int b1 = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите значения для 2 прямой (y = k2 * x + b2): ");
// Console.Write("k2: "); int k2 = int.Parse(Console.ReadLine() ?? "0");
// Console.Write("b2: "); int b2 = int.Parse(Console.ReadLine() ?? "0");
// if (k1 != k2)
// {
//     int x = (b2 - b1) / (k1 - k2);
//     int y = (b1 * k2 - b2 * k1) / (k2 - k1);
//     Console.Write($"Координаты пересечения прямых: {x},{y}");
// }
// else Console.WriteLine("Прямые не пересекаются");



// Домашнее задание 2. Написать программу масштабирования фигуры

// void FillArray(int[] arr)
// {
//     string XY = "";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0) XY = "X";
//         else XY = "Y";
//         Console.Write($"Введите координаты {XY} {(i + 2) / 2} вершины: ");
//         arr[i] = int.Parse(Console.ReadLine() ?? "0"); ;
//     }
//     Console.WriteLine();
// }

// void ScaleArray(int[] arr, int Factor)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * Factor;
//     }
// }

// void PrintArray(int[] arr)
// {
//     string separator = "";

//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 == 0) separator = ",";
//         else separator = "  ";
//         Console.Write($"{arr[i]}{separator}");
//     }
// }

// Console.Clear();
// Console.WriteLine("Программа масштабирования фигуры.");
// Console.Write("Введите количество вершин Вашей фигуры: ");
// int Vertex = int.Parse(Console.ReadLine() ?? "0");
// bool VerTrue = false;
// while (VerTrue != true)
// {
//     if (Vertex > 2) VerTrue = true;
//     else
//     {
//         Console.Write("В фигуре должно быть больше 2х вершин, введите еще раз: ");
//         Vertex = int.Parse(Console.ReadLine() ?? "0");
//     }
// }


// int[] array = new int[Vertex * 2];
// FillArray(array);

// Console.Write("Введите масштаб: ");
// int Scale = int.Parse(Console.ReadLine() ?? "0");

// ScaleArray(array, Scale);

// Console.WriteLine();
// Console.WriteLine("Координаты вершин новой фигуры: ");
// PrintArray(array);



// Домашнее задание 3. Написать программу копирования массива

void FillArrayRandom(int[] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue,maxValue);
    }
}
void FillArrayHand(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write ($"Введите значение {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    Console.WriteLine();
}
void PrintArray(int[] arr)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
void CopyArray (int[] arr, int[]copyarr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        copyarr[i] = arr[i];
    }
}

Console.Clear();
Console.WriteLine("Программа копирования массива");

Console.Write ("Введите размер массива: ");
int arrLength = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrLength];

Console.Write("Создать массив вручную (Y/N)? ");
string answer = Console.ReadLine() ?? "0";
if (answer.ToLower() == "y")
{
    FillArrayHand(array);
    PrintArray(array);
}
else 
{
    Console.Write ("Введите минимальное значение в массиве: ");
    int min = int.Parse(Console.ReadLine() ?? "0");
    Console.Write ("Введите максимальное значение в массиве: ");
    int max = int.Parse(Console.ReadLine() ?? "0");
    FillArrayRandom (array, min, max+1);
    PrintArray(array);
}
Console.WriteLine();
Console.Write("Создать копию массива (Y/N)? ");
answer = Console.ReadLine() ?? "0";
int[] arrCopy = new int[arrLength];
if (answer.ToLower() == "y")
{
    CopyArray(array, arrCopy);
    Console.WriteLine("Копия массива создана.");
    PrintArray (arrCopy);
}




