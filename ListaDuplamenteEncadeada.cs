using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class ListaDuplamenteEncadeada
    {
        public Nodo Raiz { get; private set; }
        public void Inserir(int valor)
        {
            Nodo novoNodo = new(valor);

            if (Raiz == null)
            {
                Raiz = novoNodo;
                return;
            }

            Nodo aux = Raiz;

            while (aux.Proximo != null)
                aux = aux.Proximo;

            aux.Proximo = novoNodo;
            novoNodo.Anterior = aux;
        }
        public void Exibir()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = Raiz;
            while (aux != null)
            {
                if (aux.Proximo != null)
                    Console.Write(aux.Valor + "->");
                else
                    Console.Write(aux.Valor);

                aux = aux.Proximo;
            }
            Console.WriteLine();
        }
        public int ContarElementos()
        {
            if (Raiz == null) return 0;

            int tamanho = 1;

            Nodo aux = Raiz;
            while (aux.Proximo != null)
            {
                tamanho++;
                aux = aux.Proximo;
            }

            return tamanho;
        }
        public bool Buscar(int valor)
        {
            Nodo aux = Raiz;

            while (aux != null)
            {
                if (aux.Valor == valor)
                    return true;

                aux = aux.Proximo;
            }
            return false;
        }
        public void Concatenar(ListaDuplamenteEncadeada lista2)
        {
            if (Raiz == null)
            {
                Raiz = lista2.Raiz;
                return;
            }

            if(lista2.Raiz == null)
            {
                return;
            }

            Nodo aux = Raiz;

            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }

            aux.Proximo = lista2.Raiz;
            lista2.Raiz.Anterior = aux;
        }
        public ListaDuplamenteEncadeada[] Dividir()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return null;
            }
            ListaDuplamenteEncadeada[] listasResultantes = new ListaDuplamenteEncadeada[2];
            ListaDuplamenteEncadeada lResultante1 = new ListaDuplamenteEncadeada();
            ListaDuplamenteEncadeada lResultante2 = new ListaDuplamenteEncadeada();


            int totalElementos = ContarElementos();
            int tamanhoPrimeiroVetor = totalElementos / 2;

            Nodo aux = Raiz;

            for (int i = 0; i < totalElementos; i++)
            {
                if (i < tamanhoPrimeiroVetor)
                    lResultante1.Inserir(aux.Valor);
                else
                    lResultante2.Inserir(aux.Valor);

                aux = aux.Proximo;
            }

            listasResultantes[0] = lResultante1;
            listasResultantes[1] = lResultante2;

            return listasResultantes;
        }
        public Nodo EncontrarElementoDoMeio(ListaDuplamenteEncadeada lista)
        {
            Nodo rapido = lista.Raiz;
            Nodo lento = lista.Raiz;

            while (rapido != null && rapido.Proximo != null)
            {
                rapido = rapido.Proximo.Proximo;
                lento = lento.Proximo;
            }

            return lento;
        }
        public void InserirNoFim(int valor)
        {
            Nodo novoNodo = new Nodo(valor);

            if (Raiz == null)
            {
                Raiz = novoNodo;
                return;
            }

            Nodo atual = Raiz;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo;
            }

            atual.Proximo = novoNodo;
            novoNodo.Anterior = atual;
        }
        public ListaDuplamenteEncadeada Copiar()
        {
            ListaDuplamenteEncadeada novaLista = new ListaDuplamenteEncadeada();

            if (this.Raiz == null)
                return novaLista;

            Nodo atual = this.Raiz;

            while (atual != null)
            {
                novaLista.InserirNoFim(atual.Valor);
                atual = atual.Proximo;
            }

            return novaLista;
        }
    }
}