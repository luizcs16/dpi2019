using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.Util
{
    public class AStar
    {
        List<Nodo> Nodos { get; set; }
        List<Nodo> NodosAbiertos { get; set; }
        List<Nodo> NodosCerrados { get; set; }
        
        public AStar(List<Nodo> Nodos)
        {
            this.Nodos = Nodos;
            NodosAbiertos = new List<Nodo>();
            NodosCerrados = new List<Nodo>();
        }

    }
}
