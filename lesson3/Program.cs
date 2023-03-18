Console.Clear();
//Задача 19. Напишите программум, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Введите пятизначное число: ");
String s = Console.ReadLine()!;

while(s.Length != 5) {
    Console.Write("Введите пятизначное число: ");
    s = Console.ReadLine()!;
}

if(s[0] == s[4] || s[1] == s[3]) {
    Console.Write("Число является палиндромом");
} else {
    Console.Write("Число не является палиндромом");
}

/*
//Задача 23. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координату X1: ");
double x1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Y1: ");
double y1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Z1: ");
double z1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату X2: ");
double x2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Y2: ");
double y2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите координату Z2: ");
double z2 = Convert.ToDouble(Console.ReadLine()!);

double s = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(s, 2)}");
*/

/*
//Задача 23. Напишите программу, которая принимает на вход число(N) и выдает таблицу кубов чисел от 1 до N
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i++)
    Console.Write(i*i*i + " ");
*/