// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine()!);


void ShowNumsBetween(int min, int max)
{
    if (min == max)
    {
        Console.Write(min);
        return;
    }
    if (min > max)
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min - 1, max);
    }
    else
    {
        Console.Write($"{max} ");
        ShowNumsBetween(min, max - 1);

    }
}

ShowNumsBetween(num, 1);
Console.WriteLine();





