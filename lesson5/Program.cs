/*//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void InputArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(100, 1000);
    }
}

int SearchEvenNumbers(int[] arr) {
    int n = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] % 2 == 0) {
            n++;
        }
    }
    return n;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int[] arr = new int[int.Parse(Console.ReadLine()!)];
InputArray(arr);
Console.WriteLine($"Началный массив: [{string.Join(", ", arr)}]");
Console.Write("Количество четных чисел: ");
Console.Write(SearchEvenNumbers(arr));

*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void InputArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1, 100);
    }
}

int SumOddNumbers(int[] arr) {
    int n = 0;
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] % 2 == 1) {
            n += arr[i];
        }
    }
    return n;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int[] arr = new int[int.Parse(Console.ReadLine()!)];
InputArray(arr);
Console.WriteLine($"Началный массив: [{string.Join(", ", arr)}]");
Console.Write("Сумма нечетных чисел: ");
Console.Write(SumOddNumbers(arr));

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(1, 100);
    }
}

int SearchMax(int[] arr) {
    int max = arr[0];
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
    }
    return max;
}

int SearchMin(int[] arr) {
    int min = arr[0];
    for(int i = 0; i < arr.Length; i++) {
        if(arr[i] < min) {
            min = arr[i];
        }
    }
    return min;
}


Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int[] arr = new int[int.Parse(Console.ReadLine()!)];
InputArray(arr);
Console.WriteLine($"Началный массив: [{string.Join(", ", arr)}]");
Console.Write("Разница между максимальным и минимальным: ");
Console.Write(SearchMax(arr) - SearchMin(arr));