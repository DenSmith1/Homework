// Домашнее задание 1. Показать таблицу квадратов чисел от 1 до N

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");

// for (int i = 1; i <= Number; i++)
//     Console.WriteLine($"Квадрат числа {i} = {i*i} ");



// Домашнее задание 2. Найти кубы чисел от 1 до N

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");

// for (int i = 1; i <= Number; i++)
//     Console.WriteLine($"Куб числа {i} = {i*i*i} ");         // Math.Pow(i,3)



// Домашнее задание 3. Найти сумму чисел от 1 до N

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");

// int Sum = 0;
// for (int i = 1; i <= Number; i++) Sum = Sum + i;

// Console.WriteLine($"Сумма чисел от 1 до {Number} = {Sum} "); 


// Домашнее задание 4. Возведите число А в натуральную степень B используя цикл.

// Console.Write("Введите число: ");
// int NumberA = int.Parse(Console.ReadLine() ?? "0");

// Console.Write("Введите степень: ");
// int NumberB = int.Parse(Console.ReadLine() ?? "0");

// int Pow = 1;
// for (int i = 1; i <= NumberB; i++) Pow = Pow * NumberA;

// Console.WriteLine($" {NumberA} в степени {NumberB} = {Pow} "); 


// Домашнее задание 5. Подсчитать сумму цифр в числе

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");

// int Sum = 0;
// while (Number > 0)
// {
//     Sum = Sum + Number % 10;
//     Number = Number / 10;
// }

// Console.Write($"Сумма цифр в числе = {Sum}");


// Домашнее задание 6. Показать кубы чисел, заканчивающихся на четную цифру

// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");

// for (int i = 1; i <= Number; i++)
//     if (Math.Pow(i, 3) % 2 == 0) Console.WriteLine($"Куб числа {i} = {Math.Pow(i, 3)} ");



// Домашнее задание 7. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(2);
    Console.Write($"{array[i]} ");
}