using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class Fibonaci
    {
        int posicao, nAnterior = 1, nAtual, nAntesAnterior = 1;
        public void Sequencia()
        {
            WriteLine("Digite o número da posiçao que quer sequenciar até");
            posicao = int.Parse(ReadLine());
            Contador cont = new Contador(1, posicao-2, 1);
            WriteLine('1');
            WriteLine('1');
            while (cont.Prosseguir())
            {
                nAtual = nAntesAnterior + nAnterior;
                WriteLine(nAtual);
                nAntesAnterior = nAnterior;
                nAnterior = nAtual;
                cont.Contar();
            }
        }
    }
}
