/*//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void InputArray(int m, int n) {
    int[,] arr = new int[m, n];
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(-100, 101);
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

Console.Clear();
Console.Write("Введите размер массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine()!);

InputArray(m, n);
*/


/*//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такой позиции нет.

void InputArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(-100, 101);
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

void SearchElements(int[,] arr, int m, int n) {
    if(m < 3 && n < 4) {
        Console.WriteLine(arr[m, n]);
    } else 
        Console.WriteLine("Такой позиций не существует");
}

Console.Clear();
int[,] arr = new int[3, 4];
InputArray(arr);
Console.Write("Введите позицию массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите позицию элементов: ");
int n = int.Parse(Console.ReadLine()!);
SearchElements(arr, m, n);

*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(0, 101);
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

void SearchArif(int[,] arr) {
    double sum = 0; string m = "";
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            sum += arr[i, j];
        }
        m += sum/arr.GetLength(1) + "; ";
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: {m}");
}

Console.Clear();
int[,] arr = new int[3, 4];
InputArray(arr);
SearchArif(arr);

