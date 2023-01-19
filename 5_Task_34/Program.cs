/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// метод, который считывает с консоли (для размерности массива + границы случ. чисел)
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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

//метод для инициализации массива рандомными трехзначными числами 
int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }
    return result;
}

// Поиск количества четных чисел

int FindChetnumber(int[] array)
{
    int Chetnumber = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array[i] %2 == 0)
        Chetnumber ++;
    }
    return Chetnumber;
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

int[] mass = InitArray(dimensin);

int number = FindChetnumber(mass);

Console.WriteLine("Ваш массив ");
PrintArray(mass);

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {number}");

