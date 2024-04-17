using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Ordenador
    {
        internal static ListaDuplamenteEncadeada BubbleSort(ListaDuplamenteEncadeada listaOrdenada, out int insercoes, out int comparacoes)
        {
            throw new NotImplementedException();
        }
        public static ListaDuplamenteEncadeada SelectionSort(ListaDuplamenteEncadeada listaOriginal, out int insercoes, out int comparacoes)
        {
            insercoes = 0;
            comparacoes = 0;

            ListaDuplamenteEncadeada listaOrdenada = listaOriginal;

            var tamanhoLista = listaOrdenada.ContarElementos();

            for (int i = 0; i < tamanhoLista - 1; i++)
            {
                var menorValor = i;
                for (int j = i + 1; j < tamanhoLista; j++)
                {
                    comparacoes++;
                    if (listaOrdenada.BuscaValorNoIndice(j) < listaOrdenada.BuscaValorNoIndice(menorValor))
                    {
                        menorValor = j;
                    }
                }
                var tempVar = listaOrdenada.BuscaValorNoIndice(menorValor);
                listaOrdenada.InserirNoIndice(menorValor, listaOrdenada.BuscaValorNoIndice(i));
                insercoes++;
                listaOrdenada.InserirNoIndice(i, tempVar);
                insercoes++;
            }

            return listaOrdenada;
        }
        internal static ListaDuplamenteEncadeada InsertionSort(ListaDuplamenteEncadeada listaOrdenada, out int insercoes, out int comparacoes)
        {
            throw new NotImplementedException();
        }
        internal static ListaDuplamenteEncadeada MergeSort(ListaDuplamenteEncadeada listaOrdenada, out int insercoes, out int comparacoes)
        {
            throw new NotImplementedException();
        }
        internal static ListaDuplamenteEncadeada QuickSort(ListaDuplamenteEncadeada listaOrdenada, out int insercoes, out int comparacoes)
        {
            throw new NotImplementedException();
        }
        internal static ListaDuplamenteEncadeada TreeSort(ListaDuplamenteEncadeada listaOrdenada, out int insercoes, out int comparacoes)
        {
            throw new NotImplementedException();
        }
    }
}
