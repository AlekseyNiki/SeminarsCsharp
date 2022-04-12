// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
/*
int[] data = {0,1,1,1,1,0,0,0,1};
int[] info = {2,3,3,1};
int indexStart = 0;
int indexFinish = 1;
int counter = 0;
int stepen = 0;

double[] massivNum = new double[info.Length];

while(counter < info.Length)
{
    double decimalNum = 0;
    stepen = 0;

    for (int i = indexFinish; i >= indexStart; i--)
    {
        decimalNum = decimalNum + (data[i] * Math.Pow(2,stepen));
        stepen++;
    }

    massivNum[counter] = decimalNum;
    counter++;
    if(counter == 4) break;
    indexStart = indexFinish + 1;
    if(counter == 1) indexFinish = 1;
    indexFinish = indexFinish + info[counter];
}

for (int i = 0; i < massivNum.Length; i++)
{
    Console.Write($"[{massivNum[i]}]");
}
*/
//=======================================================================================================================================