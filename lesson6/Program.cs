/*//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
void InputArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        Console.Write($"Введите {i+1}-ое число: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine(string.Join(", ", arr));
}

void Check(int[] arr) {
    int check = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] > 0) {
            check++;
        }
    }
    Console.WriteLine(check);
}

Console.Write("Введите количество элементов: ");
int[] arr = new int[int.Parse(Console.ReadLine()!)];
InputArray(arr);
Check(arr);


*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();
Console.Write("Введите число b1: ");
double b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b2: ");
double b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k1: ");
double k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;

Console.WriteLine($"{x}, {y}");
