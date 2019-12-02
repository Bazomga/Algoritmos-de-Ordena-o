using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00173313_Ordenacao
{
    class Sort
    {
        private int[] vetor = new int[10];
        Random rnd = new Random();

        public Sort()
        {
            telaInicial();
        }

        private void telaInicial()
        {
            Console.Clear();
            Console.WriteLine("Digite o metodo de ordenação:");
            Console.WriteLine("1- Bubble\n2- Insert\n3- Select\n4- Quick\n5- Merge");
            int numCase = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            gerarNumeros();
            Console.WriteLine("Numeros não ordenados: ");
            imprimir();
            switch (numCase)
            {
                case 1:
                    bubbleSort();
                    break;
                case 2:
                    insertSort();
                    break;
                case 3:
                    selectSort();
                    break;
                case 4:
                    quickSort();
                    break;
                case 5:
                    mergeSort();
                    break;
            }
            Console.WriteLine("Numeros ordenados: ");
            imprimir();
        }

        private void gerarNumeros()
        {
            for (int i = 0; i < 10; i++){
                vetor[i] = rnd.Next(1, 20);
            }
        }

        private void imprimir()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        private void bubbleSort()
        {
            int temp = 0; //temp = bolha

            for (int write = 0; write < vetor.Length; write++)
            {
                for (int sort = 0; sort < vetor.Length - 1; sort++)
                {
                    if (vetor[sort] > vetor[sort + 1])
                    {
                        temp = vetor[sort + 1];
                        vetor[sort + 1] = vetor[sort];
                        vetor[sort] = temp;
                    }
                }
            }
        }

        private void insertSort()
        {
            int i, j, eleito;
            for (i = 1; i < vetor.Length; i++)
            {
                eleito = vetor[i]; //ele salva o primeiro para futra comparacao
                j = i; //salva a posicao do menor
                while ((j > 0) && (vetor[j - 1] > eleito)) //verifica se eh menor que o anterior
                {
                    vetor[j] = vetor[j - 1]; //vetor atual recebe o valor maior
                    j = j - 1; //salva posicao do vetor anterior (pos anterior)
                }
                vetor[j] = eleito; //vetor anterior recebe o numero menor
            }
        }

        private void selectSort()
        {
            int min, aux;
            for (int i = 0; i < vetor.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < vetor.Length; j++) 
                    if (vetor[j] < vetor[min]) //verifica se o numero atual é maior que o que esta sendo apontado no vetor
                        min = j; //é salvo onde ta o menor numero

                if (min != i) //verifica se houve troca
                {
                    aux = vetor[min]; //se sim, o auxiliar recebe o valor menor 
                    vetor[min] = vetor[i]; //onde estava o valor menor recebe o valor maior (pos do vetor)
                    vetor[i] = aux; //troca final, semelhante ao bubble
                }
            }
        }

        private void quickSort()
        {
            QuickClass.Iniciar(vetor);
        }

        private void mergeSort()
        {
            MergeClass.MergeSort_Recursive(vetor, 0, 9);
        }
    }
}
