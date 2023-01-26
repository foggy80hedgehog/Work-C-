/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

// Печать двумерного вещественного массива
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matr[i, j],1)}  ");
        }
        Console.WriteLine();
    }
}

// Заполнение двумерного массива случайными вещественными числами

void FillArray(double[,] matr, int LeftRandomNumber, int RaitRandomNumber)
{
Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = Convert.ToDouble (rnd.Next(LeftRandomNumber, RaitRandomNumber)+ rnd.NextDouble());
        }
    }
}

// Ввод числа
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число Повторите ввод!");
        }
    }

    return result;
}

Console.Clear();
int Stolbik = GetNumber("Введите колличество столбцов");
int Stroka = GetNumber("Введите колличество строк");
int LeftRandomNumber = GetNumber("Введите начальный диапозон случайных чисел");
int RaitRandomNumber = GetNumber("Введите начальный диапозон случайных чисел");


double[,] matrix = new double[Stroka,Stolbik];
FillArray(matrix, LeftRandomNumber, RaitRandomNumber);
Console.WriteLine();
PrintArray(matrix);
