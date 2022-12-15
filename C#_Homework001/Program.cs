// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Первое число " + num1 + " Больше чем второе " + num2);
}
else
{
    Console.WriteLine("Второе число " + num2 + " Больше чем первое " + num1);
}
*/

//Задача 4.Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max =num1;

if ( num1 > max ) max = num1;
if ( num2 > max ) max = num2;
if ( num3 > max ) max = num3;


Console.WriteLine("Наибольшее число: " +max);
*/

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num%2 ==1)
{
    Console.WriteLine("Данное число: " + num + " Нечетное!");
}
else
{
    Console.WriteLine("Данное число: " +num+ "Четное");
}
*/

// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool no =true;

Console.WriteLine("Четные числа от 1 до " +num);

while (i<=num)
{
    if(i%2 !=1)
    {
        Console.Write(i + ",");
        no = false;
    }
    i += 1;
}
if (no)
{
    Console.Write("Нет четных чисел!");
}
*/


