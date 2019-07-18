using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class MDC
    {
        double v1, v2, resto = 1, numSResto, quociente, vMaior, vMenor,nCerto;
        double vD;
        double vMD;
        public void CalcularEExibir()
        {
            WriteLine("Digite o primeiro número do MDC");
            v1 = double.Parse(ReadLine());
            WriteLine("Digite o segundo número do MDC");
            v2 = double.Parse(ReadLine());

            while (resto != 0)
            {
                if (v1 > v2)
                {
                    vMenor = v2;
                    vMaior = v1;
                    vD = vMenor;
                    vMD = vMaior;

                }
                if (v1 < v2)
                {
                    vMaior = v2;
                    vMenor = v1;
                    vD = vMenor;
                    vMD = vMaior;
                }
                resto = vMaior % vMenor;
                numSResto = vMaior - resto;
                quociente = numSResto / vMenor;
                
                  v1 = vMenor;
                  v2 = resto;
                
               
            }
            if(vMD % vD == 0)
            {
                nCerto = vMD / quociente;
                WriteLine("O MDC é " + nCerto);
            }
            else
                WriteLine("O MDC é " + quociente);

        }
    }
}

