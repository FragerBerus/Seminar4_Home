// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum = 0;
Console.Write("Введите целое положительное число от 0 до 2 147 483 647: ");
int NumberDigit = Convert.ToInt32(Console.ReadLine());
int Number = NumberDigit;
if (Number < 0 || Number > 2147483647)
{
    Console.WriteLine("Введенное число не соответствует условиям задачи.");
}
else
{
    while (NumberDigit > 0)
    {
        Sum  = Sum + NumberDigit % 10;
        NumberDigit = NumberDigit / 10;
    }
}
Console.WriteLine("Сумма всех цифр числа " + Number + " равна " + Sum);