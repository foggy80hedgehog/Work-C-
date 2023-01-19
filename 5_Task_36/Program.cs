/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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


// Поиск суммы чисел на нечетных позициях

int FindSumneChetnumber(int[] array)
{
    int Summ = 0;
    for (int i = 0; i < array.Length; i++)

    { if (i % 2 == 1)
        Summ += array[i];
    }
    return Summ;
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

int number = FindSumneChetnumber(mass);


Console.WriteLine();
Console.WriteLine($"Сумма чисел в массиве стоящих на нечетных позициях = {number}");

