string number = Convert.ToString(new Random().Next(10,99));
Console.WriteLine(number);
if (number[0] == number[1]) {
    Console.WriteLine("Оба числа равны "+number[0]);
} else if (number[0] > number[1]) {
    Console.WriteLine(number[0]);
} else {
    Console.WriteLine(number[1]);
}