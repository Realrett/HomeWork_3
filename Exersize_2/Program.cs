// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)); // Math.Sqrt - математический корень, Math.Pow(выражение, степень) - возведение выражения в степень.

    return distance;
}



int GetNumber(string msg)
{
    int result;
    while (true)
    {
        Console.WriteLine(msg);
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            result = number;
            break;
        }
        else
        {
        Console.WriteLine($"Введите корректные данные (число)");
        }
    }
return result;
}


int x1Number = GetNumber("Введите координату x1:");
int x2Number = GetNumber("Введите координату x2:");

int y1Number = GetNumber("Введите координату y1:");
int y2Number = GetNumber("Введите координату y2:");

int z1Number = GetNumber("Введите координату z1:");
int z2Number = GetNumber("Введите координату z2:");
double EndDistance = GetDistance(x2Number, x1Number, y2Number, y1Number,z2Number, z1Number );
Console.WriteLine($"Расстояние между точкой 1 с координатами {x1Number},{y1Number},{z1Number} и точкой 2 с координатами {x2Number},{y2Number},{z2Number} равняется {Math.Round(EndDistance,2)}");

