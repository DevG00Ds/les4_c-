// Напишите цикл. который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

//3, 5 -> 243 ( 3 в степени 5)
//2,4 -> 16

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());

}

int SumToA(int a, int b)
{
    int sum = 1;

    for ( int i = 0; i < b; i++)
    {
        sum *= a;
    }
    return sum;
}

bool SumToB( int b)
{
    if ( b < 0)
    {
        Console.WriteLine(" Показатель не должен быть ниже 0 ");
        return false;
    }
    return true;
}

int a = ReadNumber (" Введите число A");
int b = ReadNumber(" Введите число B");

if ( SumToB(b))
{
    Console.WriteLine($"Число {a} в степени {b} равна {SumToA( a, b)}");
}


