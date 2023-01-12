/*int GetSum(int num)
{
    int sum = 0;

    for (int current = 1; current <= num; current++)
        sum  += current;
    return sum;
}
Console.Write("imput a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSum(a));
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int numSelect (int num)
{
    int prr = 1;
    for (int current = 1; current <= num; current++)
        prr *= current;
    return prr;
}
Console.Write("Imput a number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numSelect(b));

*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberFind (int num)
{
    int testNum = 0;
    while (num > 0)
    {
        
        num = num / 10;

        testNum++;
    }
    return testNum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberFind(num));
*/

// Массивы

int[] CreateRandomArray (int size, int minValue, int maxvalue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    
        array[i] = new Random().Next(minValue, maxvalue + 1);
    
    return array;
}

void Showarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write(" Input a length of array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(Length, min, max);
Showarray(newArray);