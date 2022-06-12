using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Transformar_Datos_Operaciones_C : ITransformarTextToDataSet
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
                    strXML += $"<Fecha_de_Alta>{ConversionesGenericas.sustraerTexto(linea, 6, 8)}</Fecha_de_Alta>" + Environment.NewLine;
                    strXML += $"<Tipo_de_Registro>{ConversionesGenericas.sustraerTexto(linea, 14, 1)}</Tipo_de_Registro>" + Environment.NewLine;
                    strXML += $"<Cuenta>{ConversionesGenericas.sustraerTexto(linea, 15, 12)}</Cuenta>" + Environment.NewLine;
                    strXML += $"<Descripcion_de_la_Cuenta>{ConversionesGenericas.sustraerTexto(linea, 27, 30)}</Descripcion_de_la_Cuenta>" + Environment.NewLine;
                    strXML += $"<Actualizar_Saldo_Inicial>{ConversionesGenericas.sustraerTexto(linea, 57, 1)}</Actualizar_Saldo_Inicial>" + Environment.NewLine;
                    strXML += $"<Saldo_Inicial>{ConversionesGenericas.sustraerTexto(linea, 58, 14)}</Saldo_Inicial>" + Environment.NewLine;
                    strXML += $"<Ampliacion>{ConversionesGenericas.sustraerTexto(linea, 72, 1)}</Ampliacion>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 73, 4)}</Reserva>" + Environment.NewLine;
                    strXML += $"<NIF>{ConversionesGenericas.sustraerTexto(linea, 77, 14)}</NIF>" + Environment.NewLine;
                    strXML += $"<Siglas_Via_Publica>{ConversionesGenericas.sustraerTexto(linea, 91, 2)}</Siglas_Via_Publica>" + Environment.NewLine;
                    strXML += $"<Via_Publica>{ConversionesGenericas.sustraerTexto(linea, 93, 30)}</Via_Publica>" + Environment.NewLine;
                    strXML += $"<Numero>{ConversionesGenericas.sustraerTexto(linea, 123, 5)}</Numero>" + Environment.NewLine;
                    strXML += $"<Escalera>{ConversionesGenericas.sustraerTexto(linea, 128, 2)}</Escalera>" + Environment.NewLine;
                    strXML += $"<Piso>{ConversionesGenericas.sustraerTexto(linea, 130, 2)}</Piso>" + Environment.NewLine;
                    strXML += $"<Puerta>{ConversionesGenericas.sustraerTexto(linea, 132, 2)}</Puerta>" + Environment.NewLine;
                    strXML += $"<Municipio>{ConversionesGenericas.sustraerTexto(linea, 134, 20)}</Municipio>" + Environment.NewLine;
                    strXML += $"<Codigo_Postal>{ConversionesGenericas.sustraerTexto(linea, 154, 5)}</Codigo_Postal>" + Environment.NewLine;
                    strXML += $"<Provincia>{ConversionesGenericas.sustraerTexto(linea, 159, 15)}</Provincia>" + Environment.NewLine;
                    strXML += $"<Pais>{ConversionesGenericas.sustraerTexto(linea, 174, 3)}</Pais>" + Environment.NewLine;
                    strXML += $"<Telefono>{ConversionesGenericas.sustraerTexto(linea, 177, 12)}</Telefono>" + Environment.NewLine;
                    strXML += $"<Extension>{ConversionesGenericas.sustraerTexto(linea, 189, 4)}</Extension>" + Environment.NewLine;
                    strXML += $"<Fax>{ConversionesGenericas.sustraerTexto(linea, 193, 12)}</Fax>" + Environment.NewLine;
                    strXML += $"<E_mail>{ConversionesGenericas.sustraerTexto(linea, 205, 30)}</E_mail>" + Environment.NewLine;
                    strXML += $"<Reservado>{ConversionesGenericas.sustraerTexto(linea, 235, 2)}</Reservado>" + Environment.NewLine;
                    strXML += $"<Criterio_de_Caja>{ConversionesGenericas.sustraerTexto(linea, 237, 1)}</Criterio_de_Caja>" + Environment.NewLine;
                    strXML += $"<Reservado>{ConversionesGenericas.sustraerTexto(linea, 238, 2)}</Reservado>" + Environment.NewLine;
                    strXML += $"<Cuenta_Contrapartida>{ConversionesGenericas.sustraerTexto(linea, 240, 12)}</Cuenta_Contrapartida>" + Environment.NewLine;
                    strXML += $"<Codigo_de_Pais>{ConversionesGenericas.sustraerTexto(linea, 252, 2)}</Codigo_de_Pais>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 254, 254)}</Reserva>" + Environment.NewLine;
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
