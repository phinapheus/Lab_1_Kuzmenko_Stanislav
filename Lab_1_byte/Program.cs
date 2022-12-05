byte a = 8;
byte b = 2;
Console.WriteLine("Unary operations with byte");
Console.WriteLine(++a);
Console.WriteLine(--b);
Console.WriteLine("Binary operations with byte");
Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);
Console.WriteLine("Ternary operation with byte");
Console.WriteLine(a < b ? a * b : a / b);//if a < b => a * b, a > b => a / b
if (a > b)
    Console.WriteLine($"number {a} > {b}");
else
    Console.WriteLine($"number {a} < {b}");