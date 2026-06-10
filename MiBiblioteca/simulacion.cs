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

        
        public long SimularConHilos(Bolillero bolillero, List<int> jugada, int CantidadSimulacion, int cantidadHilos)
        {
            Task<long>[] tareas = new Task<long> [cantidadHilos];
            int baseCantidad = CantidadSimulacion / cantidadHilos;
            int resto = CantidadSimulacion % cantidadHilos;
            
            for (int i = 0; i < cantidadHilos; i++)
            {
                int cantidadParaEsteHilo = baseCantidad + (i < resto ? 1 : 0);

                tareas.Append(Task.Run(() =>
                simularSinHilos(bolillero.ClonDeLaListaBolillero(), jugada, cantidadParaEsteHilo)
                ));
            }

            Task.WaitAll(tareas);
            return  tareas.Sum(t => t.Result);
        }
        










        public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int CantidadSimulacion, int cantidadHilos)
        {
            Task<long>[] tareas = new Task<long> [cantidadHilos];
            int baseCantidad = CantidadSimulacion / cantidadHilos;
            int resto = CantidadSimulacion % cantidadHilos;
            
            for (int i = 0; i < cantidadHilos; i++)
            {
                int cantidadParaEsteHilo = baseCantidad + (i < resto ? 1 : 0);

                var si =
                Task.Run(() => simularSinHilos(bolillero.ClonDeLaListaBolillero(), jugada, cantidadParaEsteHilo)
                );
            }

            Task.WaitAll(tareas);
            return  tareas.Sum(t => t.Result);
        }
}