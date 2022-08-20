// Показать вторую цифру трёхзначного числа

string number = Convert.ToString(new Random().Next(100, 999));
Console.WriteLine(number);
Console.WriteLine(number[1]);