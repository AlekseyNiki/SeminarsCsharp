//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int KolichestvoChetnix()
{
    int[] mass = new int[10];
    int schetchik = 0;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = new Random().Next(100,1000);
        if (mass[i] % 2 == 0) schetchik = schetchik + 1;
        Console.Write(mass[i] + " ");
    }

    Console.WriteLine();
    return schetchik;
}

Console.WriteLine($"В массиве чётных чисел {KolichestvoChetnix()}");
*/
//=======================================================================================================
// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SummaNechetnixIndeksov()
{
    int[] mass = new int[10];
    int summa = 0;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = new Random().Next(1,11);
        Console.Write(mass[i] + " ");
    }

    for (int i = 0; i < 10; i++)
    {
        if(i % 2 != 0) summa = summa + mass[i];
    }

    Console.WriteLine();
    return summa;
}

Console.WriteLine($"Сумма элементов с нечётными индексами = {SummaNechetnixIndeksov()}");
*/
//=======================================================================================================================
// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double RaznicaMaxMin()
{
    double[] mass = new double[10];
    double Raznica = 0;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = new Random().Next(1,100);
        Console.Write(mass[i] + " ");
    }

    double MaxElement = mass[0];
    double MinElement = mass[0];

    Console.WriteLine();

    for (int i = 0; i < 10; i++)
    {
        if(mass[i] > MaxElement) MaxElement = mass[i];
    }

    Console.WriteLine($"максимальный элемент = {MaxElement}");

    for (int i = 0; i < 10; i++)
    {
        if(mass[i] < MinElement) MinElement = mass[i];
    }
    */
    //======================================================================================================================