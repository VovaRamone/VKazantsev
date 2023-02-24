﻿// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// Ввести с клавиатуры длину массива и диапазон значений элементов.

// Создаём метод, который считывает с консоли сообщение и возвращает число типа int
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Создаём метод, который будет генерировать массив (входные значения: длина массива, минимальное и максимальное значение массива)
int[] GenerateArray(int length, int minValue, int maxValue)
{
    // Создаём массив, выделяем под него новый объект. В массив положим длину массива, которую введем в консоль
    int[] arr = new int[length];
    // Создаём переменную rand, выделяем под неё новый объект. Переменная будет генерировать случайное значение.
    Random rand = new Random();
    // Создаём цикл for для определения длины массива
    for (int i = 0; i < length; i++)
    {
        // В массив ложим следующее случайное минимальное либо максимальное число
        arr[i] = rand.Next(minValue, maxValue + 1);
    }
    // Возвращаем результат
    return arr;
}
// Создаём метод для вывода полученного результата в консоль
void PrintArray(int[] arr)
{
    // Выводим сообщение в консоль
    Console.Write("Элементы массива: [");
    // Создаём цикл for для заполнения массива данными
    for (int i = 0; i < arr.Length; i++)
    {
        // Выводим сообщение в консоль
        Console.Write(arr[i]);
        // Создаём цикл if для проверки равняется ли число i длине массива
        if (i != arr.Length - 1)
        {
            // если нет, выводим сообщение в консоль
            Console.Write(", ");
        }
    }
    // По завершению цикла for выводим сообщение в консоль
    Console.WriteLine("]");
}

// Просим ввести длину массива, а также минимальный и максимальный элемент массива
int length = ReadData("Введите длину массива: ");
int minValue = ReadData("Введите минимальное значение для элементов массива: ");
int maxValue = ReadData("Введите максимальное значение для элементов массива: ");

// Присваиваем целочисленному массиву arr, значения из метода GenerateArray
int[] arr = GenerateArray(length, minValue, maxValue);
// Выводим результат в консоль.
PrintArray(arr);
    
