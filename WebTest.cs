using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;

namespace MapsExemplo
{
    internal class WebTest
    {
        public string RequestDadosWeb(string pstrURL)
        {
            WebRequest oWebRequest;
            WebResponse oWebResponse = null/* TODO Change to default(_) if this is not a reference type */;
            string strBuffer = "";
            StreamReader objSR = null;
            // conecta com o website
            try
            {
                oWebRequest = HttpWebRequest.Create(pstrURL);
                oWebResponse = oWebRequest.GetResponse();
                // Le a resposta do web site e armazena em uma stream
                objSR = new StreamReader(oWebResponse.GetResponseStream());
                strBuffer = objSR.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objSR.Close();
                oWebResponse.Close();
            }
            return strBuffer;
        }

    }
}
