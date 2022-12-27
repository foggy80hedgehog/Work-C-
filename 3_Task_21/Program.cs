/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) )
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод!");
        }
    }

    return result;
}
Console.WriteLine("Нахождение расстояния между двумя точками в 3D пространстве");

int x1 = GetNumber("Введите координаты первой точки x1:");
int y1 = GetNumber("Введите координаты первой точки y1:");
int z1 = GetNumber("Введите координаты первой точки z1:");
int x2 = GetNumber("Введите координаты первой точки x2:");
int y2 = GetNumber("Введите координаты первой точки y2:");
int z2 = GetNumber("Введите координаты первой точки z2:");

double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 -y1, 2)+ Math.Pow(z2 -z1, 2)); 

    Console.WriteLine($"Расстояние между точкой ({x1},{y1},{z1}) и точкой({x2},{y2},{z2}) = {result}");
