// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// Создаём метод, который будет считывать с консоли сообщение и возвращать число
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Создаём словарь для 4-значных палиндромов
Dictionary<string, bool> palindromes = new Dictionary<string, bool>();
// Добавляем цикл fori для заполнения словаря 4-значными числами
for (int i = 1000; i < 10000; i++) {
    // Конвертируем число в строковую переменную
    string numString = i.ToString();
    // Проверяем если 0-ой элемент равен 3-му и 1-ый равен 2-му
    if (numString[0] == numString[3] && numString[1] == numString[2]) {
        // если условие выполняется, добавляем палиндром в словарь
        palindromes[numString] = true;
    }
}

// Просим ввести 5-значное число
int input = ReadData("Введите пятизначное число: ");

// Проверка на то является ли наше число 5-значным
if (input < 10000 || input > 99999) {
    Console.WriteLine("Введенное число не пятизначное");
    // если число не пятизначное, выходим из программы ничего не вернув
    return;
}

// Проверяем является ли число введенное с консоли палиндромом
// Конвертируем число в строковую переменную
string inputString = input.ToString();
// Объявляем новую переменную типа bool и присваиваем ей значение нашей строковой переменной.
// Далее выполняем проверку является ли число палиндромом
bool checkPalindrome = inputString[0] == inputString[4] && inputString[1] == inputString[3];
if (checkPalindrome) {       
    Console.WriteLine(inputString + " это палиндром");
} else {
    Console.WriteLine(inputString + " не палиндром");
}
