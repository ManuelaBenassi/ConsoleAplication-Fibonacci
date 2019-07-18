using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class NumerosCentrais
    {
        double pDigito, sDigito, tDigito;//primeiro,segundo e terceiro digito
        int vI, vF;
        public void SomarCentrais()
        {
            WriteLine("Digite o valor inicial:");
            vI = int.Parse(ReadLine());
            WriteLine("Digite o valor final:");
            vF = int.Parse(ReadLine());
            Contador cont = new Contador(vI,vF,1);
            Somatoria soma = new Somatoria();
            while(cont.Prosseguir())
            {
                double pD = cont.Valor / 1000;
                double sD = cont.Valor / 100;
                double tD = cont.Valor / 10;
                pDigito = Math.Floor(pD);//divide o numero por 1000 e arredonda pra baixo, assim pega o primeiro digito
                sDigito = Math.Floor(sD) - pDigito * 10;
                tDigito = Math.Floor(tD) - (pDigito * 100 + sDigito * 10);
                soma.Somar(sDigito + tDigito);
                cont.Contar();
            }
            WriteLine(soma.Soma);
        }
    }
}
