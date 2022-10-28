// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
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


void Cube(int N)
{
 if (N>0){
    for(int i = 1; i<= N; i++)
    {
        if(i!=N) 
        Console.Write($"{i*i*i}, ");
        else
        Console.Write($"{i*i*i}. ");
    }
    }
    else
    {
     for(int i = -1; i>= N; i--)
    {
        if(i!=N) 
        Console.Write($"{i*i*i}, ");
        else
        Console.Write($"{i*i*i}. ");
    }   
    }
}
int number = GetNumber("Введите число N: ");
Cube(number);