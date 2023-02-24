// Написать калькулятор с операциями +, -, /, * и возведение в степень   

    // Создаём метод, который считывает с консоли сообщение и возвращает число типа double
double ReadData(string line)
{        
    Console.Write(line);        
    return Convert.ToDouble(Console.ReadLine() ?? "0");
}
    // Создаём метод считывания оператора с консоли
char ReadOperator(string line)
{        
    Console.Write(line);
    // Создаём переменную типа char для считывания одного символа с консоли
    char op = Console.ReadKey().KeyChar;
    // Переход на следующую строку
    Console.WriteLine();
    // Возвращаем введенный оператор
    return op;
}

// Создаём метод, который будет производить вычисления основываясь на введенном операторе
double Calculate(double num1, char op, double num2)
{
// Создаём переменную типа double и присваиваем ей нулевое значение
    double result = 0;
// Производим вычисления используем оператор switch,
// который вычисляет значение на основе списка значений и возвращает результат, соответствующий первому совпадающему значению.
    switch (op) {
        case '+':
            result = num1 + num2;
            break;
        case '-':
            result = num1 - num2;
            break;
        case '*':
            result = num1 * num2;
            break;
        case '/':
            result = num1 / num2;
            break;
        case '^':
            result = Math.Pow(num1, num2);
            break;
        default:
                // Выводим сообщение, в случае, если был указан не верный case
                Console.WriteLine("Введен некорректный оператор.");
            break;
    }
    // Возвращаем полученный результат
    return result;
}

// Просим ввести первое число
double num1 = ReadData("Введите первое число: ");
// Просим ввести нужный оператор для вычисления
char op = ReadOperator("Введите оператор (+, -, *, /, ^): ");
// Просим ввести второе число
double num2 = ReadData("Введите второе число: ");
// Вычисляем результат на основе введенных данных
double result = Calculate(num1, op, num2);
// Выводим результат в консоль
Console.WriteLine("{0} {1} {2} = {3}", num1, op, num2, result);
