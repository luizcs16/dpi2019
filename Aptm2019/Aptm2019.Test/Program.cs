using Aptm2019.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aptm2019.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> oCarga = new List<dynamic> {

                new {cCliente="FFFFF",nLat=-12.029341,nLong=-77.017403,cDireccion="Institución educativa inicial Los Angeles Del Saber, Avenida Perú, San Juan de Lurigancho, Lima, 15025, Perú",nDuracion=2015.5,nDistancia=19296.1},
                new {cCliente="FFFFF",nLat=-12.056705,nLong=-77.125822,cDireccion="156, Avenida Miguel Grau, Bellavista, Callao, 07001, Perú",nDuracion=2390.6,nDistancia=19212.6},
                new {cCliente="FFFFF",nLat=-11.927304,nLong=-77.077526,cDireccion="Estructuras Metalicas Charlie, Avenida Malecón Chillón, Puente Piedra, Lima, 15314, Perú",nDuracion=553,nDistancia=2979.2},
                //new {cCliente="FFFFF",nLat=-11.939207,nLong=-77.062303,cDireccion="Institución Educativa Oscar Freitas Minaya, Francisco de Paula Quiroz, El Retablo, Comas, Lima, 15314, Perú",nDuracion=632.6,nDistancia=3256},
                //new {cCliente="FFFFF",nLat=-11.955382,nLong=-77.07284,cDireccion="Avenida San Hernán, Los Olivos, Lima, 0031, Perú",nDuracion=2462.5,nDistancia=18500.8},
                //new {cCliente="FFFFF",nLat=-12.097433,nLong=-77.027017,cDireccion="Corporación Financiera de Desarrollo - COFIDE, 160, Calle Augusto Tamayo, Centro financiero de San Isidro, San Isidro, Lima, 15073, Perú",nDuracion=2215.9,nDistancia=21171.5},
                //new {cCliente="FFFFF",nLat=-12.049225,nLong=-77.111985,cDireccion="Puerto 2, Avenida Principal, Minka, Callao, 07011, Perú",nDuracion=1868.3,nDistancia=12025.9},
                //new {cCliente="FFFFF",nLat=-11.992988,nLong=-77.058063,cDireccion="Jirón Bartolome Ferreyros, El Naranjal, Independencia, Lima, LIMA 28, Perú",nDuracion=1999.9,nDistancia=13047.5},
                //new {cCliente="FFFFF",nLat=-12.065228,nLong=-77.094705,cDireccion="Estocolmo, Virgen de Fatima, San Miguel, Lima, LIMA 32, Perú",nDuracion=1637.8,nDistancia=10875.9},
                //new {cCliente="FFFFF",nLat=-12.010879,nLong=-77.053466,cDireccion="Avenida Fray Bartolome de las Casas, Miguel Grau, San Martín de Porres, Lima, 15028, Perú",nDuracion=1587,nDistancia=12623.1},
                //new {cCliente="FFFFF",nLat=-11.981396,nLong=-77.121576,cDireccion="Avenida Central, Oquendo, Callao, 15109, Perú",nDuracion=2471,nDistancia=17486.8},
                //new {cCliente="FFFFF",nLat=-12.070925,nLong=-77.052853,cDireccion="Mega Botikas, Avenida General Borgoño, Pueblo Libre, Lima, 011, Perú",nDuracion=1477,nDistancia=8017.9},
                //new {cCliente="FFFFF",nLat=-12.026232,nLong=-77.029533,cDireccion="Jirón Real Audiencia, Unidad Vecinal del Rimac, Rimac, Rímac, Lima, 15025, Perú",nDuracion=493.8,nDistancia=2405.9},
                //new {cCliente="FFFFF",nLat=-12.018922,nLong=-77.043307,cDireccion="Rimac, Rímac, Lima, LIMA 25, Perú",nDuracion=1505,nDistancia=11280.6},
                //new {cCliente="FFFFF",nLat=-11.978405,nLong=-77.080302,cDireccion="1320, Avenida Canta Callao, Los Jazmines del Naranjal, Los Olivos, Lima, L31, Perú",nDuracion=1480.3,nDistancia=12420.6},
                //new {cCliente="FFFFF",nLat=-12.043148,nLong=-77.114871,cDireccion="Calle Hondas, Urbanización Santa Marina, Callao, 07011, Perú",nDuracion=1705.9,nDistancia=12748.7},
                //new {cCliente="FFFFF",nLat=-11.956679,nLong=-77.105036,cDireccion="San Martín de Porres, Lima, 0031, Perú",nDuracion=1189,nDistancia=6491.3},
                //new {cCliente="FFFFF",nLat=-11.982647,nLong=-77.062701,cDireccion="El Naranjal, Independencia, Lima, LIMA 28, Perú",nDuracion=1325.7,nDistancia=9352.9},
                //new {cCliente="FFFFF",nLat=-11.929497,nLong=-77.10018,cDireccion="Calle Mariscal Caceres, La Ensenada, Puente Piedra, Lima, 0031, Perú",nDuracion=2022.6,nDistancia=14566.2},
                //new {cCliente="FFFFF",nLat=-12.019848,nLong=-77.104129,cDireccion="Calle central, Ciudad Satélite Santa Rosa, Callao, 07036, Perú",nDuracion=2396.2,nDistancia=28412.8},
                //new {cCliente="FFFFF",nLat=-12.094875,nLong=-77.013071,cDireccion="Centro Medico Neo Medic, Avenida José Galvez Barrenechea, Corpac, San Isidro, Lima, 13, Perú",nDuracion=1203.6,nDistancia=12730.7},
                //new {cCliente="FFFFF",nLat=-12.028356,nLong=-77.000963,cDireccion="Avenida José Carlos Mariátegui, Parques del Agustino, El Agustino, Lima, 15401, Perú",nDuracion=766.4,nDistancia=10096.3},
                //new {cCliente="FFFFF",nLat=-12.087474,nLong=-76.9994,cDireccion="Avenida Javier Prado Este, San Borja, Lima, 15033, Perú",nDuracion=2304.7,nDistancia=28532.3},
                //new {cCliente="FFFFF",nLat=-11.99789,nLong=-77.116801,cDireccion="Calle Tumbes, Las Fresas, Callao, 15109, Perú",nDuracion=2464.5,nDistancia=22737.5},
                //new {cCliente="FFFFF",nLat=-12.039139,nLong=-76.970564,cDireccion="Jhony's, Los Quechuas, Santa Anita, Lima, LIMA 43, Perú",nDuracion=962.1,nDistancia=5093.5},
                //new {cCliente="FFFFF",nLat=-12.059579,nLong=-76.971895,cDireccion="SAS 11175, ATE, Frnt. 220, Calle Santa Ines, Ate, Lima, 15002, Perú",nDuracion=684.2,nDistancia=4498.2},
                //new {cCliente="FFFFF",nLat=-12.074096,nLong=-76.984525,cDireccion="Sullana, Salamanca de Monterrico, Ate, Lima, LIMA03, Perú",nDuracion=7777777,nDistancia=3333333}
            };

            List<Nodo> lstNodo = oCarga.Select(n=>new Nodo{
                nLong = n.nLong,
                nLat = n.nLat,
            }).ToList();

            
            
            Ruta.ForeachRecursivo(lstNodo);

            foreach (Nodo n in lstNodo)
            {
                Console.WriteLine(n + "->");
            }
            Console.WriteLine();


            Console.ReadKey();

        }

        
    }
}
