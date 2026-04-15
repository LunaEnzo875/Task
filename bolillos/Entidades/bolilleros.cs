using System;

namespace SimBolillero;

public class Bolillero
{
    public int cantJugadas { get; set; }
    public List<int> bolillas { get; set; }
    public List<int> bolillasSacadas { get; set; }

    public Bolillero(int cantJugadas, List<int> bolillas,List<int> bolillasSacadas)
    {
        this.cantJugadas = cantJugadas;
        this.bolillas = bolillas;
        this.bolillasSacadas = bolillasSacadas;
    }

    public void sacarBolilla()
    {
        Random r = new Random();
        int Jugada = r.Next(bolillas.Count);
        List<int> bolillasSacadas = new List<int>(Jugada);
        bolillasSacadas.Add(bolillas[Jugada]);
    }

    
}