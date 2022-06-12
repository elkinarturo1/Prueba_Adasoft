using ProcesadorArchivosPlanos.Helpers;
using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ProcesadorArchivosPlanos.Clases
{
    internal class Listener
    {
        ConfiguracionesModel configuracion;
        ICapturarDatos capturarDatos;
        ITransformarTextToDataSet transformarDatos;        
        DatosModel datos;
        string nombreArchivo;

        public Listener(ConfiguracionesModel p_Configuraciones)
        {
            configuracion = p_Configuraciones;
        }

        public void encenderEscucha()
        {
            FileSystemWatcher watcher = new FileSystemWatcher(configuracion.rutaPlano);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Created += OnCreated;
            //watcher.Changed += OnChanged;
            //watcher.Created += OnCreated;
            //watcher.Deleted += OnDeleted;
            //watcher.Renamed += OnRenamed;
            //watcher.Error += OnError;

            watcher.Filter = "*.DAT";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;

            Console.WriteLine("Listener Activado.");
            Console.ReadLine();

        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {               

            try
            {

                configuracion.archivoOrigen = e.FullPath;
                nombreArchivo = e.Name;

                capturarDatos = new CapturarDatosDesdeArchivo(configuracion);
                datos = capturarDatos.LeerInformacion();


                DataSet dsDatos;

                if (datos.list_Operaciones_0 != null)
                {
                    transformarDatos = new Transformar_Datos_Operaciones_0();
                    dsDatos = new DataSet();
                    dsDatos = transformarDatos.mapearCampos(datos.list_Operaciones_0);
                    
                    string rutaArchivoExcel = configuracion.rutaExcel + $"Operaciones_0_{DateTime.Now.ToString("yyyyMMddmmssff")}.xlsx";                    
                    GenerarArchivos.generarArchivoExcel(rutaArchivoExcel, dsDatos);                   
                }

                if (datos.list_Operaciones_1 != null)
                {
                    transformarDatos = new Transformar_Datos_Operaciones_1();
                    dsDatos = new DataSet();
                    dsDatos = transformarDatos.mapearCampos(datos.list_Operaciones_1);

                    string rutaArchivoExcel = configuracion.rutaExcel + $"Operaciones_1_{DateTime.Now.ToString("yyyyMMddmmssff")}.xlsx";
                    GenerarArchivos.generarArchivoExcel(rutaArchivoExcel, dsDatos);
                }


                if (datos.list_Operaciones_9 != null)
                {
                    transformarDatos = new Transformar_Datos_Operaciones_9();
                    dsDatos = new DataSet();
                    dsDatos = transformarDatos.mapearCampos(datos.list_Operaciones_9);

                    string rutaArchivoExcel = configuracion.rutaExcel + $"Operaciones_9_{DateTime.Now.ToString("yyyyMMddmmssff")}.xlsx";
                    GenerarArchivos.generarArchivoExcel(rutaArchivoExcel, dsDatos);
                }

                if (datos.list_Operaciones_C != null)
                {
                    transformarDatos = new Transformar_Datos_Operaciones_C();
                    dsDatos = new DataSet();
                    dsDatos = transformarDatos.mapearCampos(datos.list_Operaciones_C);

                    string rutaArchivoExcel = configuracion.rutaExcel + $"Operaciones_C_{DateTime.Now.ToString("yyyyMMddmmssff")}.xlsx";
                    GenerarArchivos.generarArchivoExcel(rutaArchivoExcel, dsDatos);
                }

                GenerarArchivos.moverArchivo(configuracion.archivoOrigen, configuracion.rutaCorrectos,nombreArchivo);

                GenerarArchivos.guardarLog(configuracion.rutaLogs, "Proceso Terminado Exitosamente");

            }
            catch (Exception ex)
            {
                GenerarArchivos.guardarLog(configuracion.rutaLogs, $"Ocurrio un error {ex.Message}");
            }

        }        

    }
}
