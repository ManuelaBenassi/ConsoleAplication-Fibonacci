using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Somatoria
{
    protected double soma;
    protected int quantosValoresForamSomados;
    public bool erroNaMedia;
    public Somatoria()
    {
        soma = 0;
        quantosValoresForamSomados = 0;
        erroNaMedia = false;
    }
    public void Somar(double valorASerSomado)
    {
        soma += valorASerSomado;
        quantosValoresForamSomados += 1;
    }
    public double MediaAritmetica()
    {
        erroNaMedia = false;
        if (quantosValoresForamSomados > 0)
            return soma / quantosValoresForamSomados;
        erroNaMedia = true; // indica que não foi possível calcular a média
        return default(double);
    }
    public double Soma
    {
        get => soma;
    }
    public double Quantos
    {
        get => quantosValoresForamSomados;
    }
}
