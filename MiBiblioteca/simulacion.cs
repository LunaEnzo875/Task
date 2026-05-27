using System;
using 
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
        
        public long SimularConHilos(Bolillero bolillero, List<int> jugada, int CantidadSimulacion, int cantidadHilos)
        {
            var tareas = new List<Task<long>>();
            long Ganadas = 0;
            int baseCantidad = CantidadSimulacion / cantidadHilos;
            int resto = CantidadSimulacion % cantidadHilos;
            
            for (int i = 0; i < cantidadHilos; i++)
            {
                int cantidadParaEsteHilo = baseCantidad + (i < resto ? 1 : 0);

                tareas.Add(Task.Run(() =>

             for (int i = 0; i < CantidadSimulacion; i++);
            
                if (bolillero.jugada(jugada))
                {
                    Ganadas++;
                }

            return Ganadas
                ));
            }

            var resultados = Task.WhenAll(tareas).Result;
            return resultados.Sum();
        }
        
    public async long SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int CantidadSimulacion, int cantidadHilos)
    {
            var tareas = new List<Task<long>>();

            int baseCantidad = CantidadSimulacion / cantidadHilos;
            int resto = CantidadSimulacion % cantidadHilos;

            for (int i = 0; i < cantidadHilos; i++)
            {
                int cantidadParaEsteHilo = baseCantidad + (i < resto ? 1 : 0);

                tareas.Add(Task.Run(async () =>
                    simularSinHilos(bolillero.ClonDeLaListaBolillero(), jugada, cantidadParaEsteHilo)
                ));
            }

            var resultados = Task.WhenAll(tareas).Result;
            return resultados.Sum();
    }
}
