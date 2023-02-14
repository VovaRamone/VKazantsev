// Написать программу которая выводит
// случайное число из отрезка и показать
// наибольшую цифру этого числа

System.Random numSintezator = new System.Random();

// Вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber / 10;
int secondNum = rndNumber % 10;

if (firstNum > secondNum)
{
    Console.WriteLine("Первое число больше второго " + firstNum);
}
else
{
    Console.WriteLine("Второе число больше второго " + secondNum);
}

// Вариант 2
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
int firNum = ((int)digits[0])-48;
int secNum = ((int)digits[1])-48;

// <переменная>  = (условие)?<значение1>:<значение2>;
// if(условие)
//{
   // <переменная> = значение1;
//}
// esle
//{
//    <переменная> = значение2;
//}
int resultNumber = (firNum >secNum)?resultNumber=firNum :resultNumber=secNum;
Console.WriteLine(resultNumber);

// Вариант 3
