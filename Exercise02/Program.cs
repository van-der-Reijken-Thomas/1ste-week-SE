Console.WriteLine("waarde A");
string waardeA = Console.ReadLine();

Console.WriteLine("waarde B");
string waardeB = Console.ReadLine();

int a = int.Parse(waardeA);
int b = int.Parse(waardeB);

int som = a + b;
Console.WriteLine($"De som van {a} en {b} is {som}.");
