﻿using System;
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
            Trocas = 0;
            Comparacoes = 0;

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
        public static ListaDuplamenteEncadeada InsertionSort(ListaDuplamenteEncadeada lista)
        {
            Trocas = 0;
            Comparacoes = 0;

            if (lista.Raiz == null || lista.Raiz.Proximo == null)
                return lista;

            Nodo atual = lista.Raiz.Proximo;

            while (atual != null)
            {
                Nodo anterior = atual.Anterior;
                Nodo atualComparacao = anterior;

                Comparacoes++;
                while (atualComparacao != null && atual.Valor < atualComparacao.Valor)
                {
                    TrocaNodos(atual, atualComparacao);

                    atual = atual.Anterior;
                    atualComparacao = atualComparacao.Anterior;
                }

                atual = atual.Proximo;
            }

            return lista;
        }
        #endregion

        #region Merge Sort
        public static ListaDuplamenteEncadeada MergeSort(ListaDuplamenteEncadeada lista)
        {
            Trocas = 0;
            Comparacoes = 0;

            return MergeSorteRecursivo(lista);
        }
        public static ListaDuplamenteEncadeada MergeSorteRecursivo(ListaDuplamenteEncadeada lista)
        {
            if (lista == null || lista.Raiz == null || lista.Raiz.Proximo == null)
                return lista;

            ListaDuplamenteEncadeada[] listasDivididas = lista.Dividir();
            ListaDuplamenteEncadeada listaEsquerda = listasDivididas[0];
            ListaDuplamenteEncadeada listaDireita = listasDivididas[1];

            listaEsquerda = MergeSorteRecursivo(listaEsquerda);
            listaDireita = MergeSorteRecursivo(listaDireita);

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
            Trocas = 0;
            Comparacoes = 0;

            return Quick(listaOrdenada);
        }
        public static ListaDuplamenteEncadeada Quick(ListaDuplamenteEncadeada listaOrdenada)
        {

            if (listaOrdenada.Raiz == null || listaOrdenada.Raiz.Proximo == null)
                return listaOrdenada;

            Nodo pivo = listaOrdenada.EncontrarElementoDoMeio(listaOrdenada);

            ListaDuplamenteEncadeada menores = new ListaDuplamenteEncadeada();
            ListaDuplamenteEncadeada maiores = new ListaDuplamenteEncadeada();

            for (Nodo atual = listaOrdenada.Raiz; atual != null; atual = atual.Proximo)
            {
                Comparacoes++;

                if (atual == pivo)
                    continue;

                if (atual.Valor < pivo.Valor)
                {
                    menores.Inserir(atual.Valor);
                    Trocas++;
                }
                else
                {
                    maiores.Inserir(atual.Valor);
                    Trocas++;
                }
            }

            menores = Quick(menores);
            maiores = Quick(maiores);

            menores.InserirNoFim(pivo.Valor);
            Trocas++;

            if (maiores != null)
            {
                menores.Concatenar(maiores);
                Trocas++;
            }

            return menores;
        }

        #endregion

        #region TreeSort
        public static ListaDuplamenteEncadeada TreeSort(ListaDuplamenteEncadeada listaOrdenada)
        {
            Trocas = 0;
            Comparacoes = 0;

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