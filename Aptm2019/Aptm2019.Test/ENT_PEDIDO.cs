using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.EntityLayer
{
    public partial class ENT_PEDIDO
    {
        public string SERDETC_DIRECCION { get; set; }
        public string SERDETC_DISTRITO { get; set; }
        public string SERDETC_APELLIDOS { get; set; }
        public double SERDETN_LATITUD { get; set; }
        public double SERDETN_LONGITUD { get; set; }
        public Guid GUIA { get; set; }
        public double VOLUMEN { get; set; }
    }
}
