// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int GetConsole (string message)
{
    int result;

    while(true)     
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 100000) 
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число, или не пятизначное число, повторите ввод \n");
        }
    }

    return result;
}

void GetNumber(int number)
{
    string Convert1 = Convert.ToString(number);
    if (Convert1[0] == Convert1[4] && Convert1[1] == Convert1[3])
    {
    Console.WriteLine("Число является палиндромом");
    }
    else
    {
    Console.WriteLine("Число не является палиндромом");
    }
}
int x = GetConsole("Введите пятизначное число: ");
GetNumber(x);