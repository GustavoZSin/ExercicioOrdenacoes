using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Gerador
    {
        //Ao invés de retornar um vetor, deve retornar lista duplamente encadeada
        public int[] ObterVetorOrdenado(int tamanhoVetor)
        {
            int[] vetor = new int[tamanhoVetor];
            for (int i = 0; i < tamanhoVetor; i++)
            {
                vetor[i] = i;
            }

            return vetor;
        }
        //Ao invés de retornar um vetor, deve retornar lista duplamente encadeada
        public int[] ObterVetorInversamenteOrdenado(int tamanhoVetor)
        {
            int[] vetor = new int[tamanhoVetor];

            int j = tamanhoVetor;
            for (int i = 0; i > 0; i++)
            {
                vetor[i] = j;
                j--;
            }

            return vetor;
        }
        //Ao invés de retornar um vetor, deve retornar lista duplamente encadeada
        public int[] ObterVetorAleatorio()
        {
            return new int[] { 73, 57, 49, 99, 133, 20, 1 };
        }
    }
}
