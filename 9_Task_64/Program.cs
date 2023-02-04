/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

// Ввод числа
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или не верное число!");
        }
    }

    return result;
}




int Nomera(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Nomera(n, m + 1)}, ");
    return m;
}

int n= GetNumber("Введите число > 0 ");
int m = 1;
Console.WriteLine(Nomera(n,m));
