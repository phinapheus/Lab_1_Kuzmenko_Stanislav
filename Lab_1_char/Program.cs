char a = 'S';//symbol
char b = 'F';
Console.WriteLine("Unary operations with char");
Console.WriteLine(++a);
Console.WriteLine(--b);
Console.WriteLine("Binary operations with char");
Console.WriteLine((char)(a + b));
Console.WriteLine((char)(a - b));
Console.WriteLine((char)(a * b));
Console.WriteLine((char)(a / b));
Console.WriteLine((char)(a % b));
Console.WriteLine("Ternary operation with char");
Console.WriteLine((char)(a < b ? a - b : a + b));
