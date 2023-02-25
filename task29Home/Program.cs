// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());

}

int[] newArray(int LenghtNumber, int minNumber, int maxNumber)
{
    int [] array = new int[LenghtNumber];
    Random random = new Random();
    for ( int i = 0; i < LenghtNumber; i++)
    {
        array[i] = random.Next(minNumber,maxNumber + 1);
    }
    return array;

}

void PrintArray( int[] array )
{
    Console.Write("[");
    for ( int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int Lenght = ReadNumber("Длинна Массива");
int minNumber = ReadNumber("Минимальное значение случайного числа");
int maxNumber = ReadNumber("Максимальное значение случайного числа");
int[] array = newArray( 8, 1, 8);
PrintArray(array);