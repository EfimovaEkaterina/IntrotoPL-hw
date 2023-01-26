// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

Console.Write("Введите цифру, обозначающую день недели ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int DayNumber)
{
    if (DayNumber == 6 || DayNumber == 7)
    {
        Console.WriteLine("Да, этот день выходной");
    }
    else if (DayNumber < 1 || DayNumber > 7)
    {
        Console.WriteLine("Это не день недели");
    }
    else Console.WriteLine("Нет, этот день не выходной");
}

CheckingTheDayOfTheWeek(DayNumber);