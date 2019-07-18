using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class DecimalParaBinario
    {
        double numero;
        public void TransformarParaBinario()
        {
            WriteLine("Digite um número entre 0 e 64 que quer transformar em binario");
            numero = double.Parse(ReadLine());
            double nD = numero;
            WriteLine(nD + " em Binário é ");
            Contador cont = new Contador(0, 6, 1);
            while (cont.Prosseguir())
            {
                double x = Math.Pow(2, 6 - cont.Valor);
                if (numero >= x)
                {
                    double elevarA = 6 - cont.Valor;
                    Write("1");
                    numero -= Math.Pow(2, 6 - cont.Valor);
                }
                else
                {
                    Write("0");
                }
                cont.Contar();

            }
            
        }
    }
}
