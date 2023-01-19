/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// метод, который считывает с консоли (для размерности массива + границы случ. чисел)
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
            Console.WriteLine("Ввели не число ");
        }
    }

    return result;
}

//метод для инициализации массива рандомными числами
int[] InitArray(int dimension, int rightBound, int leftBound)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(leftBound, rightBound);
    }
    return result;
}

// Поиск Min (первое значение) и Max (второе значение) чисел массива

(int, int) FindMinMax(int[] array)
{
    int Min = array[0];
    int Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
        {
            Max = array[i];
        }
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    return (Min, Max);
}

//метод для печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Clear();

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] mass = InitArray(dimensin, rightBound, leftBound);

Console.WriteLine("Ваш массив ");
PrintArray(mass);

(int Min1, int Max1) = FindMinMax(mass);


Console.WriteLine();
Console.WriteLine($"минимальное число {Min1}, максимальное число {Max1}");

Console.WriteLine($"Разница между максимальным и минимальным значением = {Max1 - Min1}");

