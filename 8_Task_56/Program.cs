/*
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

// Поиск суммы в определенной строке
int SummaStroki(int[,] matr, int NumberSrtoki)
{
    int SummaStr = matr[NumberSrtoki, 0];

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        SummaStr += matr[NumberSrtoki, i];
    }
    return SummaStr;
}

// Поиск минимальной строки в массиве
void MinStroka(int[,] matr)
{
    int NumberMinStroki = 0;
    int MinResultStroki = SummaStroki(matr, 0);

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int TempResultStroki = SummaStroki(matr, i);
        if (MinResultStroki > TempResultStroki)
        {
            MinResultStroki = TempResultStroki;
            NumberMinStroki = i;
        }
    }
    Console.WriteLine($"{MinResultStroki} наименьший результат в строке  {NumberMinStroki + 1}");
}

// Метод упорядочит по убыванию элементы каждой строки двумерного массива
void StringMaxMin(int[,] matr)
{


    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int c = 0; c < matr.GetLength(1) - 1; c++)
            {

                if (matr[i, c] < matr[i, c + 1])
                {
                    int temp = matr[i, c + 1];
                    matr[i, c + 1] = matr[i, c];
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
MinStroka(matrix);

