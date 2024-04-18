using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Gerador
    {
        private int _tamanho;
        public Gerador(int tamanho)
        {
            _tamanho = tamanho;
        }
        public ListaDuplamenteEncadeada GerarListaDesordenada()
        {
            ListaDuplamenteEncadeada listaDesordenada = new();

            Random rand = new Random();

            for (int i = 0; i < _tamanho; i++)
            {
                int valor = rand.Next(1, _tamanho);

                while (listaDesordenada.Buscar(valor))
                {
                    valor = rand.Next(0, _tamanho);
                };

                listaDesordenada.Inserir(valor);
            }

            Console.Write("Lista Desordenada Original:           ");
            listaDesordenada.Exibir();

            return listaDesordenada;
        }
        public ListaDuplamenteEncadeada GerarListaOrdenada()
        {
            ListaDuplamenteEncadeada listaOrdenada = new();

            for (int i = 0; i < _tamanho; i++)
            {
                listaOrdenada.Inserir(i);
            }

            Console.Write("Lista Ordenada Original:              ");
            listaOrdenada.Exibir();

            return listaOrdenada;
        }
        public ListaDuplamenteEncadeada GerarListaInversamenteOrdenada()
        {
            ListaDuplamenteEncadeada listaInversamenteOrdenada = new();
            for (int i = _tamanho - 1; i >= 0; i--)
            {
                listaInversamenteOrdenada.Inserir(i);
            }

            Console.Write("Lista Inversamente Ordenada Original: ");
            listaInversamenteOrdenada.Exibir();

            return listaInversamenteOrdenada;
        }
    }
}
