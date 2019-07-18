using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Matematica
{
    int numeroInteiro;
    public Matematica(int valorDesejado)
    {
        numeroInteiro = valorDesejado;
    }
    public bool EhPalindromo()
    {
        int aux = 0, numero = numeroInteiro;
        while (numero > 0)
        {
            int quociente = numero / 10;
            int resto = numero - quociente * 10;
            aux = aux * 10 + resto;
            numero = quociente;
        }
        return (aux == numeroInteiro);
    }
    public int Fatorial()
    {
        var oFatorial = new Produtorio();
        var umContador = new Contador(1, numeroInteiro, 1);
        while (umContador.Prosseguir())
        {
            oFatorial.Multiplicar(umContador.Valor);
            umContador.Contar(); // gera o próximo número
        }
        return Convert.ToInt32(oFatorial.Valor);
    }
    public string Divisores()
    {
        string lista = ""; // inicia variável string com cadeia vazia
        int metadeNumero = numeroInteiro / 2;
        var possivelDivisor = new Contador(2, metadeNumero, 1);
        while (possivelDivisor.Prosseguir())
        {
            int quociente = numeroInteiro / possivelDivisor.Valor;
            int resto = numeroInteiro - quociente * possivelDivisor.Valor;
            if (resto == 0)
                lista = lista + Convert.ToString(possivelDivisor.Valor) + ", ";
            possivelDivisor.Contar(); // gera próximo potencial divisor
        }
        return "1, " + lista + numeroInteiro; // concatena inteiros sem conversão
    }
    public int mdc(int outroNumero)
    {
        int resto = 0, oMDC = 0;
        int dividendo = numeroInteiro; // declara e inicia variável dividendo
        int divisor = outroNumero; // declara e inicia variável divisor
        do
        {
            int quociente = dividendo / divisor;
            resto = dividendo - divisor * quociente;
            if (resto == 0)
                oMDC = divisor;
            dividendo = divisor; // Divisor será novo dividendo
            divisor = resto; // Resto será o novo divisor
        }
        while (resto != 0);
        return oMDC;
    }
}


