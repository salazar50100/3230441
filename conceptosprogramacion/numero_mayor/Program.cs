﻿do
{
    Console.WriteLine("ingrese el primer numero entero: ");
    var n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el segundo numero entero: ");
    var n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese el tercer numero entero: ");
    var n3 = int.Parse(Console.ReadLine());

    if (n1 > n2 & n2 > n3)
    {
        Console.WriteLine($"El numero mayor es: {n1}");
    }
    else if (n1 > n3 & n3 > n2)
    {
        Console.WriteLine($"El numero mayor es: {n1}");
    }
    else if (n2 > n1 & n1 > n3)
    {
        Console.WriteLine($"El numero mayor es: {n2}");
    }
    else if (n2 > n3 & n3 > n1)
    {
        Console.WriteLine($"El numero mayor es: {n2}");
    }
    else if (n3 > n1 & n1 > n2)
    {
        Console.WriteLine($"El numero mayor es: {n3}");
    }
    else
    {
        Console.WriteLine($"El numero mayor es: {n3}");
    }
}
while (true);