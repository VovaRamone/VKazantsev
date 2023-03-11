﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для печати в консоль
void PrintData(string message)
{
    Console.WriteLine(message);
}

// Создаём рекурсивный метод для вычисления функции Аккермана
int Ackermann(int m, int n)
{
    // Если число m или n равно 0, то метод возвращает соответсвующее значение
    if (m == 0)
    {
        return n + 1;
    }    
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    // В противном случае, метод вызывает сам себя рекурсивно с измененными параметрами, пока не будет выполнено условие выше
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

// Просим пользователя ввести нужные данные
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
// Положим в переменную result результирующее число из метода Ackermann
int result = Ackermann(m, n);
// Вывод результата в консоль  
PrintData($"Результирующая метода функции Аккермана равна: {result}");