// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.Write("Введите целое число А, которое является основанием степени: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B, которое является показателем степени: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int Degree = NumberA;
if (NumberB == 0)
{
    Console.WriteLine(NumberA + " в степени 0 равно 1");
}
else
{
    for (int i = 1; i < NumberB; ++i)
    {
        Degree = Degree * NumberA;
    }
    Console.WriteLine(NumberA + " в степени " + NumberB + " равно " + Degree);
}