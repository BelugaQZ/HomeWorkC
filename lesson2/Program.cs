Console.Clear();

/*
//задача 10
Console.Write("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine()!);

while(n < 100 || n > 999) {
    Console.Write("Введите трехзначное число:");
    int n = Convert.ToInt32(Console.ReadLine()!);
}
Console.Write((n / 10) % 10);
*/


//задача 13
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()!);

while(n < 100) {
    Console.WriteLine("Третьей цифры нет");
    Console.Write("Введите число:");
    n = Convert.ToInt32(Console.ReadLine()!);
}

while(n > 999) {
    n = n / 10;
}

Console.WriteLine(n % 10);


/*
//задача 15
Console.Write("Введите день недели:");
int n = Convert.ToInt32(Console.ReadLine()!);

while(n < 1 || n > 7) {
    Console.Write("Введите день недели:");
    int n = Convert.ToInt32(Console.ReadLine()!);
}

if(n > 5) {
    Console.WriteLine("Выходной");
} else {
    Console.WriteLine("Рабочий день");
}
*/