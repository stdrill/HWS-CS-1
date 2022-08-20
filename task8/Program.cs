string number = Convert.ToString(new Random().Next(100, 999));
Console.WriteLine(number);
string number2 = Convert.ToString(number[0] + "" + number[2]);
Console.WriteLine(number2);


