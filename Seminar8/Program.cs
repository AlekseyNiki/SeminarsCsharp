//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] SozdanieMassiva()
{
    Random random = new Random();
    
    int[,] massiv = new int[random.Next(3,5),random.Next(3,5)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,9);
        }
    }

    return massiv;
}

void PrintMassiva(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] SortMassiv(int[,] massiv)
{
    int tmp = 0;

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        int indexMinI = i;
        int indexMinJ = 0;

        for (int j = 0; j < massiv.GetLength(1) - 1; j++)
        {
            indexMinI = i;
            indexMinJ = j;

            for (int k = j + 1; k < massiv.GetLength(1); k++)
            {
                if(massiv[i,k] > massiv[indexMinI,indexMinJ])
                {
                    indexMinI = i;
                    indexMinJ = k;
                }
            }

            tmp = massiv[i,j];
            massiv[i,j] = massiv[indexMinI,indexMinJ];
            massiv[indexMinI,indexMinJ] = tmp;
            
        }
        
    }

    return massiv;
}

int[,] massivDlyaSortirovki = SozdanieMassiva();

PrintMassiva(massivDlyaSortirovki);
Console.WriteLine();
PrintMassiva(SortMassiv(massivDlyaSortirovki));
*/
//================================================================================================================================================
// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] SozdanieMassiva()
{
    Random random = new Random();
    
    int[,] massiv = new int[random.Next(3,5),random.Next(3,5)];

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i,j] = random.Next(1,9);
        }
    }

    return massiv;
}

void PrintMassiva(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

void SumMinRow(int[,] massiv)
{
    int sumElements = int.MaxValue;
    int sumElementsTmp = 0;
    int minRow = 0;
    int tomblerMinRow = 0;
    
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sumElementsTmp = 0;
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            sumElementsTmp = sumElementsTmp + massiv[i,j];
        }

        if(sumElementsTmp < sumElements)
        {
            sumElements = sumElementsTmp;
            minRow = i;
        }
    }

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        sumElementsTmp = 0;

        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            sumElementsTmp = sumElementsTmp + massiv[i,j];
        }

        if(sumElementsTmp == sumElements) tomblerMinRow = 1;
    }

    if(tomblerMinRow == 1)
    {
        for (int i = 0; i < massiv.GetLength(0); i++)
        {
            sumElementsTmp = 0;

            for (int j = 0; j < massiv.GetLength(1); j++)
            {
                sumElementsTmp = sumElementsTmp + massiv[i,j];
            }

            if(sumElementsTmp == sumElements)
            {
                sumElements = sumElementsTmp;
                minRow = i;
                Console.Write($"Строка[{minRow}] ");
            }
            else if(tomblerMinRow == 0) Console.WriteLine($"Строка[{minRow}]");
        }
    }
}

int[,] newMassiv = SozdanieMassiva();
PrintMassiva(newMassiv);
SumMinRow(newMassiv);
*/
//=============================================================================================================================
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] SozdanieMassiva()
{
    Random random = new Random();

    int[,,] massiv = new int[random.Next(2,5),random.Next(2,5),random.Next(2,5)];
    Console.WriteLine($"Массив[{massiv.GetLength(0)},{massiv.GetLength(1)},{massiv.GetLength(2)}]");
    
    int countZapolnenix = 0;
    int countProverinix = 0;
    int countVsego = massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2);

    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                bool unikalnoe;
                countZapolnenix++;
                
                do
                {
                    countProverinix = countZapolnenix;
                    massiv[i,j,k] = random.Next(1,(massiv.GetLength(0) * massiv.GetLength(1) * massiv.GetLength(2)) + 1);

                    unikalnoe = true;

                    for (int l = 0; l < massiv.GetLength(0); l++)
                    {
                        for (int m = 0; m < massiv.GetLength(1); m++)
                        {
                            for (int n = 0; n < massiv.GetLength(2); n++)
                            {
                                countProverinix--;
                                
                                if(countProverinix == 0) break;
                                if(massiv[i,j,k] == massiv[l,m,n])
                                {
                                    unikalnoe = false;
                                    break;
                                }
                            }

                            if(unikalnoe == false) break;
                            if(countProverinix == 0) break;
                        }

                        if(unikalnoe == false) break;
                        if(countProverinix == 0) break;
                    }

                    if(countProverinix == 0) break;
                } while(!unikalnoe);

                if(countZapolnenix == countVsego) break;
            }

            if(countZapolnenix == countVsego) break;
        }

        if(countZapolnenix == countVsego) break;
    }

    return massiv;
}

void Print3DMassiv(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($"{massiv[i,j,k]}[{i},{j},{k}] ");
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

Print3DMassiv(SozdanieMassiva());
*/
//============================================================================================================================================
// Задача 4: Заполните спирально массив 4 на 4.
/*
int[,] SozdanieMassiva()
{
    int[,] massiv = new int[4,4];

    return massiv;
}

void PrintMassiva(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
           Console.Write($"{massiv[i,j]} ");
        }

        Console.WriteLine();
    }
}

int[,] MetodSpiral(int[,] massiv)
{
    int countZapolnenix = 1;

    for (int smegenie = 0; smegenie < massiv.GetLength(0) - 2; smegenie++)
    {
        for (int i = 0 + smegenie; i < massiv.GetLength(1) - smegenie; i++)
        {
            massiv[0 + smegenie,i] = countZapolnenix;
            countZapolnenix++;
        }
        
        countZapolnenix--;

        for (int i = 0 + smegenie; i < massiv.GetLength(0) - smegenie; i++)
        {
            massiv[i,3 - smegenie] = countZapolnenix;
            countZapolnenix++;
        }

        countZapolnenix--;

        for (int i = massiv.GetLength(1) - 1 - smegenie; i >= 0 + smegenie; i--)
        {
            massiv[3 - smegenie,i] = countZapolnenix;
            countZapolnenix++;
        }

        countZapolnenix--;

        for (int i = massiv.GetLength(0) - 1 - smegenie; i >= 1 + smegenie; i--)
        {
            massiv[i,0 + smegenie] = countZapolnenix;
            countZapolnenix++;
        }
    }

    return massiv;
}

int[,] massivNew = SozdanieMassiva();
PrintMassiva(MetodSpiral(massivNew));
*/
//=========================================================================================================================