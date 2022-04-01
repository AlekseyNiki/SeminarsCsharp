//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void matrixR(int m, int n)
{
    double[,] massivNum = new double[m,n];

    for (int i = 0; i < massivNum.GetLength(0); i++)
    {
        for (int j = 0; j < massivNum.GetLength(1); j++)
        {
            Random random = new Random();
            massivNum[i,j] = 1000 * random.NextDouble();
            Console.Write($"{massivNum[i,j]} ");
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

matrixR(rows,columns);
*/
//=============================================================================================
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void MassivPoiskElementa(int rowNum,int colomnNum)
{
    Random random = new Random();
    int[,] massivNum = new int[random.Next(1,11),random.Next(1,11)];

    for (int i = 0; i < massivNum.GetLength(0); i++)
    {
        for (int j = 0; j < massivNum.GetLength(1); j++)
        {
            massivNum[i,j] = random.Next(1,9);
            Console.Write($"{massivNum[i,j]} ");
        }

        Console.WriteLine();
    }

    for (int i = 0; i < massivNum.GetLength(0); i++)
    {
        for (int j = 0; j < massivNum.GetLength(1); j++)
        {
            if(i == rowNum && j == colomnNum) Console.WriteLine($"Значение элеиента = {massivNum[i,j]}");
            else if(rowNum > massivNum.GetLength(0) - 1 || rowNum < 0 || colomnNum > massivNum.GetLength(1) - 1 || colomnNum < 0)
            {
                Console.WriteLine("Элемент отсутствует");
                break;
            }
        }
        if(rowNum > massivNum.GetLength(0) - 1 || rowNum < 0 || colomnNum > massivNum.GetLength(1) - 1 || colomnNum < 0) break;
    }
}

Console.WriteLine("Задайте номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

MassivPoiskElementa(row,column);
*/
//============================================================================================================
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
void MassivAverage()
{
    Random random = new Random();
    int[,] massivNum = new int[random.Next(1,11),random.Next(1,11)];

    for (int i = 0; i < massivNum.GetLength(0); i++)
    {
        for (int j = 0; j < massivNum.GetLength(1); j++)
        {
            massivNum[i,j] = random.Next(1,9);
            Console.Write($"{massivNum[i,j]} ");
        }

        Console.WriteLine();
    }

    double sumColomns = 0;
    double average = 0;

    Console.Write("Среднее арифметическое столбцов ");

    for (int j = 0; j < massivNum.GetLength(1); j++)
    {
        sumColomns = 0;
        average = 0;

        for (int i = 0; i < massivNum.GetLength(0); i++)
        {
            sumColomns = sumColomns + massivNum[i,j];
        }
        average = Math.Round((sumColomns / massivNum.GetLength(0)),2);
        Console.Write($"[{j}] = {average}, ");
    }
}

MassivAverage();
*/
//=====================================================================================================================