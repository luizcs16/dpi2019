
using Aptm2019.BusinessLogicLayer;
using Aptm2019.EntityLayer;
using Aptm2019.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using PM.BusinessLogicLayer;
using PM.EntityLayer;
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
            /*
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

            */
            GenerarSimulado();

        }
        public static void GenerarExcel(int countSimulado, int cantPedidos, int cantCamiones) { 

            List<ENT_PEDIDO> lstPedidos = new BLL_PEDIDO().SelectAll777(cantPedidos);

            XSSFWorkbook oLibro = new XSSFWorkbook();
            XSSFCellStyle bStylehead = (XSSFCellStyle)oLibro.CreateCellStyle();
            bStylehead.BorderBottom = BorderStyle.Thin;
            bStylehead.BorderLeft = BorderStyle.Thin;
            bStylehead.BorderRight = BorderStyle.Thin;
            bStylehead.BorderTop = BorderStyle.Thin;
            bStylehead.Alignment = HorizontalAlignment.Left;
            bStylehead.VerticalAlignment = VerticalAlignment.Center;
            //bStylehead.FillBackgroundColor = HSSFColor.Black.Index;
            bStylehead.FillBackgroundXSSFColor = new XSSFColor(new byte[3] { 0, 0, 0 });
            //bStylehead.FillForegroundColor = HSSFColor.White.Index;
            bStylehead.FillForegroundXSSFColor = new XSSFColor(new byte[3] { 255, 255, 255 });

            XSSFCellStyle bStylehead1 = (XSSFCellStyle)oLibro.CreateCellStyle();
            bStylehead1.BorderBottom = BorderStyle.Thin;
            bStylehead1.BorderLeft = BorderStyle.Thin;
            bStylehead1.BorderRight = BorderStyle.Thin;
            bStylehead1.BorderTop = BorderStyle.Thin;
            bStylehead1.Alignment = HorizontalAlignment.Center;
            bStylehead1.VerticalAlignment = VerticalAlignment.Center;
            //bStylehead1.FillBackgroundColor = HSSFColor.Black.Index;
            bStylehead1.FillBackgroundXSSFColor = new XSSFColor(new byte[3] { 0, 0, 0 });
            //bStylehead1.FillForegroundColor = HSSFColor.White.Index;
            bStylehead1.FillForegroundXSSFColor = new XSSFColor(new byte[3] { 255, 255, 255 });

            ISheet oHoja1 = oLibro.CreateSheet("Pedidos(" + cantPedidos + ")");

            Random random = new Random();
            int i = 1;
            int count = 0;
            ICell tmpCell;
            IRow fila = oHoja1.CreateRow(i);
            tmpCell = fila.CreateCell(1);
            tmpCell.SetCellValue("TOTAL DE PEDIDOS: " + lstPedidos.Count);
            tmpCell.CellStyle = bStylehead;
            fila.CreateCell(2).CellStyle = bStylehead;
            fila.CreateCell(3).CellStyle = bStylehead;
            fila.CreateCell(4).CellStyle = bStylehead;
            fila.CreateCell(5).CellStyle = bStylehead;
            fila.CreateCell(6).CellStyle = bStylehead;
            fila.CreateCell(7).CellStyle = bStylehead;
            oHoja1.AddMergedRegion(new CellRangeAddress(i, i, 1, 8));
            fila = oHoja1.CreateRow(++i);
            tmpCell = fila.CreateCell(1);
            tmpCell.SetCellValue("N°");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(2);
            tmpCell.SetCellValue("CODIGO DE GUÍA");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(3);
            tmpCell.SetCellValue("CLIENTE");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(4);
            tmpCell.SetCellValue("DIRECCIÓN");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(5);
            tmpCell.SetCellValue("DISTRITO");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(6);
            tmpCell.SetCellValue("LATITUD");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(7);
            tmpCell.SetCellValue("LONGITUD");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(8);
            tmpCell.SetCellValue("VOLUMEN");
            tmpCell.CellStyle = bStylehead1;
            foreach (ENT_PEDIDO p in lstPedidos)
            {
                fila = oHoja1.CreateRow(++i);
                tmpCell = fila.CreateCell(1);
                tmpCell.SetCellValue(++count);
                tmpCell.CellStyle = bStylehead1;
                tmpCell = fila.CreateCell(2);
                tmpCell.SetCellValue(p.GUIA.ToString());
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(3);
                tmpCell.SetCellValue(p.SERDETC_APELLIDOS);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(4);
                tmpCell.SetCellValue(p.SERDETC_DIRECCION);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(5);
                tmpCell.SetCellValue(p.SERDETC_DISTRITO);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(6);
                tmpCell.SetCellValue(p.SERDETN_LATITUD);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(7);
                tmpCell.SetCellValue(p.SERDETN_LONGITUD);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(8);
                tmpCell.SetCellValue(random.Next(10, 100) + 1);
                tmpCell.CellStyle = bStylehead;
            }
            for (i = 0; i < 9; i++)
            {
                oHoja1.AutoSizeColumn(i);
            }
            i = 1;
            count = 0;
            List<ENT_CAMION> lstCamiones = new BLL_CAMION().SelectAll777(cantCamiones);
            ISheet oHoja2 = oLibro.CreateSheet("Camiones("+cantCamiones+")");

            fila = oHoja2.CreateRow(i);
            tmpCell = fila.CreateCell(1);
            tmpCell.SetCellValue("CAMIONES DISPONIBLES: " + lstCamiones.Count);
            tmpCell.CellStyle = bStylehead;
            fila.CreateCell(2).CellStyle = bStylehead;
            fila.CreateCell(3).CellStyle = bStylehead;
            oHoja2.AddMergedRegion(new CellRangeAddress(i, i, 1, 4));
            fila = oHoja2.CreateRow(++i);
            tmpCell = fila.CreateCell(1);
            tmpCell.SetCellValue("N°");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(2);
            tmpCell.SetCellValue("PLACA");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(3);
            tmpCell.SetCellValue("CHOFER");
            tmpCell.CellStyle = bStylehead1;
            tmpCell = fila.CreateCell(4);
            tmpCell.SetCellValue("VOLUMEN MAXIMO");
            tmpCell.CellStyle = bStylehead1;
            foreach (ENT_CAMION c in lstCamiones)
            {
                fila = oHoja2.CreateRow(++i);
                tmpCell = fila.CreateCell(1);
                tmpCell.SetCellValue(++count);
                tmpCell.CellStyle = bStylehead1;
                tmpCell = fila.CreateCell(2);
                tmpCell.SetCellValue(c.VEHC_PLACA);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(3);
                tmpCell.SetCellValue(c.CONC_NOMBRES + " " + c.CONC_APELLIDOS);
                tmpCell.CellStyle = bStylehead;
                tmpCell = fila.CreateCell(4);
                int r1 = ((random.Next(1, 9) + 1) * 10);
                int r2 = ((random.Next(3, 7) + 1) * 100);

                tmpCell.SetCellValue(r1+r2);
                tmpCell.CellStyle = bStylehead;
            }

            for (i = 0; i < 5; i++)
            {
                oHoja2.AutoSizeColumn(i);
            }

            using (FileStream fs = new FileStream(@"D:\Desarrollo\Situación_"+ countSimulado + ".xlsx", FileMode.OpenOrCreate, FileAccess.Write))
            {
                oLibro.Write(fs);
                oLibro.Close();
                //fs.Flush();
                fs.Close();
            }
        }

        
        public static void GenerarSimulado()
        {
            Random random = new Random();
            for (int i = 1; i <= 500; i++)
            {
                int r1 = ((random.Next(3, 7) + 1) * 10);
                int r2 = ((random.Next(3, 7) + 1) * 100);
                int r3 = (random.Next(70, 700) + 1);
                GenerarExcel(i, r3, r1 + r2);
                Console.WriteLine("Situación "+i+" completado!");
            }
        }

    }
}
