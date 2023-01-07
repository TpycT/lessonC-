//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
bool Pali(long num)
{
    long testNum = num, mirrorNum = 0;
    while (testNum != 0)
    {
        mirrorNum = mirrorNum * 10 + testNum % 10;
        testNum = testNum / 10;
    }
    return mirrorNum == num;
}

Console.Write("Введите число: ");
long num = Convert.ToInt64(Console.ReadLine());

if (Pali(num)) Console.Write("УРААА!!! это палиндром!!! ");
else Console.Write(" Неее, не катит! ");
*/

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double DistanceAB(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)), 2);
}
Console.WriteLine("Hi! Please input x1 coordinate ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input y1 coordinate ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input z1 coordinate ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input x2 coordinate ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input y2 coordinate ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input z2 coordinate ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"The distance between two dots is {DistanceAB(x1, y1, z1, x2, y2, z2)} ");

*/
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubsNums(int num)
{
    int count = 1;
    if (num >= count)
    {
        while (count <= num)
        {
            Console.Write(Math.Pow(count, 3) + " ");
            count++;
        }
    }
    else
    {
        while (count >= num)
        {
            Console.Write(Math.Pow(count, 3) + " ");
            count--;
        }
    }
}
Console.WriteLine("Hi! Please input number N ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(" Cubs or all  integer numbers between 1 and inputted N are ");
CubsNums(num);
