using ProcesadorArchivosPlanos.Clases;
using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProcesadorArchivosPlanos.Bussines
{
    internal class ContextodeProcesos
    {

        ConfiguracionesModel config;

        public ContextodeProcesos()
        {            
            IConfiguraciones objCapturaConfiguracion = new LeerConfiguracionRecursos();
            config = objCapturaConfiguracion.leerConfiguracion();
        }

        public void ejecutarProceso()
        {
            Listener listener = new Listener(config);
            listener.encenderEscucha();           
        }

    }
}
