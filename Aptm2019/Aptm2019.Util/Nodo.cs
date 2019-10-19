using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.Util
{
    public class Nodo
    {
        //public float nDuracion { get; set; }
        //public float nDistancia { get; set; }
        public string cGeometry { get; set; }
        public float nCosto { get; set; }
        public double nLat { get; set; }
        public double nLong { get; set; }
        //public double F { get; set; }
        //public double G { get; set; }
        //public double H { get; set; }
        //public bool Cerrado { get; set; } = false;
        override public string ToString()
        {
            return "[" + nLat + "," + nLong + "," + cGeometry + "]";
        }
    }
}
