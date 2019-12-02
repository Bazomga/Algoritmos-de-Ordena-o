using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00173313_Ordenacao
{
    class QuickClass
    {
        public static void Iniciar(int[] vetor)
        {
            Ordenar(vetor, 0, vetor.Length - 1);
        }

        private static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int posicaoPivo = Separar(vetor, inicio, fim);
                Ordenar(vetor, inicio, posicaoPivo - 1);
                Ordenar(vetor, posicaoPivo + 1, fim);
            }
        }

        private static int Separar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f)
            {
                if (vetor[i] <= pivo)
                    i++;
                else if (pivo < vetor[f])
                    f--;
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
        }
    }
}
