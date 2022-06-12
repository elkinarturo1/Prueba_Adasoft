using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProcesadorArchivosPlanos.Interfaces
{
    internal interface ITransformarTextToDataSet
    {
        DataSet mapearCampos(List<string> listadoDatos);
    }
}
