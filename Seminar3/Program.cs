//==========================================================================================================================================
// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int NumSleva = number / 10000;
int NumSprava = number % 10;

if(NumSleva == NumSprava)
{
    NumSleva = (number / 1000) % 10;
    NumSprava = (number % 100) / 10;
    if (NumSleva == NumSprava)
    {
        Console.WriteLine("число является палиндромом");
    }
    else
    {
        Console.WriteLine("не являются палиндромом");
    }
}
else
{
    Console.WriteLine("не являются палиндромом");
}
*/
//=======================================================================================================================================
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Rasstoyanie3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xRasstoyanie = x2 - x1;
    double yRasstoyanie = y2 - y1;
    double zRasstoyanie = z2 - z1;
    double rezalt = Math.Sqrt(Math.Pow(xRasstoyanie,2) + Math.Pow(yRasstoyanie,2) + Math.Pow(zRasstoyanie,2));
    return rezalt;
}

double xA, yA, zA, xB, yB, zB;
Console.Write("Введите координату xA ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату yA ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату zA ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату xB ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату yB ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату zB ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Rasstoyanie3D(xA, yA, zA, xB, yB, zB));
*/
//=====================================================================================================================
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
int kubNumer = 1;

while(index <= number)
{
    kubNumer = Convert.ToInt32(Math.Pow(index,3));
    Console.Write(kubNumer + " ");
    index = index + 1;
}
*/
//============================================================================================================================