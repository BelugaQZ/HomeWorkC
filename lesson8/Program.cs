//Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива 
void InputArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(1, 101);
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

void PrintArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

void SortArray(int[,] arr) {
    for(int row = 0; row < arr.GetLength(0); row++) {
        for(int col = 0; col < arr.GetLength(1) - 1; col++) {
            for(int nextCol = col + 1; nextCol < arr.GetLength(1); nextCol++) {
                if(arr[row, col] < arr[row, nextCol]) {
                    int temp = arr[row, col];
                    arr[row, col] = arr[row, nextCol];
                    arr[row, nextCol] = temp;
                }
            }
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,] arr = new int[size[0], size[1]];
InputArray(arr);
SortArray(arr);
Console.WriteLine();
PrintArray(arr);


/*//Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void InputArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(1, 101);
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    
}

void SortArray(int[,] arr) {
    int n = 0, min = 1000, rows = 0;
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            n += arr[i, j];
        }
        if(n < min) {min = n; rows = i;} 
        n = 0;
    }
    Console.Write($"Наименщий элемент массива: {rows + 1} строка ({min})");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,] arr = new int[size[0], size[1]];
InputArray(arr);
SortArray(arr);
*/

/*//Задача 58. Задайте две матрицы. Напишите программу которая будет находить произведение двух матриц.
void InputArray(int[,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(0, 11);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] matrixA, int[,] matrixB) {
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for(int i = 0; i < matrixA.GetLength(0); i++) {
        for(int j = 0; j < matrixB.GetLength(1); j++) {
            for(int k = 0; k < matrixB.GetLength(0); k++) {
                result[i, j] += matrixA[i, k] * matrixB[k, j];

            }
            Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,] matrixA = new int[size[0], size[1]];
int[,] matrixB = new int[size[0], size[1]];
InputArray(matrixA);
Console.WriteLine();
InputArray(matrixB);
Console.WriteLine();
MultiplyMatrix(matrixA, matrixB);

*/

/*//Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void InputArray(int[,,] arr) {
    for(int i = 0; i < arr.GetLength(0); i++) {
        for(int j = 0; j < arr.GetLength(1); j++) {
            for(int k = 0; k < arr.GetLength(2); k++) {
                arr[i, j, k] = new Random().Next(10, 101);
            }
        }
    }
}

void PrintArray(int[,,] arr) {
    for(int k = 0; k < arr.GetLength(2); k++) {
        for(int i = 0; i < arr.GetLength(0); i++) {
            for(int j = 0; j < arr.GetLength(1); j++) {
                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) "); 
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(i => int.Parse(i)).ToArray();
int[,,] arr = new int[size[0], size[1], size[2]];
InputArray(arr);
PrintArray(arr);
*/