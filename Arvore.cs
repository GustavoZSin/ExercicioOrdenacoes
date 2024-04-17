using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Arvore
    {
        private Nodo _raiz;
        public int Comparacoes { get; private set; }
        public int Insercoes { get; private set; }
        public Arvore()
        {
            Comparacoes = 0;
            Insercoes = 0;
        }
        public void Inserir(int valor)
        {
            Nodo novoNodo = new(valor);

            if (_raiz == null)
            {
                _raiz = novoNodo;
                Insercoes++;
                return;
            }

            Inserir(novoNodo, _raiz);
        }
        private void Inserir(Nodo nodo, Nodo nodoReferencia)
        {
            Comparacoes++;

            if (nodo.Valor > nodoReferencia.Valor)
            {
                if (nodoReferencia.Proximo == null)
                {
                    nodoReferencia.Proximo = nodo;
                    Insercoes++;
                }
                else
                    Inserir(nodo, nodoReferencia.Proximo);
            }
            else
            {
                if (nodoReferencia.Anterior == null)
                {
                    nodoReferencia.Anterior = nodo;
                    Insercoes++;
                }
                else
                    Inserir(nodo, nodoReferencia.Anterior);
            }
        }
        public ListaDuplamenteEncadeada TravessiaEmOrdem()
        {
            ListaDuplamenteEncadeada resultado = new();

            if (_raiz == null)
            {
                Console.WriteLine("A árvore está vazia");
                Comparacoes++;
                return resultado;
            }

            return TravessiaEmOrdem(_raiz, resultado);
        }
        private ListaDuplamenteEncadeada TravessiaEmOrdem(Nodo nodo, ListaDuplamenteEncadeada lista)
        {
            if (nodo.Anterior != null)
            {
                Comparacoes++;
                TravessiaEmOrdem(nodo.Anterior, lista);
            }

            lista.Inserir(nodo.Valor);

            if (nodo.Proximo != null)
            {
                Comparacoes++;
                TravessiaEmOrdem(nodo.Proximo, lista);
            }

            return lista;
        }
    }
}