// Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// Read user input for number of taps
int taps = ReadData("Введите количество нажатий ");
// Read user input for string
string inputLine = ReadLineData("Введите любые символы с клавиатуры.");
// Find the number of digits in the string
FindNumbersInString(inputLine, taps);
// Function to read integer input from user
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");    
}

// Function to read string input from user
string ReadLineData(string msg)
{
    // Display message to user
    Console.WriteLine(msg);
    // Read input character by character
    string line = "";
    for (int i = 0; i < taps; i++)
    {
        var key = Console.ReadKey(true);
        line = line + String.Format(key.KeyChar.ToString()) + ",";
    }
    // Remove trailing comma from input
    line = line.TrimEnd(',');
    return line;
}

// Function to find the number of digits in a given string
void FindNumbersInString(string str, int count)
{
    int posNums = 0;
    // Iterate through each character in the string
    foreach (char c in str)
    {
        // Check if character is a digit and not 0
        if (Char.IsDigit(c) && c != '0')
        {
            posNums++;
        }
    }
    // Display output to user
    if (posNums > 0)
    {
        Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
    }
    else
    {
        Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
    }
}
