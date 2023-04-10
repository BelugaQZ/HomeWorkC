/*//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
static string InputNumbers(int i) {
    if(i == 1) {
        return "1 ";
    } else {
        return $"{i} " + InputNumbers(i - 1);
    }
}

Console.Clear();
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(InputNumbers(n));
*/

/*//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
static int SumNumbers(int m, int n) {
    if(n == m) {
        return m;
    } else {
        return m + SumNumbers(m + 1, n);
    }
}

Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(SumNumbers(m, n));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
static int akkerman(int m, int n) {
    if(m == 0) {return n + 1;}
    if(m > 0 && n == 0) {return akkerman(m - 1, 1);}
    if(m > 0 && n > 0) {return akkerman(m - 1, akkerman(m, n - 1));}
    return 0;
}

Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(akkerman(m, n));
