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
        public static List<Nodo> MejorRuta { get; set; }
        public static string f(double value)
        {
            return value.ToString().Replace(",",".");
        }
        public static void GetNDirection(Nodo n1, Nodo n2)
        {
            if (MejorRuta == null)
                MejorRuta = new List<Nodo>();
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
            float va3 = va2.Value<dynamic>("weight");
            string va4 = va2.Value<dynamic>("geometry");
            n2.nCosto = va3;
            n2.cGeometry = va4;

            Nodo nod3 = MejorRuta.Find(n => n.nLat == n2.nLat && n.nLong == n2.nLong);
            if (nod3 != null)
            {
                nod3.nCosto = va3;
                nod3.cGeometry = va4;
            }
            else
            {
                MejorRuta.Add(Clon(n2));
            }
        }

        public static List<Nodo> ForeachRecursivo(List<Nodo> lstNodo)
        {
            List<Nodo> lListas = new List<Nodo>();

            RutaNodo(ref lListas, null, null, lstNodo);

            var d = MejorRuta;
            lListas.ForEach(nn => {
                var g = d.Find(x => x.nLat == nn.nLat && x.nLong == nn.nLong);
                if (g != null)
                {
                    nn.cGeometry = g.cGeometry;
                    nn.nCosto = g.nCosto;
                }
            });
            return lListas;

        }
        public static void RutaNodo(ref List<Nodo> masCorta, List<Nodo> lst, Nodo i, List<Nodo> lstNodo)
        {
            if (lst == null)
            {
                RutaNodo(ref masCorta, new List<Nodo>() { lstNodo[0] }, null, lstNodo);
            }
            else
            {
                List<Nodo> lst2 = new List<Nodo>();
                lst2.AddRange(lst);
                if (i != null)
                    lst2.Add(i);
                foreach (Nodo i2 in lstNodo)
                {
                    if (!lst2.Contains(i2))
                    {
                        if (i == null)
                            i2.nCosto = 0;
                        else
                        {
                            GetNDirection(i, i2);
                        }
                        RutaNodo(ref masCorta, lst2, i2, lstNodo);
                    }
                }
                List<Nodo> fn = new List<Nodo>();
                fn.AddRange(lst2);
                if (masCorta.Count == lstNodo.Count && sumCosto(fn) > sumCosto(masCorta))
                    return;
                if (lst2.Count == lstNodo.Count)
                {
                    lst2 = null;
                    if (masCorta.Count == 0)
                        masCorta = fn.Select(n => Clon(n)).ToList();
                    else if (sumCosto(fn) < sumCosto(masCorta))
                        masCorta = fn.Select(n => Clon(n)).ToList();
                }
            }

        }
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
