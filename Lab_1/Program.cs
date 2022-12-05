bool a = true;
bool b = false;

Console.WriteLine("operations with bool");
//Arithmetic operations with bool variable are not available
Console.WriteLine(a & b);//false, and
Console.WriteLine(a | b);//true, or
Console.WriteLine(a ^ b);//if a and b =true, then result = false, if a =true, b =false, then result = true
Console.WriteLine(a != b ? a & b : a | b);
if (a = b)
    Console.WriteLine(b);
else
    Console.WriteLine(a);//
