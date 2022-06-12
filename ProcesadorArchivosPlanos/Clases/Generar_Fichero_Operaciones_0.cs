using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Generar_Fichero_Operaciones_0 : IGenerarDatos
    {        
        ConfiguracionesModel configuracion;
        DataSet dsDatos;

        public Generar_Fichero_Operaciones_0(ConfiguracionesModel p_ConfiguracionesModel,DataSet p_DS)
        {            
            configuracion = p_ConfiguracionesModel;
            dsDatos = p_DS;
        }

        public void entregarInformacion()
        {
            configuracion.rutaExcel += $"Operaciones_0_{DateTime.Now.ToString("yyyyMMddmmssff")}.xlsx";
            GenerarArchivos.generarArchivoExcel(configuracion.rutaExcel, dsDatos);
        }
    }
}
