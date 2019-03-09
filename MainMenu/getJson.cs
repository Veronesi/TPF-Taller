using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MainMenu
{
    class getJson
    {
        public Clients Clients(String pDni, String pPin)
        {
            /* Hacemos el GET a la API */
            String strresulttest = this.PostJson($"clients?id={pDni}&pass={pPin}");

            /* Convertimos el String en Json(Clients) */
            if (strresulttest != "[]") { 
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                Clients objList = (Clients)serializer.Deserialize(strresulttest, typeof(Clients));
                return objList;
            }
            else
            {
                return null;
            }
        }
        public string PostJson(String pJson) { 
            /* URL que referencia a la API */
            string url = String.Format("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/"+pJson);
            WebRequest requestObjGet = WebRequest.Create(url);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;

            /* Hacemos el GET a la API */
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }
            /* Devolvemos el Json en fomrato String */
            return strresulttest;
        }
    }
}
