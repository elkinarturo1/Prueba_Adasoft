using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcesadorArchivosPlanos.Interfaces
{
    internal interface ICapturarDatos
    {
        DatosModel LeerInformacion();
    }
}
