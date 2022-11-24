// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] table = new double[rows, colums];

void PrintArray(double[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++) 
        {
            Console.Write($"{tab[rows, colums],4} "); 
        }
        Console.WriteLine(); 
    }
}

void FillArray(double[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++)
        {
            tab[rows, colums] = Convert.ToDouble(new Random().Next(1, 10)); 
        }
    }
}

void PrintArrayAvg(double[,] tab)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
            sum += Convert.ToDouble(table[i, j]);
        }
        Console.Write($"{sum / table.GetLength(0),4} ");
    }
    Console.ReadLine();
}

FillArray(table);
Console.WriteLine(); 
PrintArray(table);
Console.WriteLine();
PrintArrayAvg(table);