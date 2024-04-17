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
        public Nodo Raiz;
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
        public void Remover(int valor)
        {
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = Raiz;

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
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return false;
            }

            Nodo aux = Raiz;

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
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return 0;
            }

            Nodo aux = Raiz;
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

            if (Raiz == null)
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
            Nodo aux = Raiz;
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

            if (Raiz == null)
                Raiz = novo;

            novo.Proximo = Raiz;
            Raiz.Anterior = novo;
            Raiz = novo;
        }
        public void Inverter()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = Raiz;
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

            Raiz = anterior;
        }
        public void Concatenar(ListaDuplamenteEncadeada lista2)
        {
            if (Raiz == null)
            {
                Raiz = lista2.Raiz;
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
        public void RemoverDuplicatas()
        {
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            Nodo aux = Raiz;

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
            if (Raiz == null || lista82.Raiz == null)
            {
                Console.WriteLine("Uma das listas está vazia");
                return null;
            }

            Nodo aux = Raiz;
            ListaDuplamenteEncadeada intersecao = new();
            while (aux != null)
            {
                Nodo auxLista2 = lista82.Raiz;
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
            if (Raiz == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            bool houveAlteracao = true;

            while (houveAlteracao == true)
            {
                Nodo aux = Raiz;
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