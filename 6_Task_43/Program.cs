/* 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
*/

Console.Clear();
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
            Console.WriteLine("Ввели не число или число не из заданного диапазона. Повторите ввод!");
        }
    }

    return result;
}

Console.WriteLine("Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double b1 = GetNumber("Введите число b1:");
double k1 = GetNumber("Введите число k1:");
double b2 = GetNumber("Введите число b2:");
double k2 = GetNumber("Введите число k2:");


// Для вычисления координат точки пересечения прямых, решим систему уравнений, Вычтем из первого уравнения второе - найдем х, подставим это значение во второе уравнение и найдем y

//y -y = k1 * x + b1 - k2 * x - b2
// x(k1 - k2)-b1+b2
//x = (b1-b2)/-(k1 - k2)

double x = (b1 - b2) / -(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine(x);

Console.Clear();
Console.WriteLine($" точку пересечения двух прямых ({x};{y})");

