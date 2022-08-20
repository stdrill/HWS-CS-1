int number = new Random().Next(100, 999);
Console.WriteLine(number);
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if (number % a == 0) {
    Console.WriteLine("Число кратно заданному");
} else {
    Console.WriteLine("Число не кратно заданному, остаток от деления: ");
    Console.Write(number % a);
}