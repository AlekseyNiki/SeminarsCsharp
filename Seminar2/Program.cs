//==================================================================================================================================================
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int MetodVozvratVtorayaCifra(int num1)
{
    int num2 = num1/10;
    num2 = num2 % 10;
    return num2;
}

Console.WriteLine("введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MetodVozvratVtorayaCifra(number));
*/
//=============================================================================================================================
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void MetodOpredeleniyaNalichiyaTretieyCifri(int num)
{
    if(num > 99)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Третьей цыфры нет");
    }
}

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

MetodOpredeleniyaNalichiyaTretieyCifri(number);
*/
//===============================================================================================================================
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void MetodOpredeleniyaVixodnogoDnya(int num)
{
    if(num == 6 || num == 7)
    {
        Console.WriteLine("Выходной");
    }
    else if(num > 7 || num < 1)
        {
            Console.WriteLine("Такого дня недели не существует");
        }
        else
        {
            Console.WriteLine("Не выходной");
        }
}

Console.WriteLine("введите цыфру дня недели");
int number = Convert.ToInt32(Console.ReadLine());

MetodOpredeleniyaVixodnogoDnya(number);
*/
//==============================================================================================================================