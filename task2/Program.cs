// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
//645 -> 5
//78 -> третьей цифры нет
//326792 -> 6

int InputInt(String message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int number = InputInt("Введите число ");
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine("третья цифра числа равна " + result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}