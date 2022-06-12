using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Transformar_Datos_Operaciones_1 : ITransformarTextToDataSet
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
                    strXML += $"<Tipo_de_Formato>{ConversionesGenericas.sustraerTexto(linea, 0, 1)}</Tipo_de_Formato>" + Environment.NewLine;
                    strXML += $"<Codigo_de_Empresa>{ConversionesGenericas.sustraerTexto(linea, 1, 5)}</Codigo_de_Empresa>" + Environment.NewLine;
                    strXML += $"<Fecha_del_Apunte>{ConversionesGenericas.sustraerTexto(linea, 6, 8)}</Fecha_del_Apunte>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Registro>{ConversionesGenericas.sustraerTexto(linea, 14, 1)}</Tipo_de_Registro>" + Environment.NewLine;
                    strXML += $"<Cuenta>{ConversionesGenericas.sustraerTexto(linea, 15, 12)}</Cuenta>" + Environment.NewLine;
                    strXML += $"<Descripcion_de_la_Cuenta>{ConversionesGenericas.sustraerTexto(linea, 27, 30)}</Descripcion_de_la_Cuenta>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Factura>{ConversionesGenericas.sustraerTexto(linea, 57, 1)}</Tipo_de_Factura>" + Environment.NewLine;
                    strXML += $"<Numero_de_Documento>{ConversionesGenericas.sustraerTexto(linea, 58, 10)}</Numero_de_Documento>" + Environment.NewLine;
                    strXML += $"<Linea_deApunte_I>{ConversionesGenericas.sustraerTexto(linea, 68, 1)}</Linea_deApunte_I>" + Environment.NewLine;
                    strXML += $"<Descripcion_del_Apunte>{ConversionesGenericas.sustraerTexto(linea, 69, 30)}</Descripcion_del_Apunte>" + Environment.NewLine;
                    strXML += $"<Importe>{ConversionesGenericas.sustraerTexto(linea, 99, 14)}</Importe>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 113, 62)}</Reserva>" + Environment.NewLine;
                    strXML += $"<NIF_Cliente_o_Proveedor>{ConversionesGenericas.sustraerTexto(linea, 175, 14)}</NIF_Cliente_o_Proveedor>" + Environment.NewLine;
                    strXML += $"<Nombre_Cliente_o_Proveedor>{ConversionesGenericas.sustraerTexto(linea, 189, 40)}</Nombre_Cliente_o_Proveedor>" + Environment.NewLine;
                    strXML += $"<Codigo_Postal>{ConversionesGenericas.sustraerTexto(linea, 229, 5)}</Codigo_Postal>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 234, 2)}</Reserva>" + Environment.NewLine;
                    strXML += $"<Fecha_de_Operacion>{ConversionesGenericas.sustraerTexto(linea, 236, 8)}</Fecha_de_Operacion>" + Environment.NewLine;
                    strXML += $"<Fecha_de_Factura>{ConversionesGenericas.sustraerTexto(linea, 244, 8)}</Fecha_de_Factura>" + Environment.NewLine;
                    strXML += $"<Numero_Factura_ampliado_SII>{ConversionesGenericas.sustraerTexto(linea, 252, 60)}</Numero_Factura_ampliado_SII>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 312, 196)}</Reserva>" + Environment.NewLine;
                    strXML += $"<Moneda_Enlace>{ConversionesGenericas.sustraerTexto(linea, 508, 1)}</Moneda_Enlace>" + Environment.NewLine;
                    strXML += $"<Indicador_de_Generado_N>{ConversionesGenericas.sustraerTexto(linea, 509, 1)}</Indicador_de_Generado_N>" + Environment.NewLine;
                    strXML += $"<Retorno_de_Carro>{ConversionesGenericas.sustraerTexto(linea, 510, 2)}</Retorno_de_Carro>" + Environment.NewLine;
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
