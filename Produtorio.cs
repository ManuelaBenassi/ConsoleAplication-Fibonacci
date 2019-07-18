using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Produtorio
{
    protected int qtosValoresForamMultiplicados;
    protected double produtorio;
    public Produtorio()
    {
        qtosValoresForamMultiplicados = 0;
        produtorio = 1;
    }
    public void Multiplicar(double valorAMultiplicar)
    {
        produtorio *= valorAMultiplicar;
    }
    public double MediaGeometrica()
    {
        if (qtosValoresForamMultiplicados > 0)
        {
            return (Math.Pow(produtorio, -qtosValoresForamMultiplicados));
        }
        return default(double);
    }
    public double Valor
    {
        get => produtorio;
    }
}
