/*
int[,] CreateRandom2Array()
{
    Console.Write("Imput a number rows: ");
    int rows = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a number colums: ");
    int colums = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a min possible value: ");
    int minValue = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a max possible valeu: ");
    int maxValue = Convert.ToInt32( Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}
void Show2Array(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] newArray = CreateRandom2Array();
Show2Array(newArray);

*/
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreateSumIndex2dArray(int rows,int columns)
{
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Write2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());

int[,] newArr = CreateSumIndex2dArray(row, col);
Write2dArray(newArr);
*/
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray(int rows,int columns, int minVal, int maxVal)
{
    int[,] array = new int[rows, columns]; 
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minVal,maxVal+1);
        }
    }
    return array;
}

void Write2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}

void Double2dArray( int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2) 
    {
        for(int j = 0; j < array.GetLength(1); j += 2) 
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.WriteLine();
    }   
    Console.WriteLine();
}

Console.Write("Input number rows in array: ");
int row = Convert.ToInt16(Console.ReadLine());
Console.Write("Input number columns in array: ");
int col = Convert.ToInt16(Console.ReadLine());
Console.Write("Input minimum value: ");
int minV = Convert.ToInt16(Console.ReadLine());
Console.Write("Input maximum value: ");
int maxV = Convert.ToInt16(Console.ReadLine());

int[,] newArr = CreateRandom2dArray(row, col, minV, maxV);


Write2dArray(newArr);

Double2dArray(newArr);

Write2dArray(newArr);
*/
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] CreateRandom2Array()
{
    Console.Write("Imput a number rows: ");
    int rows = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a number colums: ");
    int colums = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a min possible value: ");
    int minValue = Convert.ToInt32( Console.ReadLine());
    Console.Write("Imput a max possible valeu: ");
    int maxValue = Convert.ToInt32( Console.ReadLine());

    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        
    return array;
}

int sumArray(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(i); i++)
        sum += array[i,i];
    return sum;
}

void Show2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j =  0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2Array();
Show2Array(newArray);
int sum = sumArray(newArray);
Console.WriteLine(sum);

