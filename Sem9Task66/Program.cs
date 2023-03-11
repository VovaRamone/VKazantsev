// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message) {
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для печати в консоль
void PrintData(string message)
{
    Console.WriteLine(message);
}

// Рекурсивный метод для подсчета суммы натуральных элементов в промежутке от M до N с использованием тернарного опреатора
int RecSumDigMN(int m, int n)
{
    return m >= n ? m : m + RecSumDigMN(m + 1, n);
}

// Просим пользователя ввести нужные данные
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

// Положим в переменную sum результирующее число из метода RecSumDigMN
int sum = RecSumDigMN(m, n);
// Вывод результата в консоль        
PrintData($"Сумма натуральных элементов между числом {m} и числом {n} равна {sum}");
