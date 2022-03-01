/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее*/
/*
Console.WriteLine("Введите первое число для проверки какое больше");
int ChisloPervoe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки какое больше");
int ChisloVtoroe = Convert.ToInt32(Console.ReadLine());

if(ChisloPervoe > ChisloVtoroe)
{
    Console.WriteLine("Первое число больше");
}
else if(ChisloPervoe == ChisloVtoroe)
    {
        Console.WriteLine("Вы ввели одинаковые числа");
    }
    else
    {
        Console.WriteLine("Второе число больше");
    }
*/

//==================================================================================================================================

//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите первое число для проверки какое больше");
int ChisloPervoe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число для проверки какое больше");
int ChisloVtoroe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число для проверки какое больше");
int ChisloTretee = Convert.ToInt32(Console.ReadLine());

if (ChisloPervoe==ChisloVtoroe && ChisloVtoroe==ChisloTretee)
{
    Console.WriteLine("Введены одинаковые числа");
}
else if (ChisloPervoe > ChisloVtoroe)
    {
        if (ChisloPervoe > ChisloTretee)
        {
            Console.WriteLine("Первое число максимальное");
        }
    }   else if (ChisloVtoroe > ChisloTretee)
            {
                Console.WriteLine("Второе число максимальное");
            }
    
            else
            {
                Console.WriteLine("Третье число максимальное");
            }
*/
//====================================================================================================================================================
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("число чётное");
}
else
{
    Console.WriteLine("число не чётное");
}
*/
//=====================================================================================================================
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число для вывода чётных чисел от 1 до введённого числа");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= number)
{
    if(index % 2 ==0)
    {
        Console.Write(index + " ");
        index = index + 1;
    }
    else
    {
        index = index + 1;
    }
}
*/
//=====================================================================================================