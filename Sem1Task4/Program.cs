// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Выводим данные в консоль 
Console.WriteLine("Введите первое число: ");
// Создаём переменную типа int и положим в неё то число, которое введется с консоли
int numA = Convert.ToInt32(Console.ReadLine());
// Выводим данные в консоль 
Console.WriteLine("Введите второе число: ");
// Создаём вторую переменную типа int и положим в неё то число, которое введется с консоли
int numB = Convert.ToInt32(Console.ReadLine());
// Выводим данные в консоль 
Console.WriteLine("Введите третье число: ");
// Создаём третью переменную типа int и положим в неё то число, которое введется с консоли
int numC = Convert.ToInt32(Console.ReadLine());
// Запускаем проверку на максимальное число, сравнивая числа между собой.
if(numA > numB){
    if(numA > numC){
        Console.WriteLine("Максимальное число "+ numA);
    }
    else
        Console.WriteLine("Максимальное число "+ numC); 
}        
else
    if(numB > numC){
        Console.WriteLine("Максимальное число "+ numB);
    }          
    else
        Console.WriteLine("Максимальное число "+ numC);
