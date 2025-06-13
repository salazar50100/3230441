do {


    Console.WriteLine("ingrese un primer numero entero: ");
    var n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese un segundo numero entero: ");
    var n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese un tercer numero entero: ");
    var n3 = int.Parse(Console.ReadLine());

    int mayor;
    int medio;
    int menor;

    if (n1 > n2 & n1 > n3)
    {
        mayor = n1;
        if (n2 > n3)
        {
            medio = n2;
            menor = n3;
        }
        else
        {
            medio = n3;
            menor = n2;
        }
        Console.WriteLine($"el numero mayor es: {mayor} ");
        Console.WriteLine($"el numero medio es: {medio} ");
        Console.WriteLine($"el numero menor es: {menor} ");
    }

    else if (n2 > n1 & n2 > n3)
    {
        mayor = n2;
        if (n1 > n3)
        {
            medio = n1;
            menor = n3;
        }
        else
        {
            medio = n3;
            menor = n1;
        }
        Console.WriteLine($"el numero mayor es: {mayor} ");
        Console.WriteLine($"el numero medio es: {medio} ");
        Console.WriteLine($"el numero menor es: {menor} ");
    }
    else if (n3 > n1 & n3 > n2)
    {
        mayor = n3;
        if (n1 > n2)
        {
            medio = n1;
            menor = n2;
        }
        else
        {
            medio = n2;
            menor = n1;
        }
        Console.WriteLine($"el numero mayor es: {mayor} ");
        Console.WriteLine($"el numero medio es: {medio} ");
        Console.WriteLine($"el numero menor es: {menor} ");
    }
    


}while (true) ;

