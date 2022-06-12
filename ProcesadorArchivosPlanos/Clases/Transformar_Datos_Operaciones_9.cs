using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Transformar_Datos_Operaciones_9 : ITransformarTextToDataSet
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
                    strXML += $"<Tipo_de_Importe_CoA>{ConversionesGenericas.sustraerTexto(linea, 57, 1)}</Tipo_de_Importe_CoA>" + Environment.NewLine;
                    strXML += $"<Numero_de_Documento>{ConversionesGenericas.sustraerTexto(linea, 58, 10)}</Numero_de_Documento>" + Environment.NewLine;
                    strXML += $"<Linea_de_Apunte_MoU>{ConversionesGenericas.sustraerTexto(linea, 68, 1)}</Linea_de_Apunte_MoU>" + Environment.NewLine;
                    strXML += $"<Descripcion_del_Apunte>{ConversionesGenericas.sustraerTexto(linea, 69, 30)}</Descripcion_del_Apunte>" + Environment.NewLine;
                    strXML += $"<Subtipo_de_Factura_1a7>{ConversionesGenericas.sustraerTexto(linea, 99, 2)}</Subtipo_de_Factura_1a7>" + Environment.NewLine;
                    strXML += $"<Base_Imponible>{ConversionesGenericas.sustraerTexto(linea, 101, 14)}</Base_Imponible>" + Environment.NewLine;
                    strXML += $"<Porcentaje_de_IVA>{ConversionesGenericas.sustraerTexto(linea, 115, 5)}</Porcentaje_de_IVA>" + Environment.NewLine;
                    strXML += $"<Cuota_de_IVA>{ConversionesGenericas.sustraerTexto(linea, 120, 14)}</Cuota_de_IVA>" + Environment.NewLine;
                    strXML += $"<Porcentaje_de_Recargo>{ConversionesGenericas.sustraerTexto(linea, 134, 5)}</Porcentaje_de_Recargo>" + Environment.NewLine;
                    strXML += $"<Cuota_de_Recargo>{ConversionesGenericas.sustraerTexto(linea, 139, 14)}</Cuota_de_Recargo>" + Environment.NewLine;
                    strXML += $"<Porcentaje_de_Retencion>{ConversionesGenericas.sustraerTexto(linea, 153, 5)}</Porcentaje_de_Retencion>" + Environment.NewLine;
                    strXML += $"<Cuota_de_Retencion>{ConversionesGenericas.sustraerTexto(linea, 158, 14)}</Cuota_de_Retencion>" + Environment.NewLine;
                    strXML += $"<Operacion_Sujeta_a_IVA>{ConversionesGenericas.sustraerTexto(linea, 172, 1)}</Operacion_Sujeta_a_IVA>" + Environment.NewLine;
                    strXML += $"<Marca_Afecta_415>{ConversionesGenericas.sustraerTexto(linea, 175, 1)}</Marca_Afecta_415>" + Environment.NewLine;
                    strXML += $"<Marca_Factura_en_CC>{ConversionesGenericas.sustraerTexto(linea, 176, 1)}</Marca_Factura_en_CC>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 177, 14)}</Reserva>" + Environment.NewLine;
                    strXML += $"<Cuenta_IVA_Soportado>{ConversionesGenericas.sustraerTexto(linea, 191, 12)}</Cuenta_IVA_Soportado>" + Environment.NewLine;
                    strXML += $"<Cuenta_Recargo_Soportado>{ConversionesGenericas.sustraerTexto(linea, 203, 12)}</Cuenta_Recargo_Soportado>" + Environment.NewLine;
                    strXML += $"<Cuenta_Retencion>{ConversionesGenericas.sustraerTexto(linea, 215, 12)}</Cuenta_Retencion>" + Environment.NewLine;
                    strXML += $"<Cuenta_IVA2_Repercutido>{ConversionesGenericas.sustraerTexto(linea, 227, 12)}</Cuenta_IVA2_Repercutido>" + Environment.NewLine;
                    strXML += $"<Cuenta_de_Recargo2_Repercutid>{ConversionesGenericas.sustraerTexto(linea, 239, 12)}</Cuenta_de_Recargo2_Repercutid>" + Environment.NewLine;
                    strXML += $"<Tiene_Registro_Analitico>{ConversionesGenericas.sustraerTexto(linea, 251, 1)}</Tiene_Registro_Analitico>" + Environment.NewLine;
                    strXML += $"<Reserva>{ConversionesGenericas.sustraerTexto(linea, 252, 256)}</Reserva>" + Environment.NewLine;
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
