/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. 
6 -> да
7 -> да
1 -> нет */

// Список разрешенных чисел
int[] allowedDigits = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

// Метод проверки введенного значения
int EnterNumbers(string? str, int[] allowed)
{
    if (int.TryParse(str, out int numb)) //если введено число
    {
        //Проверяем входит ли num в массив allowed
        if (allowed.Contains(numb)) {}
        else numb = -1;
    }
    else numb = -1;
    return numb;
}

string[] daysOfTheWeek = new string[7] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
string[] nonWorkingDays = new string[2] { "Суббота", "Воскресенье" };

// Метод определяющий является ли выбранный оператором день выходным
string Weekend(int num, string[] days, string[] weekend)
{
    num = num - 1;
    string print = days[num];
    //Проверяем выбранный день недели days[num] является ли выходным
    if (weekend.Contains(print))
        print = $"Выбранный день недели {days[num]} является выходным.";
    else
        print = $"Выбранный день недели {days[num]} не является выходным.";
    return print;
}

//Цикл до тех пор пока не будет введено одно из числе: 1, 2, 3, 4, 5, 6, 7.
int number = -1;
while (number == -1)
{
    Console.WriteLine("Введите число от 1 до 7: ");
    number = EnterNumbers(Console.ReadLine(), allowedDigits);
}

//
Console.WriteLine(Weekend(number, daysOfTheWeek, nonWorkingDays));