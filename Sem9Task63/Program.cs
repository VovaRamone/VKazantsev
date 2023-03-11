// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// LineGenRec(5)
// LineGenRec(4)
// LineGenRec(3)
// LineGenRec(2)
// LineGenRec(1)

void LineGenRec(int num)
{
    Console.Write(num + " ");
    if (num == 1)
    {        
    }
    else
    {
        LineGenRec(num - 1); 
    }       
}

int number  = ReadData("Введите число N: ");
LineGenRec(number);


