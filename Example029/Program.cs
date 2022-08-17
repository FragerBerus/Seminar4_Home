// Задача 29:
// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
int[] DataBase = new int [8];
int length = DataBase.Length;
int index = 0;
Console.Write("Элементы массива случайных чисел DataBase: [");
for (index = 0; index < length; index++)
{
    DataBase[index] = new Random().Next(1, 100);
    Console.Write(DataBase[index]);
    if (index < 7)Console.Write(", ");
}
Console.Write("]");