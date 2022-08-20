// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int number = new Random().Next(100, 999);
Console.WriteLine(number);
Console.Write("Задайте число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (number % a == 0) {
    Console.WriteLine("Число кратно заданному");
} else {
    Console.Write("Число не кратно заданному, остаток от деления: ");
    Console.WriteLine(number % a);
}