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
        private Nodo _raiz;
        public void Inserir(int valor)
        {
            Nodo novoNodo = new(valor);

            if (_raiz == null)
            {
                _raiz = novoNodo;
                return;
            }

            Nodo aux = _raiz;

            while (aux.Proximo != null)
                aux = aux.Proximo;

            aux.Proximo = novoNodo;
            novoNodo.Anterior = aux;
        }
        public void Remover(int valor)
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = _raiz;

            while (aux.Proximo != null)
            {
                if (aux.Valor == valor)
                {
                    aux.Anterior.Proximo = aux.Proximo;
                    aux.Proximo.Anterior = aux.Anterior;
                    return;
                }

                aux = aux.Proximo;
            }

            Console.WriteLine("Valor não encontrado na lista");
        }
        public void Exibir()
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = _raiz;
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
            if (_raiz == null) return 0;

            int tamanho = 1;

            Nodo aux = _raiz;
            while (aux.Proximo != null)
            {
                tamanho++;
                aux = aux.Proximo;
            }

            return tamanho;
        }
        public bool Buscar(int valor)
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return false;
            }

            Nodo aux = _raiz;

            while (aux.Proximo != null)
            {
                if (aux.Valor == valor)
                    return true;

                aux = aux.Proximo;
            }
            return false;
        }
        public int BuscaValorNoIndice(int posicao)
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return 0;
            }

            Nodo aux = _raiz;
            int indice = 0;

            while (aux != null && indice < posicao)
            {
                aux = aux.Proximo;
                indice++;
            }

            if (aux == null)
            {
                Console.WriteLine("Posição maior que a lista");
                return 0;
            }

            return aux.Valor;
        }
        public void InserirNoIndice(int posicao, int valor)
        {
            if (posicao < 0)
            {
                Console.WriteLine("A posição deve ser um valor positivo ou zero.");
                return;
            }

            if (_raiz == null)
            {
                // Se a lista estiver vazia e a posição for 0, insere como raiz
                if (posicao == 0)
                {
                    this.Inserir(valor);
                    return;
                }
                else
                {
                    Console.WriteLine("Posição maior que a lista.");
                    return;
                }
            }

            Nodo novoNodo = new Nodo(valor);
            Nodo aux = _raiz;
            int indice = 0;

            while (aux != null && indice < posicao - 1)
            {
                aux = aux.Proximo;
                indice++;
            }

            if (aux == null)
            {
                Console.WriteLine("Posição maior que a lista.");
                return;
            }

            // Inserção no início da lista
            if (posicao == 0)
                this.InserirNoInicio(novoNodo.Valor);
            else
            {
                novoNodo.Proximo = aux.Proximo;
                novoNodo.Anterior = aux;
                aux.Proximo = novoNodo;

                // Atualiza o anterior do próximo nó, se existir
                if (novoNodo.Proximo != null)
                {
                    novoNodo.Proximo.Anterior = novoNodo;
                }
            }
        }
        public void InserirNoInicio(int valor)
        {
            Nodo novo = new(valor);

            if (_raiz == null)
                _raiz = novo;

            novo.Proximo = _raiz;
            _raiz.Anterior = novo;
            _raiz = novo;
        }
        public void Inverter()
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = _raiz;
            Nodo anterior = null;
            Nodo proximo = null;

            while (aux != null)
            {
                proximo = aux.Proximo;
                aux.Proximo = anterior;
                aux.Anterior = proximo;
                anterior = aux;
                aux = proximo;
            }

            _raiz = anterior;
        }
        public void Concatenar(ListaDuplamenteEncadeada lista2)
        {
            if (_raiz == null)
            {
                _raiz = lista2._raiz;
                return;
            }

            Nodo aux = _raiz;

            while (aux.Proximo != null)
            {
                aux = aux.Proximo;
            }

            aux.Proximo = lista2._raiz;
            lista2._raiz.Anterior = aux;
        }
        public void RemoverDuplicatas()
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = _raiz;

            while (aux != null)
            {
                Nodo auxSecundario = aux.Proximo;

                while (auxSecundario != null)
                {
                    if (aux.Valor == auxSecundario.Valor)
                    {
                        auxSecundario.Proximo.Anterior = auxSecundario.Anterior;
                        auxSecundario.Anterior.Proximo = auxSecundario.Proximo;
                    }
                    auxSecundario = auxSecundario.Proximo;
                }

                aux = aux.Proximo;
            }
        }
        public ListaDuplamenteEncadeada Intersecao(ListaDuplamenteEncadeada lista82)
        {
            if (_raiz == null || lista82._raiz == null)
            {
                Console.WriteLine("Uma das listas está vazia");
                return null;
            }

            Nodo aux = _raiz;
            ListaDuplamenteEncadeada intersecao = new();
            while (aux != null)
            {
                Nodo auxLista2 = lista82._raiz;
                while (auxLista2 != null)
                {
                    if (aux.Valor == auxLista2.Valor)
                    {
                        intersecao.Inserir(aux.Valor);
                    }

                    auxLista2 = auxLista2.Proximo;
                }

                aux = aux.Proximo;
            }

            return intersecao;
        }
        public void Ordenar()
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            bool houveAlteracao = true;

            while (houveAlteracao == true)
            {
                Nodo aux = _raiz;
                houveAlteracao = false;
                while (aux.Proximo != null)
                {
                    if (aux.Valor > aux.Proximo.Valor)
                    {
                        int temp = aux.Valor;
                        aux.Valor = aux.Proximo.Valor;
                        aux.Proximo.Valor = temp;
                        houveAlteracao = true;
                    }

                    aux = aux.Proximo;
                }
            }
        }
        public ListaDuplamenteEncadeada[] Dividir()
        {
            if (_raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return null;
            }
            ListaDuplamenteEncadeada[] listasResultantes = new ListaDuplamenteEncadeada[2];
            ListaDuplamenteEncadeada lResultante1 = new ListaDuplamenteEncadeada();
            ListaDuplamenteEncadeada lResultante2 = new ListaDuplamenteEncadeada();


            int totalElementos = ContarElementos();
            int tamanhoPrimeiroVetor = totalElementos / 2;

            Nodo aux = _raiz;

            for (int i = 0; i < totalElementos; i++)
            {
                if (i < tamanhoPrimeiroVetor)
                    lResultante1.Inserir(aux.Valor);
                else
                {
                    
                    lResultante2.Inserir(aux.Valor);
                }

                aux = aux.Proximo;
            }

            listasResultantes[0] = lResultante1;
            listasResultantes[1] = lResultante2;

            return listasResultantes;
        }
    }
}