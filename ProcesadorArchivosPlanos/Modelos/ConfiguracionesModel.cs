using System;
using System.Collections.Generic;
using System.Text;

namespace ProcesadorArchivosPlanos.Modelos
{
    public class ConfiguracionesModel
    {

        public string rutaPlano { get; set; }
        public string rutaCorrectos { get; set; }
        public string rutaErrores { get; set; }
        public string rutaLogs { get; set; }
        public string archivoOrigen { get; set; }
        public string rutaExcel { get; set; }

    }
}
