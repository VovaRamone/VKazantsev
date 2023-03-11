// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

// Метод для считывания сообщения с консоли, который возвращает число
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод для печати
void PrintData(string message)
{
    Console.WriteLine(message);
}

string RecMN(int m, int n)
{
    string res = String.Empty;
    if (m >= n)
    {
        res = n.ToString();
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);        
    }
    return res;    
}

int number1  = ReadData("Введите число N: ");
int number2  = ReadData("Введите число N: ");
string resultLine = number1<number2?RecMN(number1, number2):RecMN(number2, number1);
PrintData(resultLine);