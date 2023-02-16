﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Выводим данные в консоль 
Console.WriteLine("Введите трехзначное число");
// Создаём целочисленную переменную типа int. Парсим введенное число. Считываем данные введенные с консоли. Проверяем на null.
int threeDigitNum = int.Parse(Console.ReadLine()??"0");
// Создаём целочисленную переменную типа int.
// Положим в неё число считанное с консоли, разделим на 10 (таким образом мы уберем последнюю цифру из числа)
// Из полученного числа найдём остаток от деления на 10 (это и будет средней цифрой введенного с консоли числа)
int secondDigit = (threeDigitNum/10)%10;
// Выводим результат в консоль
Console.WriteLine("Вторая цифра числа " + secondDigit);
