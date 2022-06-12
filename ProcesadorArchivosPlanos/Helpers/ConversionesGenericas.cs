using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

namespace ProcesadorArchivosPlanos.Helpers
{
    internal static class ConversionesGenericas
    {

        public static DataSet string_to_DataSet(string strXML)
        {

            DataSet dsDatos = new DataSet();

            try
            {                
                TextReader txtReader1 = new StringReader(strXML);
                XmlReader reader1 = new XmlTextReader(txtReader1);
                dsDatos.ReadXml(reader1);
            }
            catch (Exception ex)
            {
                throw ex;               
            }

            return dsDatos;
            
        }

        public static string sustraerTexto(string texto,int posicionInicial, int cantCaracteres )
        {

            if (texto.Length > (posicionInicial + cantCaracteres))
            {
                texto = texto.Substring(posicionInicial, cantCaracteres);
            }
            else
            {
                texto = "";
            }

            return texto;

        }

    }
}
