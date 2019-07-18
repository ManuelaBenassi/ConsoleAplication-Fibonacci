using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public  class Contador
    {
        protected int cont, passo, valorFinal, valorInicial;

        public Contador(int inicio, int fim, int incremento)
        {
            passo = incremento;
            valorFinal = fim;
            valorInicial = inicio;
            cont = inicio;
        }
        public void Contar()
        {
            if(cont <= valorFinal)
            {
                cont += passo;
            }
        }
        public bool Prosseguir()
        {
            return cont <= valorFinal; // se contador não chegou ao valor final, retorna verdadeiro
        }
        public int Valor
        {
            get => cont;
        }
        public void Reiniciar()
        {
            cont = valorInicial;
        }

    }

