// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int PowerMetod(int NumberA, int PowerB)
{
    int rezalt = 1;
    for(int i = 0; i < PowerB; i++)
    {
        rezalt = rezalt * NumberA;
    }

    return rezalt;
}

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень");
int Power = Convert.ToInt32(Console.ReadLine());

if(Power < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"число {Number} в степени {Power} = {PowerMetod(Number, Power)}");
*/
//=========================================================================================================================
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummaCifr(int NumberA) 
{
    int rezalt = 0;
    NumberA = Math.Abs(NumberA);

    while(NumberA > 0)
    {
        rezalt = rezalt + (NumberA % 10);
        NumberA = NumberA / 10;
    }

    return rezalt;
}

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма цыфр числа {Number} = {SummaCifr(Number)}");
*/
//===============================================================================================================
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
void Massiv8()
{
    int[] mass = new int[8];
    for (int i = 0; i < 8; i++)
    {
        mass[i] = new Random().Next(1,9);
        Console.Write(mass[i] + " ");
    }
}

Massiv8();
*/
//=================================================================================================