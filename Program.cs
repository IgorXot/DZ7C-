
// ----------------------------------------------------DZ7------------------------------------------------------------------------

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a nmber of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] myArray)
{
    Console.Write("Input row Element: ");
    int rowElement = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column Element: ");
    int columnElement = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

    if (rowElement < myArray.GetLength(0) && columnElement < myArray.GetLength(1))
        Console.WriteLine($"The element at row {rowElement} and column {columnElement} is {myArray[rowElement, columnElement]}");
    else Console.WriteLine("No elemens!");
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

*/

 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(1, 10);
    return array;
}

void ShowArray(int[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageArray(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        average[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return average;
}

void ShowAverage(double[] average)
{
    for(int i = 0; i < average.Length; i++)
   
       Console.Write(average[i] + " ");
   
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns);
ShowArray(myArray);
ShowAverage(AverageArray(myArray));

*/
