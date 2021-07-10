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
        public JsonClient Clients(String pDni, String pPin)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"clients?id={pDni}&pass={pPin}");

                /* Convertimos el String en Json(Clients) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<JsonClient> objList = (List<JsonClient>)serializer.Deserialize(json, typeof(List<JsonClient>));
                return objList[0];

            }
            catch (JsonNullException)
            {
                return null;
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }
        /// <summary>
        /// Obtiene las tarjetas que dispone el cliente. 
        /// </summary>
        /// <param name="pDni">Dni del cliente</param>
        /// <returns></returns>
        public JsonProduct Products(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"products?id={pDni}");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<JsonProduct> objList = (List<JsonProduct>)serializer.Deserialize(json, typeof(List<JsonProduct>));
                return objList[0];

            }
            catch (JsonNullException)
            {
                return null;
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }
        /// <summary>
        /// blanquea o resetear el PIN de la tarjeta de débito del cliente.
        /// </summary>
        /// <param name="pNumber">Numero de tarjeta a ser blanqueada</param>
        /// <returns>Devuelve el estado de la respuesta del blanqueo</returns>
        public JsonErrorRest ProductReset(String pNumber)
        {

            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"product-reset?number={pNumber}");

                /* cambiamos el campo "error-description" a "errorDescription" */
                json = json.Replace("error-description", "errorDescription");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<JsonErrorRest> objList = (List<JsonErrorRest>)serializer.Deserialize(json, typeof(List<JsonErrorRest>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }
        /// <summary>
        ///  Informa el estado de la cuenta corriente del cliente.
        /// </summary>
        /// <param name="pDni">Dni del dueño de la tarjeta</param>
        /// <returns>Devuelve el salgo del cliente</returns>
        public JsonBalance Balance(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"account-balance?id={pDni}");

                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<JsonBalance> objList = (List<JsonBalance>)serializer.Deserialize(json, typeof(List<JsonBalance>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
            catch (Exception err)
            {
                Log.save(err);
            }
        }
        /// <summary>
        ///  Devuelve la información de los últimos movimientos de la cuenta corriente del cliente.
        /// </summary>
        /// <param name="pDni">Dni del dueño de la cuenta</param>
        /// <returns>Devuelve los ultimos movimientos</returns>
        public JsonMovement UltimosMovimientos(String pDni)
        {
            try
            {
                /* Hacemos el GET a la API */
                String json = this.PostJson($"account-movements?id={pDni}");
                
                /* Convertimos el String en Json(Products) */
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                List<JsonMovement> objList = (List<JsonMovement>)serializer.Deserialize(json, typeof(List<JsonMovement>));
                return objList[0];
            }
            catch (JsonNullException)
            {
                return null;
            }
            catch (Exception err)
            {
                Log.save(err);
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
