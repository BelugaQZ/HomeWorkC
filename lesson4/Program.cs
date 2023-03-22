Console.Clear();

/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()!);
int result = a;

for(int i = 1; i < b; i++) {
    result = result*a;
}
Console.WriteLine(result);
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите числa: ");
string a = Console.ReadLine()!;
int result = 0;

for(int i = 0; i < a.Length; i++) {
    result += Convert.ToInt32(a[i].ToString());
}

Console.WriteLine(result);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};
for(int i = 0; i < arr.Length; i++) 
    Console.Write(arr[i] + " ");