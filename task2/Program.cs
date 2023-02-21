// Задача 26:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int ReadNumber(string messageToUser)
// {
//     Console.WriteLine(messageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }



int inputData = int.Parse(Console.ReadLine());

int count = 1;

for (; inputData > 10; count++)
{
    inputData = inputData / 10;

}
Console.WriteLine($"{count}");