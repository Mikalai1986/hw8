/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерного массива
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
void ChangeRows(int[,] array)
{
    int temp = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {   for (int k = j+1; k < array.GetLength(1); k++)
        {
            
        
            if (array[i, j] < array[i,k])
            {
                temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }

        }
    }
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");

int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
ChangeRows(myArray);
Print2DArray(myArray);
задайте прямоуголный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
суммой элементов
*/
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}
int Maxstring(int[,] array)
{
    int Sumzero = 0;
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Массив  - не прямоугольный");
        
    }
    else
        for (int i = 0; i < 1; i++)
        {
            
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Sumzero = Sumzero + array[i, j];
            }
        }
    return Sumzero;
}
int MinInd(int[,] array, int Sumzero)
{
    
    int Indmin = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i, j];
        if (sum < Sumzero)
        {
            Sumzero = sum;
            Indmin = i;
        }
    }
    return Indmin;
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");

int minValue = InputNum("Введите минимальное значение элемента: ");
int maxValue = InputNum("Введите максимальное значение элемента: ");

int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
int zerosum = Maxstring(myArray);
int min = MinInd(myArray, zerosum);
Console.WriteLine($"индекс строки с минимальной суммой значений = { min}");