// Задача 28 



int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumToA(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++)
    {
        // sum = sum +i;
        sum *= i;
    }

    return sum;
}

int number = ReadNumber("Введите число A");
int result = SumToA(number);
Console.WriteLine(result);