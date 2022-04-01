//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void KolichestvoBolshe0(int[] massivNum)
{
    int counter = 0;
    int[] massivBolshe0 = new int[massivNum.GetLength(0)];

    for (int i = 0; i < massivBolshe0.GetLength(0); i++)
    {
        massivBolshe0[i] = massivNum[i];
        if(massivBolshe0[i] > 0) counter = counter + 1;
        Console.Write($"{massivBolshe0[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"{counter} чисел больше 0");
}

Console.WriteLine("введите количество чисел для проверки");
int counteNumber = Convert.ToInt32(Console.ReadLine());
int[] massivNumber = new int[counteNumber];

for (int i = 0; i < massivNumber.GetLength(0); i++)
{
    Console.WriteLine("введите целое число");
    massivNumber[i] = Convert.ToInt32(Console.ReadLine());
}

KolichestvoBolshe0(massivNumber);
*/
//=============================================================================================================================
// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.
/*
void PrintMatrix(int[,] massivNum)
{
    for (int i = 0; i < massivNum.GetLength(0); i++)
    {
        for (int j = 0; j < massivNum.GetLength(1); j++)
        {
            if(i == 0 || i == massivNum.GetLength(0) - 1 || j == 0 || j == massivNum.GetLength(1) - 1) massivNum[i,j] = 1;
            else massivNum[i,j] = 0;
            Console.Write($"{massivNum[i,j]} ");
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Задайте количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] massivNumber = new int[rows,columns];

PrintMatrix(massivNumber);
*/
//============================================================================================================================================
