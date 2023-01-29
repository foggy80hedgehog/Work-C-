/*
 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

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

// Умножение двух матриц (0,0 х 0,0 и т.д.)

void Multiply(int[,] MatrOne, int[,] MatrTwo)
{
    int[,] MultiplyOneTwo = new int[MatrTwo.GetLength(0), MatrTwo.GetLength(1)];
    for (int i = 0; i < MatrOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrOne.GetLength(1); j++)
        {
            int Sum = 0;
            for (int k = 0; k < MatrOne.GetLength(0); k++)
            {
                Sum += MatrOne[i, k] * MatrTwo[k, j];
            }
            MultiplyOneTwo[i, j] = Sum;
        }

    }

    PrintArray(MultiplyOneTwo);
}


Console.Clear();

int Stolbik = GetNumber("Введите колличество столбцов и строк квадратной матрицы ");
int Stroka = Stolbik;
int LeftRandomNumber = GetNumber("Введите  диапозон случайных чисел : от ");
int RaitRandomNumber = GetNumber("Введите  диапозон случайных чисел : до ");

int[,] matrixOne = new int[Stroka, Stolbik];
int[,] matrixTwo = new int[Stroka, Stolbik];

FillArray(matrixOne, LeftRandomNumber, RaitRandomNumber);
FillArray(matrixTwo, LeftRandomNumber, RaitRandomNumber);
Console.WriteLine("Первый массив");
PrintArray(matrixOne);
Console.WriteLine();
Console.WriteLine("Второй массив");
PrintArray(matrixTwo);
Console.WriteLine();
Console.WriteLine("Произведение двух массивов");
Multiply(matrixOne, matrixTwo);

