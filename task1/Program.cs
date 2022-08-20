// По двум заданным числам проверять является ли первое квадратом второго

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if (a == c) {
    Console.WriteLine("Первое число является квадратом второго");
} else {
    Console.WriteLine("Первое число не является квадратом второго");
}
