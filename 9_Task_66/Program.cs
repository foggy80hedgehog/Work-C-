/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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




int Sum(int m, int n)
{
    if (m == n)
        return n;
    else
        return n + Sum(m, n - 1);
}

Console.Clear();
Console.WriteLine("сумма натуральных элементов в промежутке от M до N");
Console.WriteLine();
int m = GetNumber("Введите число M > 0 ");
int n = GetNumber("Введите число N > 0 ");
if (m > n)
    Console.WriteLine("неверный диапозон");
else
    Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");
