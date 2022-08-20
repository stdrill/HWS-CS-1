int a = new Random().Next(1, 50);
int b = new Random().Next(1, 50);
int c = new Random().Next(1, 50);
Console.WriteLine("{0} {1} {2}", a, b, c);
int max = a;
if (b > max) {
    max = b;
} else if (c > max) {
    max = c;
}
Console.WriteLine(max);