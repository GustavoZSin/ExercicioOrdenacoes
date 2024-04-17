using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Ordenador
    {
        public static int Trocas { get; private set; }
        public static int Comparacoes { get; private set; }

        internal static ListaDuplamenteEncadeada BubbleSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }

        #region Selection Sort
        public static ListaDuplamenteEncadeada SelectionSort(ListaDuplamenteEncadeada listaOriginal)
        {
            Trocas = 0;
            Comparacoes = 0;

            Nodo aux = listaOriginal.Raiz;

            while (aux != null)
            {
                Nodo menorNodo = BuscaMenorNodo(aux);
                TrocaNodos(aux, menorNodo);
                aux = aux.Proximo;
            }

            return listaOriginal;
        }
        private static Nodo BuscaMenorNodo(Nodo nodoInicial)
        {
            Nodo menorNodo = nodoInicial;
            Nodo aux = nodoInicial.Proximo;

            while (aux != null)
            {
                Comparacoes++;
                if (aux.Valor < menorNodo.Valor)
                {
                    menorNodo = aux;
                }
                aux = aux.Proximo;

            }

            return menorNodo;
        }
        private static void TrocaNodos(Nodo nodo1, Nodo nodo2)
        {
            if (nodo1 != nodo2)
            {
                Trocas++;
                int aux = nodo1.Valor;
                nodo1.Valor = nodo2.Valor;
                nodo2.Valor = aux;
            }
        }
        #endregion

        public static ListaDuplamenteEncadeada InsertionSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }
        public static ListaDuplamenteEncadeada MergeSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }
        public static ListaDuplamenteEncadeada QuickSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }
        public static ListaDuplamenteEncadeada TreeSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            Arvore arvore = new Arvore();
            Nodo aux = listaOrdenada.Raiz;

            while (aux != null)
            {
                arvore.Inserir(aux.Valor);
                aux = aux.Proximo;
            }

            listaOrdenada = arvore.TravessiaEmOrdem();

            Trocas = arvore.Insercoes;
            Comparacoes = arvore.Comparacoes;

            return listaOrdenada;
        }
        public static void Exibir(string mensagem, ListaDuplamenteEncadeada listaOrdenada, string titulo = null)
        {
            if (titulo != null)
                Console.WriteLine(titulo);

            Console.WriteLine(" - " + mensagem);
            Console.Write("Resultado:        ");
            listaOrdenada.Exibir();
            Console.WriteLine($"Inserções/Trocas: {Trocas}");
            Console.WriteLine($"Comparações:      {Comparacoes}");
            Console.WriteLine("---------------------------\n");
        }
    }
}
