using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aptm2019.Util
{
    public class Ruta
    {
        
        public List<Arista> historialRutas { get; set; }

        public Ruta(List<Arista> historialRutas)
        {
            this.historialRutas = historialRutas;
        }
        public string f(double value)
        {
            return value.ToString().Replace(",",".");
        }
        public void GetNDirection(Nodo n1, Nodo n2,bool costo = true)
        {
            if (historialRutas == null)
                historialRutas = new List<Arista>();

            Arista arista = historialRutas.Find(a => a.Inicio.nLat == n1.nLat && a.Inicio.nLong == n1.nLong && a.Fin.nLat == n2.nLat && a.Fin.nLong == n2.nLong);

            if (arista != null) {
                n2 = arista.Fin;
                return;
            }
            else { 
                string html = string.Empty;

                string url = @"https://router.project-osrm.org/route/v1/driving/" + f(n1.nLong) + "," + f(n1.nLat) + ";" + f(n2.nLong) + "," + f(n2.nLat);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                JObject va = JsonConvert.DeserializeObject<JObject>(html);

                JArray routes = va.Value<dynamic>("routes");
                JObject va2 = routes.Children<JObject>().ToList()[0];
                if (costo)
                {
                    float va3 = va2.Value<dynamic>("duration");
                    n2.nCosto = va3;
                }
                string va4 = va2.Value<dynamic>("geometry");
                n2.cGeometry = va4;

                historialRutas.Add(new Arista { Inicio = n1, Fin = n2 });
            }
        }

        public List<Nodo> ForeachRecursivo(List<Nodo> lstNodo)
        {
            List<Nodo> lListas = new List<Nodo>();

            foreach (Nodo n in lstNodo)
            {
                List<Nodo> lst = new List<Nodo>() { lstNodo[0] };
                RutaNodo2(ref lListas, lst, n, lstNodo);
            }

            return lListas;

        }

        public void RutaNodo2(ref List<Nodo> masCorta, List<Nodo> lst, Nodo i, List<Nodo> lstNodo)
        {
            List<Nodo> lst2 = new List<Nodo>();
            lst2.AddRange(lst);
            lst2.Add(i);
            foreach (Nodo i2 in lstNodo)
            {
                if(lst2.Count == lstNodo.Count)
                {
                    GetNDirection(i, lstNodo[0], true);
                }

                if (!lst2.Contains(i2))
                {
                    //if (lst2.Count == lstNodo.Count)
                    //    GetNDirection(i, lstNodo[0], true);
                    GetNDirection(i2, i,true);
                    //if (lst2.Count == lstNodo.Count)
                    //    GetNDirection(i, lstNodo[0], true);
                    RutaNodo2(ref masCorta, lst2, i2, lstNodo);
                }
            }
            List<Nodo> fn = new List<Nodo>();
            fn.AddRange(lst2);
            if (masCorta.Count == lstNodo.Count && sumCosto(fn) > sumCosto(masCorta))
                return;
            if (lst2.Count == lstNodo.Count)
            {
                lst2 = new List<Nodo>() { lstNodo[0] };
                if (masCorta.Count == 0)
                    masCorta = fn.Select(n => Clon(n)).ToList();
                else if (sumCosto(fn) < sumCosto(masCorta))
                    masCorta = fn.Select(n => Clon(n)).ToList();
            }

        }

        //public static void RutaNodo(ref List<Nodo> masCorta, List<Nodo> lst, Nodo i, List<Nodo> lstNodo)
        //{
        //    if (lst == null)
        //    {
        //        RutaNodo(ref masCorta, new List<Nodo>() { lstNodo[0] }, null, lstNodo);
        //    }
        //    else
        //    {
        //        List<Nodo> lst2 = new List<Nodo>();
        //        lst2.AddRange(lst);
        //        if (i != null)
        //            lst2.Add(i);
        //        foreach (Nodo i2 in lstNodo)
        //        {
        //            if (!lst2.Contains(i2))
        //            {
        //                if (i == null)
        //                    i2.nCosto = 0;
        //                else
        //                {
        //                    GetNDirection(i, i2);
        //                }
        //                RutaNodo(ref masCorta, lst2, i2, lstNodo);
        //            }
        //        }
        //        List<Nodo> fn = new List<Nodo>();
        //        fn.AddRange(lst2);
        //        if (masCorta.Count == lstNodo.Count && sumCosto(fn) > sumCosto(masCorta))
        //            return;
        //        if (lst2.Count == lstNodo.Count)
        //        {
        //            lst2 = null;
        //            if (masCorta.Count == 0)
        //                masCorta = fn.Select(n => Clon(n)).ToList();
        //            else if (sumCosto(fn) < sumCosto(masCorta))
        //                masCorta = fn.Select(n => Clon(n)).ToList();
        //        }
        //    }

        //}
        public static double sumCosto(List<Nodo> lst)
        {
            double nCostoTot = 0d;
            foreach (Nodo i in lst)
            {
                nCostoTot += i.nCosto;
            }
            return nCostoTot;
        }
        public static Nodo Clon(Nodo n)
        {
            return new Nodo()
            {
                nCosto = n.nCosto,
                nLat = n.nLat,
                nLong = n.nLong,
                cGeometry = n.cGeometry
            };
        }
    }
}
