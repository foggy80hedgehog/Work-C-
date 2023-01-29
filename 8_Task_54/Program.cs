/*
 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Печать двумерного массива
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполнение двумерного массива случайными числами
void FillArray(int[,] matr, int LeftRandomNumber, int RaitRandomNumber)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(LeftRandomNumber, RaitRandomNumber + 1);//[1; 10)
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

// Поиск среднеарифметического значения столбцов
void SredneArifmet(int[,] matr)

{
    Console.WriteLine("Среднее арифметическое каждого столбца ");

    double srednee = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            srednee += matr[i, j];
        }
        Console.Write($" {Math.Round(srednee / matr.GetLength(0), 2)}; ");
        srednee = 0;
    }
}

// Метод упорядочит по убыванию элементы каждой строки двумерного массива
void StringMaxMin(int[,] matr)
{


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j <  matr.GetLength(1); j++)
        {
            for (int c = 0; c < matr.GetLength(1)-1; c++)
            {

                if (matr[i, c] < matr[i, c + 1])
                {
                    int temp = matr[i, c+1];
                    matr[i, c+1] = matr[i, c];
                    matr[i, c] = temp;
                }
            }

        }
    }
}
Console.Clear();

int Stolbik = GetNumber("Введите колличество столбцов");
int Stroka = GetNumber("Введите колличество строк");
int LeftRandomNumber = GetNumber("Введите  диапозон случайных чисел : от ");
int RaitRandomNumber = GetNumber("Введите  диапозон случайных чисел : до ");

int[,] matrix = new int[Stroka, Stolbik];

FillArray(matrix, LeftRandomNumber, RaitRandomNumber);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
StringMaxMin(matrix);
PrintArray(matrix);
