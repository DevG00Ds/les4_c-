// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int SmallNumber( int number)
{
int res = 0;
while (number > 0)
    {
    res += number % 10;
    number = number /10;
    }
    return res;
}
int number = ReadNumber(" Введите число : ");
Console.Write($"{number}" + " = " + $"{SmallNumber(number)}");
