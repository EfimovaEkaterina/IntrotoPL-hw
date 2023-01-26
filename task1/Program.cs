// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
//456 -> 5
//782 -> 8
//918 -> 1

int InputInt(String message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int number = InputInt("Введите трехзначное число");

if (number > 99 && number < 1000)
{
    int result = number % 100 / 10;
    Console.WriteLine("Вторая цифра числа равна " + result);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
