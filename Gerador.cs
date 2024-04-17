using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Gerador
    {
        public ListaDuplamenteEncadeada GerarListaOrdenada()
        {
            ListaDuplamenteEncadeada listaOrdenada = new();
            listaOrdenada.Inserir(0);
            listaOrdenada.Inserir(1);
            listaOrdenada.Inserir(2);
            listaOrdenada.Inserir(3);
            listaOrdenada.Inserir(4);
            listaOrdenada.Inserir(5);
            listaOrdenada.Inserir(6);
            listaOrdenada.Inserir(7);
            listaOrdenada.Inserir(8);
            listaOrdenada.Inserir(9);

            return listaOrdenada;
        }
        public ListaDuplamenteEncadeada GerarListaDesordenada()
        {
            ListaDuplamenteEncadeada listaDesordenada = new();
            listaDesordenada.Inserir(9);
            listaDesordenada.Inserir(1);
            listaDesordenada.Inserir(5);
            listaDesordenada.Inserir(3);
            listaDesordenada.Inserir(0);
            listaDesordenada.Inserir(4);
            listaDesordenada.Inserir(8);
            listaDesordenada.Inserir(6);
            listaDesordenada.Inserir(7);
            listaDesordenada.Inserir(2);

            return listaDesordenada;
        }
        public ListaDuplamenteEncadeada GerarListaInversamenteOrdenada()
        {
            ListaDuplamenteEncadeada listaInversamenteOrdenada = new();
            listaInversamenteOrdenada.Inserir(9);
            listaInversamenteOrdenada.Inserir(8);
            listaInversamenteOrdenada.Inserir(7);
            listaInversamenteOrdenada.Inserir(6);
            listaInversamenteOrdenada.Inserir(5);
            listaInversamenteOrdenada.Inserir(4);
            listaInversamenteOrdenada.Inserir(3);
            listaInversamenteOrdenada.Inserir(2);
            listaInversamenteOrdenada.Inserir(1);
            listaInversamenteOrdenada.Inserir(0);

            return listaInversamenteOrdenada;
        }
    }
}
