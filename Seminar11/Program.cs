// Задача: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// Дополнить решение домашней задачи прошлого семинара, добавив возможность ввода массивов info и data пользователем. Проработать возможные частные случаи несоответствия данных в этих массивах.
/*
string data = string.Empty;
string dataNumberBin;
string info = string.Empty;
int counterDigitalBinTmp = 0;

while(true)
{
    Console.WriteLine("Введите двоичное представление числа в одной строке и нажмите enter. Для окончания ввода наберите end");

    dataNumberBin = Console.ReadLine();
    if(dataNumberBin == "end") break;
    data = data + dataNumberBin;
    info = info + Convert.ToString(data.Length - counterDigitalBinTmp);
    counterDigitalBinTmp = data.Length;
}

Console.Write("data ");

for (int i = 0; i < data.Length; i++)
{
    Console.Write($"{data[i]} ");
}

Console.WriteLine();
Console.Write("info ");

for (int i = 0; i < info.Length; i++)
{
    Console.Write($"{info[i]} ");
}

Console.WriteLine();

int indexStart = 0;
int indexFinish = 1;
int counter = 0;
int amountNumberData = data.Length;
int counterAmauntNumberData = 0;

int[] massivNum = new int[info.Length];

while(counter < info.Length)
{
    int decimalNum = 0;
    int stepen = 0;

    counterAmauntNumberData = counterAmauntNumberData + Convert.ToInt32($"{info[counter]}");

    for (int i = indexFinish; i >= indexStart; i--)
    {
        decimalNum = decimalNum + (Convert.ToInt32($"{data[i]}") * (int)Math.Pow(2,stepen));
        stepen++;
    }

    massivNum[counter] = decimalNum;
    counter++;
    if(counter == info.Length) break;
    indexStart = indexFinish + 1;
    if(counter == 1) indexFinish = 1;
    indexFinish = indexFinish + Convert.ToInt32($"{info[counter]}");
}

for (int i = 0; i < counter; i++)
{
    Console.Write($"[{massivNum[i]}]");
}
*/
//=====================================================================================================================================