// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число M");
int numM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N");
int numN = int.Parse(Console.ReadLine()!);


Akkerman(numM, numN);


int Akkerman(int numM, int numN)
{
    if (numM == numN)
    {
        Console.Write(numM);
        return numM;
    }

    if (numM == 0)
    {
        return numN + 1;
    }


    if (numM > 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }

    if (numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }

    if (numM > 0 && numN > 0)
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));

    }
    return Akkerman(numM, numN);
}

Console.WriteLine($"Значение функции Аккермана = {Akkerman(numM, numN)}");



