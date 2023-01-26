/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
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
    Console.Write("Среднее арифметическое каждого столбца ");
    double srednee = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {

            srednee += matr[i, j];
        }
        Console.Write($" {Math.Round(srednee / matr.GetLength(0), 1)}; ");
        srednee = 0;
    }
}
Console.Clear();

// Вывод значения двухмерного массива по заданной позиции
void PoiskChisla(int[,] matr, int Strok, int stolb)

{
        
            if (matr.GetLength(0) >= Strok && matr.GetLength(1) >= stolb)
               
                Console.WriteLine($"Ваше число {matr[Strok, stolb]}");
            
        
            else

                Console.Write("Такого элемента нет");
         
}
Console.Clear();

Console.WriteLine("Введите позиции элемента в двумерном массиве (нумерация позиции начинается с 0) :");

int Stolbik = GetNumber("Введите номер столбца");
int Stroka = GetNumber("Введите номер строки");

int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
PoiskChisla(matrix, Stroka, Stolbik);
