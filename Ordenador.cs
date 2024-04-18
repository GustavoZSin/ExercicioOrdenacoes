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

        #region Bubble Sort
        public static ListaDuplamenteEncadeada BubbleSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            if (listaOrdenada == null || listaOrdenada.Raiz == null)
                return listaOrdenada;

            bool trocado;
            do
            {
                trocado = false;
                Nodo atual = listaOrdenada.Raiz;

                while (atual.Proximo != null)
                {
                    Comparacoes++;
                    if (atual.Valor > atual.Proximo.Valor)
                    {
                        TrocaNodos(atual, atual.Proximo);
                        trocado = true;
                    }

                    atual = atual.Proximo;
                }
            } while (trocado);

            return listaOrdenada;
        }
        #endregion

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
        #endregion

        #region Insertion Sort
        public static ListaDuplamenteEncadeada InsertionSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Merge Sort
        public static ListaDuplamenteEncadeada MergeSort(ListaDuplamenteEncadeada lista)
        {
            if (lista == null || lista.Raiz == null || lista.Raiz.Proximo == null)
                return lista;

            ListaDuplamenteEncadeada[] listasDivididas = lista.Dividir();
            ListaDuplamenteEncadeada listaEsquerda = listasDivididas[0];
            ListaDuplamenteEncadeada listaDireita = listasDivididas[1];

            listaEsquerda = MergeSort(listaEsquerda);
            listaDireita = MergeSort(listaDireita);

            return Merge(listaEsquerda, listaDireita);
        }
        private static ListaDuplamenteEncadeada Merge(ListaDuplamenteEncadeada listaEsquerda, ListaDuplamenteEncadeada listaDireita)
        {
            ListaDuplamenteEncadeada listaOrdenada = new ListaDuplamenteEncadeada();
            Nodo atualEsquerda = listaEsquerda.Raiz;
            Nodo atualDireita = listaDireita.Raiz;

            while (atualEsquerda != null && atualDireita != null)
            {
                Comparacoes++;
                if (atualEsquerda.Valor < atualDireita.Valor)
                {
                    listaOrdenada.Inserir(atualEsquerda.Valor);
                    Trocas++;
                    atualEsquerda = atualEsquerda.Proximo;
                }
                else
                {
                    listaOrdenada.Inserir(atualDireita.Valor);
                    Trocas++;
                    atualDireita = atualDireita.Proximo;
                }
            }

            while (atualEsquerda != null)
            {
                listaOrdenada.Inserir(atualEsquerda.Valor);
                Trocas++;
                atualEsquerda = atualEsquerda.Proximo;
            }

            while (atualDireita != null)
            {
                listaOrdenada.Inserir(atualDireita.Valor);
                Trocas++;
                atualDireita = atualDireita.Proximo;
            }

            return listaOrdenada;
        }
        #endregion

        #region Quick Sort
        public static ListaDuplamenteEncadeada QuickSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region TreeSort
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
        #endregion

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