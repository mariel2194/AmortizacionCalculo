using System;


class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Prestamo prestamo = new Prestamo(50000, 3, 0.06);

  
        Console.WriteLine(prestamo.CalculoSaldoAcumulado());


    }
}