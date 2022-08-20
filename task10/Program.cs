int number = new Random().Next(1,999);
Console.WriteLine(number);
if (number < 100) {
    Console.WriteLine("Третьей цифры нет");
} else {
    Console.WriteLine(number % 10);
}