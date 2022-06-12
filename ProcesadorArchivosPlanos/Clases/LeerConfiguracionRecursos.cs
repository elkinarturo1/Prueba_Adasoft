using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    public class LeerConfiguracionRecursos : IConfiguraciones
    {
        public ConfiguracionesModel leerConfiguracion()
        {
            ConfiguracionesModel configuracionesModel = new ConfiguracionesModel();

            configuracionesModel.rutaPlano = Properties.Resources.rutaPlano;
            configuracionesModel.rutaCorrectos = Properties.Resources.rutaCorrectos;
            configuracionesModel.rutaErrores = Properties.Resources.rutaErrores;
            configuracionesModel.rutaLogs = Properties.Resources.rutaLogs;
            configuracionesModel.rutaExcel = Properties.Resources.rutaExcel;

            return configuracionesModel;
        }
    }
}
