// Задача 67. Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 452 -> 12
// 45 -> 9

int SummOfFigures(int N)
{
    if (N < 1) return 0;
    return N % 10 + SummOfFigures(N / 10);
}
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

SummOfFigures(ReadInt("Введите значение N: "));