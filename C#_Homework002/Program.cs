/* int CutNumber(int number)
{
     int sot = number / 100;
     int ed = number % 10;

     int result = sot * 10 + ed;
     return result;
}


int RandNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(RandNumber);

Console.WriteLine($"New version of a number {RandNumber} is {newNumber}");

int a =5;
if(a > 0 && a % 2 == 0)
{

}
*/



// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*int MetRandom(int num)
{
    int num1 = num / 10;
    int num2 = num % 10;
    if (num1 != num2)
    {
        if (num1 <= num2)
        {
           return (num2);
        }
         else
        {
             return (num1);
        }
    }
    else
    {
        return -1;
    }
}

int InRandNumber = new Random().Next (10, 100);
Console.WriteLine(InRandNumber);
Console.WriteLine(MetRandom(InRandNumber));
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*bool func(int num1, int num2)
{
     if (num1 % num2 == 0) return true;
     else return false;    
} 
 Console.Write("imput number 1: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("imput number 2: ");
 int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(func(num1, num2));
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*bool func(int num1, int num2)
{
     if (num1 * num1 == num2 || num2* num2 ==num1) return true;
     else return false;    
} 
 Console.Write("imput number 1: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("imput number 2: ");
 int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(func(num1, num2));
*/

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int enterNumber(int num)
{
    return (num % 100) / 10;
}

bool corrnum(int num)
{
    if (num / 100 != 0 && num / 1000 == 0)
    return true;
    else
        return false;
}

Console.Write(" Введите Трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(corrnum(number)) Console.WriteLine($"Второй символ числа {enterNumber(number)} ");
else Console.Write("ошибка ввода");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FindThir( int num)
{
    while(num >= 1000)
    {
        num = num / 10;
    }

    return num % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 != 0) Console.WriteLine($"Третья цифра вашего числа это {FindThir(number)}");
else Console.WriteLine ("В вашем числе нет Третьего знака");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Happy(int num)
{
    if (num ==6 || num ==7) return true;
    else return false;
}
Console.Write ("Введите номер недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(Happy(number)) Console.WriteLine("Happy!!! NO WORK!!! ");
else if (number >= 1 && number <= 5) Console.WriteLine("WORK!!! GO HARD WORK!!! NIGGA!");
else Console.Write("Тссс.... ты пьяный введи число!");