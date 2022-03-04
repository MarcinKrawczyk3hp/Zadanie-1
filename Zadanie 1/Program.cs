// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




double a, b, c;

string input;

Console.WriteLine("Podaj parametry według wzoru ogólnego: F(x) = ax^2 + bx + c");

do
{
    Console.WriteLine("Podaj a:");
    input = Console.ReadLine() ?? "";
} while (input != "");
a = double.Parse(input);
do
{
    Console.WriteLine("Podaj b:");
    input = Console.ReadLine() ?? "";
} while (input != "");
b = double.Parse(input);
do
{
    Console.WriteLine("Podaj c:");
    input = Console.ReadLine() ?? "";
} while (input != "");
c = double.Parse(input);

double delta = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine("Delta wynosi: " + delta.ToString());

if (delta < 0)
{
    Console.WriteLine("Delta jest mniejsza od zera.");
    Console.WriteLine("Równanie nie ma pierwiastków");
}
else
{
    double deltaRoot = Math.Sqrt(delta);
    Console.WriteLine("Pierwiastek z delty wynosi:" + deltaRoot.ToString());
    if (delta > 0) 
    {
        double x1, x2;
        x1 = ((-1) * b - deltaRoot) / (2 * a);
        x2 = ((-1) * b + deltaRoot) / (2 * a);
        Console.WriteLine("Delta jest większa od zera");
        Console.WriteLine("x1: " + x1.ToString());
        Console.WriteLine("x2: " + x2.ToString());
    }
    else if (delta == 0)
    {
        double x;
        x = ((-1) * b) / (2 * a);
        Console.WriteLine("Delta jest równa zero");
        Console.WriteLine("x: " + x.ToString());
    }
}