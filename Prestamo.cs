using System;

public class Prestamo
{

    public double Cantidad { get; set; }
    public int TiempoEnAnios { get; set; }
    public double InteresAnual { get; set; }
    public int FrecuenciaInteres = 12;

    public Prestamo(double cantidad, int tiempoEnAnios, double interesAnual)
    {
        Cantidad = cantidad;
        TiempoEnAnios = tiempoEnAnios;
        InteresAnual = interesAnual;
    }


    public double CalculoSaldoAcumulado()
    {
        return Cantidad* (Math.Pow((1+(InteresAnual/FrecuenciaInteres)),(FrecuenciaInteres*TiempoEnAnios)));

    }
}