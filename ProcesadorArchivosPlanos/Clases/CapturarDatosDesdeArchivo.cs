using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class CapturarDatosDesdeArchivo : ICapturarDatos
    {

        ConfiguracionesModel configuracion;

        public CapturarDatosDesdeArchivo(ConfiguracionesModel p_Configuraciones)
        {
            configuracion = p_Configuraciones;
        }

        public DatosModel LeerInformacion()
        {

            DatosModel datosModel = new DatosModel();
            List<string> list_Operaciones_0 = new List<string>();
            List<string> list_Operaciones_1 = new List<string>();
            List<string> list_Operaciones_9 = new List<string>();
            List<string> list_Operaciones_C = new List<string>();

            try
            {
                StreamReader reader = new System.IO.StreamReader(configuracion.archivoOrigen);
                string LineaOriginal;


                do
                {

                    LineaOriginal = reader.ReadLine();

                    if (LineaOriginal != null)
                    {

                        string strTipoProceso = LineaOriginal.Substring(14, 1).ToUpper();

                        switch (strTipoProceso)
                        {
                            case "0":
                                list_Operaciones_0.Add(LineaOriginal);
                                break;

                            case "1":
                                list_Operaciones_1.Add(LineaOriginal);
                                break;

                            case "9":
                                list_Operaciones_9.Add(LineaOriginal);
                                break;

                            case "C":
                                list_Operaciones_C.Add(LineaOriginal);
                                break;
                        }

                    }

                } while (LineaOriginal != null);
                reader.Close();

                datosModel.list_Operaciones_0 = list_Operaciones_0;
                datosModel.list_Operaciones_1 = list_Operaciones_1;
                datosModel.list_Operaciones_9 = list_Operaciones_9;
                datosModel.list_Operaciones_C = list_Operaciones_C;

                return datosModel;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
