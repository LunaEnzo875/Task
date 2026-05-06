using System;

namespace SimBolillero;

public class Simulacion
{
    public long simularSinHilos(Bolillero bolillero, List<int> jugada, int CantidadSimulacion)
    {
        long Ganadas = 0;

        for (int i = 0; i < CantidadSimulacion; i++)
        {
            if (bolillero.jugada(jugada))
            {
                Ganadas++;
            }
        }

        return Ganadas;
    }
        

}