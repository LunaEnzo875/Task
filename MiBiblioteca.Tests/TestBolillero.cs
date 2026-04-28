using SimBolillero;
using System;
using System.Collections.Generic;
using Xunit;

namespace SimBolillero.Test;

public class TestBolillero
{
    [Fact]
    public void TestSacarBolilla()
    {
        var bolillero = new Bolillero(0, new List<int> { 1, 2, 3 }, new List<int>());
        
        int bolillaSacada = bolillero.SacaryVerBolilla();
        
        Assert.Contains(bolillaSacada, new List<int> { 1, 2, 3 });
        Assert.DoesNotContain(bolillaSacada, bolillero.bolillas);
        Assert.Contains(bolillaSacada, bolillero.bolillasSacadas);
    }
}


