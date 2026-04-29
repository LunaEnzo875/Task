using System;

namespace SimBolillero;

public class Bolillero aaaa
{
    private static readonly Random rnd = new Random();
    public int cantJugadas { get; set; }
    public List<int> bolillas { get; set; }
    public List<int> bolillasSacadas { get; set; }

    public Bolillero(int cantJugadas, List<int> bolillas,List<int> bolillasSacadas)
    {
        this.cantJugadas = cantJugadas;
        this.bolillas = bolillas;
        this.bolillasSacadas = bolillasSacadas;
    }

    public int SacaryVerBolilla()
    {
        
        if (bolillas == null || bolillas.Count == 0)
            throw new InvalidOperationException("No hay bolillas para sacar.");

        int index = rnd.Next(bolillas.Count);
        int valor = bolillas[index];

        bolillas.RemoveAt(index);
        bolillasSacadas.Add(valor);
        
        Console.WriteLine($"Sacaste: {valor}");

        return valor;
    }
    
}