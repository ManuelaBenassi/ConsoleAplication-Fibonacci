using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1Projeto19184
{
    class Estatistica
    {
        int qtosValores,impares,pares,vMaior,vMenor,n;
        public void Calcular()
        {
            WriteLine("Digite o número da posiçao que quer sequenciar até");
            qtosValores = int.Parse(ReadLine());
            Contador cont = new Contador(1, qtosValores, 1);
            Somatoria soma = new Somatoria();
            while (cont.Prosseguir())
            {
                n = int.Parse(ReadLine());
                if(cont.Valor == 1)
                {
                    vMenor = n;
                }
                if (n%2 == 0)
                {
                    pares++;
                    
                }
                if (n % 2 != 0)
                {
                    impares++;

                }
                if (n > vMaior)
                {
                    vMaior = n;

                }
                if (n < vMenor)
                {
                    vMaior = n;

                }
                soma.Somar(n);
                cont.Contar();
            }
            double MediaA = soma.MediaAritmetica();
            WriteLine("Soma é: " + (soma.Soma) + " Média é " + MediaA + " A quantidade de impares é " + impares + " A quantidade de pares " + pares + " O maior valor "
                + vMaior + " E o menor " + vMenor);
        }
    }
}
