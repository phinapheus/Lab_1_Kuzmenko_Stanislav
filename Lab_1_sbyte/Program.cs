sbyte a = 2;
sbyte b = 6;
Console.WriteLine("Unary operations with sbyte");
Console.WriteLine(++a);
Console.WriteLine(--b);
Console.WriteLine("Binary operations with sbyte");
Console.WriteLine((sbyte)(a + b));
Console.WriteLine((sbyte)(a - b));
Console.WriteLine((sbyte)(a * b));
Console.WriteLine((sbyte)(a / b));
Console.WriteLine((sbyte)(a % b));
Console.WriteLine("Ternary operation with sbyte");
Console.WriteLine((sbyte)(a < b ? a * b : a / b));
if (a > b)
    Console.WriteLine($"number {a} > {b}");
else
    Console.WriteLine($"number {a} < {b}");