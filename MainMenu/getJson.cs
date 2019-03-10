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
        /// <summary>
        ///  Obtención de información del cliente, para acceder a los datos del cliente.
        /// </summary>
        /// <param name="pDni">Dni del cliente</param>
        /// <param name="pPin">Pin del cliente</param>
        /// <returns></returns>
        public Clients Clients(String pDni, String pPin)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"clients?id={pDni}&pass={pPin}");

                /* Convertimos el String en Json(Clients) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Clients> objList = (List<Clients>)serializer.Deserialize(json, typeof(List<Clients>));
                return objList[0];

            }
            catch (JsonNullException)
            {
                return null;
            }
        }
        /// <summary>
        /// Obtiene las tarjetas que dispone el cliente. 
        /// </summary>
        /// <param name="pDni">Dni del cliente</param>
        /// <returns></returns>
        public Products Products(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"products?id={pDni}");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Products> objList = (List<Products>)serializer.Deserialize(json, typeof(List<Products>));
                return objList[0];

            }
            catch (JsonNullException)
            {
                return null;
            }
        }
        /// <summary>
        /// blanquea o resetear el PIN de la tarjeta de débito del cliente.
        /// </summary>
        /// <param name="pNumber">Numero de tarjeta a ser blanqueada</param>
        /// <returns>Devuelve el estado de la respuesta del blanqueo</returns>
        public ProductReset ProductReset(String pNumber)
        {

            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"product-reset?number={pNumber}");

                /* cambiamos el campo "error-description" a "errorDescription" */
                json = json.Replace("error-description", "errorDescription");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<ProductReset> objList = (List<ProductReset>)serializer.Deserialize(json, typeof(List<ProductReset>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
        }
        /// <summary>
        ///  Informa el estado de la cuenta corriente del cliente.
        /// </summary>
        /// <param name="pDni">Dni del dueño de la tarjeta</param>
        /// <returns>Devuelve el salgo del cliente</returns>
        public Balance Balance(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"account-balance?id={pDni}");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Balance> objList = (List<Balance>)serializer.Deserialize(json, typeof(List<Balance>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
        }
        /// <summary>
        ///  Devuelve la información de los últimos movimientos de la cuenta corriente del cliente.
        /// </summary>
        /// <param name="pDni">Dni del dueño de la cuenta</param>
        /// <returns>Devuelve los ultimos movimientos</returns>
        public Movimiento UltimosMovimientos(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"account-movements?id={pDni}");
                
                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<Movimiento> objList = (List<Movimiento>)serializer.Deserialize(json, typeof(List<Movimiento>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
        }
        /// <summary>
        /// envia un GET a la API del banco simulado
        /// </summary>
        /// <param name="pJson">header de la url a ser enviada</param>
        /// <returns>Devuelve el Json en formado String</returns>
        public string PostJson(String pJson) {
                /* URL que referencia a la API */
                string url = String.Format("https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/"+pJson);
                WebRequest requestObjGet = WebRequest.Create(url);
                requestObjGet.Method = "GET";
                HttpWebResponse responseObjGet = null;

                /* Hacemos el GET a la API */
                responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
                string json = null;
                using (Stream stream = responseObjGet.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    json = sr.ReadToEnd();
                    sr.Close();
                }
                if (json == "[]")
                    throw new JsonNullException();

                /* Devolvemos el Json en fomrato String */
                return json;
        }
    }
}
