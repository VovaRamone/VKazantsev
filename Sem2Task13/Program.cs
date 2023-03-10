// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Выводим данные в консоль 
Console.WriteLine("Введите число");
// Создаём целочисленную переменную типа int. Парсим введенное число. Считываем данные введенные с консоли. Проверяем на null.
int num = int.Parse(Console.ReadLine()??"0");
// Запускаем цикл типа while для нахождения первых трёх цифр введенного числа.
// Цикл выполняется путём проверки больше либо равно число введенное в консоли 999
while (num >= 999)
{
    // Чтобы цикл завершился, нужно на каждой итерации делить наше число на 10. Цикл завершится когда число станет трёхзначным
    num = num / 10;
}
// Запускаем цикл if else для проверки является ли наше число трёхзначным.
if (num > 99)
{
    // Если число больше 99, т.е. трёхзначное, то из полученного числа найдём остаток, т.е. последнюю цифру трёхзначного числа.
    num = num % 10;
    // Выводим результат в консоль 
    Console.WriteLine($"Третьей цифрой числа является {num}");
}
// Если число не больше 99, т.е. двузначное, тогда выводим сообщение в консоль что третьей цифры в числе нет.
else
{
    Console.WriteLine($"третьей цифры в числе {num} нет");
}