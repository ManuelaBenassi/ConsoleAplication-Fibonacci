using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Selecione uma opção");
            WriteLine("1-Digitos centrais");
            WriteLine("2-Decimal para binário ");
            WriteLine("3-Fibonaci ");
            WriteLine("4-MDC ");
            WriteLine("5-Estatística ");
            int  opcao = int.Parse(ReadLine());
            switch (opcao)
            {
                case 1:
                    Clear();
                    NumerosCentrais nc = new NumerosCentrais();
                    nc.SomarCentrais();
                    EsperarEnter();
                    break;

                case 2:
                    Clear();
                    DecimalParaBinario dpb = new DecimalParaBinario();
                    dpb.TransformarParaBinario();
                    EsperarEnter();
                    break;
                case 3:
                    Clear();
                    Fibonaci f = new Fibonaci();
                    f.Sequencia();
                    EsperarEnter();
                    break;

                case 4:
                    Clear();
                    MDC mdc = new MDC();
                    mdc.CalcularEExibir();
                    EsperarEnter();
                    break;
                case 5:
                    Clear();
                    Estatistica e = new Estatistica();
                    e.Calcular();
                    EsperarEnter();
                    break;

            }
        }
        static void EsperarEnter()
        {
            WriteLine();
            Write("Pressione [Enter] para terminar.");
            ReadLine();
        }
    }
}
