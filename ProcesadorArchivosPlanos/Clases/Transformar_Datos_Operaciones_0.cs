using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Transformar_Datos_Operaciones_0 : ITransformarTextToDataSet
    {
        public DataSet mapearCampos(List<string> listadoDatos)
        {     
            DataSet dsResultado = new DataSet();
            string strXML = "";

            try
            {
                strXML += "<MyDataSet>" + Environment.NewLine;
                foreach (string linea in listadoDatos)
                {
                    strXML += "<Datos>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Formato>{ConversionesGenericas.sustraerTexto(linea,0,1)}</Tipo_de_Formato>" + Environment.NewLine;
                    strXML += $"<Codigo_de_Empresa>{ConversionesGenericas.sustraerTexto(linea,1, 5)}</Codigo_de_Empresa>" + Environment.NewLine;
                    strXML += $"<Fecha_del_Apunte>{ConversionesGenericas.sustraerTexto(linea,6, 8)}</Fecha_del_Apunte>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Registro>{ConversionesGenericas.sustraerTexto(linea,14, 1)}</Tipo_de_Registro>" + Environment.NewLine;
                    strXML += $"<Cuenta>{ConversionesGenericas.sustraerTexto(linea,15, 12)}</Cuenta>" + Environment.NewLine;
                    strXML += $"<Descripcion_de_la_Cuenta>{ConversionesGenericas.sustraerTexto(linea,27, 30)}</Descripcion_de_la_Cuenta>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Importe_D_H>{ConversionesGenericas.sustraerTexto(linea,57, 1)}</Tipo_de_Importe_D_H>" + Environment.NewLine;
                    strXML += $"<Referencia_del_Documento>{ConversionesGenericas.sustraerTexto(linea,58, 10)}</Referencia_del_Documento>" + Environment.NewLine;
                    strXML += $"<Linea_de_Apunte_I_M_U>{ConversionesGenericas.sustraerTexto(linea,68, 10)}</Linea_de_Apunte_I_M_U>" + Environment.NewLine;
                    strXML += $"<Descripcion_del_Apunte>{ConversionesGenericas.sustraerTexto(linea,69, 30)}</Descripcion_del_Apunte>" + Environment.NewLine;
                    strXML += $"<Importe>{ConversionesGenericas.sustraerTexto(linea,99, 14)}</Importe>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea,113, 137)}</Reserva>" + Environment.NewLine;
                    strXML += $"<Indicador_de_Asiento_de_Nomina>{ConversionesGenericas.sustraerTexto(linea,250, 1)}</Indicador_de_Asiento_de_Nomina>" + Environment.NewLine;
                    strXML += $"<Tiene_Registro_Analitico>{ConversionesGenericas.sustraerTexto(linea,251, 1)}</Tiene_Registro_Analitico>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea,252, 256)}</Reserva>" + Environment.NewLine;
                    strXML += $"<Moneda_Enlace>{ConversionesGenericas.sustraerTexto(linea,508, 1)}</Moneda_Enlace>" + Environment.NewLine;
                    strXML += $"<Indicador_de_Generado_N>{ConversionesGenericas.sustraerTexto(linea,509, 1)}</Indicador_de_Generado_N>" + Environment.NewLine;
                    strXML += $"<Retorno_de_Carro>{ConversionesGenericas.sustraerTexto(linea,510, 2)}</Retorno_de_Carro>" + Environment.NewLine;
                    strXML += "</Datos>" + Environment.NewLine;
                }
                strXML += "</MyDataSet>" + Environment.NewLine;

                dsResultado = ConversionesGenericas.string_to_DataSet(strXML);

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dsResultado;

        }
    }
}
