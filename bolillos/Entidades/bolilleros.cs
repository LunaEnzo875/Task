using System;

namespace SimBolillero;

public class Bolillero
{
    public int cantJugadas { get; set; }
    public List <int> bolillas { get; set; }
    public int sacarBolilla()
    {
        Random r = new Random();
        int Jugada = r.Next(bolillas.Count);
        return bolillas [Jugada];
    }
}