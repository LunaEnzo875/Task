using ISimBolillero;
using SimBolillero;
namespace serviBolillo;

public class BolilloServi : IBolillero
{
    public bool SacarBolilla_Y_Verjugada(Bolillero bolillero)
    {
        if (bolillero == null || bolillero.bolillas == null || bolillero.bolillas.Count == 0)
            return false;

        int sacada = bolillero.sacarBolilla();

        return true;
    }
}