//Ввод чисел

Console.Clear(); //очистка консоли
//int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * 3);

/*
//задача 1
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine()!);
//интерполяция строк
//Console.WriteLine($"Результат {a} + {b} = {a + b}");
if((a*a) == b) 
    Console.WriteLine("Да");
else if((b*b) == a)
    Console.WriteLine("Да");
else 
    Console.WriteLine("Нет");
*/


/*
//задача 2
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine()!);

if(a > b) 
    Console.WriteLine($"Max = {a}\nmin = {b}");
else 
    Console.WriteLine($"Max = {b}\nmin = {a}");
*/


/*
//задача 3
Console.Write("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine()!);

while(n < 1 || n > 7) {
    Console.Write("Вы ошиблись\nВведите день недели:");
    int n = Convert.ToInt32(Console.ReadLine()!);
}

if(n == 1) 
    Console.Write("Понедельник");
else if(n == 2)
    Console.Write("Вторник");
else if(n == 3) 
    Console.Write("Среда");
else if(n == 4) 
    Console.Write("Четверг");
else if(n == 5) 
    Console.Write("Пятница");
else if(n == 6) 
    Console.Write("Суббота");
else (n == 7) 
    Console.Write("Воскресенье");
*/


/*
//задача 4
Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine()!);

if(a > b) {
    if(a > c) 
        Console.WriteLine("Max = " + a);
    else
        Console.WriteLine("Max = " + c);
} else {
    if(b > c) 
        Console.WriteLine("Max = " + b);
    else
        Console.WriteLine("Max = " + c);
}

*/

/*
//задача 6
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine()!);

if(a % 2 == 0) 
    Console.WriteLine("Да");
else 
    Console.WriteLine("Нет");

*/

//задача 8
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()!);

for(int i = 2; i <= n; i = i+2)
    Console.Write($"{i} ");