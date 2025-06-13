do{
    Console.WriteLine("ingrese un primer numero entero: ");
    var n1 = (Console.ReadLine());
    if (int.TryParse(n1, out int n1int))
    {
        Console.WriteLine("ingrese un segundo numero entero: ");
        var n2 = (Console.ReadLine());
        if (int.TryParse(n2, out int n2int))
        {
            if (n1int % n2int == 0)
            {
                Console.WriteLine($"el numero: {n2}, es multiplo de: {n1}");
            }
            else
            {
                Console.WriteLine($"el numero: {n2}, no es multiplo de: {n1}");
            }
        }
        else
        {
            Console.Write("debes ingresar un numero entero");
        }

    }
    else
    {
        Console.Write("debes ingresar un numero entero");
    }


}
while (true);

