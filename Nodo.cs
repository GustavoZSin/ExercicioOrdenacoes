using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOrdenacao
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Proximo { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo(int valor)
        {
            Valor = valor;
        }
    }
}
