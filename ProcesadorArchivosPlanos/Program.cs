using ProcesadorArchivosPlanos.Bussines;
using ProcesadorArchivosPlanos.Clases;
using ProcesadorArchivosPlanos.Interfaces;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ProcesadorArchivosPlanos
{

    internal class Program
    {

        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const Int32 SW_SHOWMINNOACTIVE = 7;
        private const Int32 SW_SHOWNORMAL = 1;
        private const Int32 SW_HIDE = 0;


        static void Main(string[] args)
        {
            ShowWindow(GetConsoleWindow(), SW_HIDE);
            ContextodeProcesos contextodeProcesos = new ContextodeProcesos();
            contextodeProcesos.ejecutarProceso();
        }   

    }
















    //static class Program
    //{

    //    //[DllImport("kernel32.dll", ExactSpelling = true)]
    //    //private static extern IntPtr GetConsoleWindow();
    //    //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    //    //private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    //    //private const Int32 SW_SHOWMINNOACTIVE = 7;
    //    //private const Int32 SW_SHOWNORMAL = 1;
    //    //private const Int32 SW_HIDE = 0;

    //    //ICapturarDatos capturarDatos;
    //    //ConfiguracionesModel configuracion;

    //    //static void Main(string[] args)
    //    //{
    //    //    //ShowWindow(GetConsoleWindow(), SW_HIDE);
    //    //    Console.WriteLine("Press enter to exit.");
    //    //    Console.ReadLine();

    //    //    //IConfiguraciones objCapturaConfiguracion = new LeerConfiguracionRecursos();
    //    //    //ConfiguracionesModel config = objCapturaConfiguracion.leerConfiguracion();

    //    //    //Listener listener = new Listener(config);

    //    //    //FileSystemWatcher watcher = new FileSystemWatcher(config.rutaPlano);

    //    //    //watcher.NotifyFilter = NotifyFilters.Attributes
    //    //    //                     | NotifyFilters.CreationTime
    //    //    //                     | NotifyFilters.DirectoryName
    //    //    //                     | NotifyFilters.FileName
    //    //    //                     | NotifyFilters.LastAccess
    //    //    //                     | NotifyFilters.LastWrite
    //    //    //                     | NotifyFilters.Security
    //    //    //                     | NotifyFilters.Size;

    //    //    //watcher.Created += OnCreated;
    //    //    ////watcher.Changed += OnChanged;
    //    //    ////watcher.Created += OnCreated;
    //    //    ////watcher.Deleted += OnDeleted;
    //    //    ////watcher.Renamed += OnRenamed;
    //    //    ////watcher.Error += OnError;

    //    //    //watcher.Filter = "*.txt";
    //    //    //watcher.IncludeSubdirectories = false;
    //    //    //watcher.EnableRaisingEvents = true;

    //    //    //Console.WriteLine("Press enter to exit.");
    //    //    //Console.ReadLine();
    //    //}


    //    //private static void OnChanged(object sender, FileSystemEventArgs e)
    //    //{
    //    //    if (e.ChangeType != WatcherChangeTypes.Changed)
    //    //    {
    //    //        return;
    //    //    }
    //    //    Console.WriteLine($"Changed: {e.FullPath}");
    //    //}

    //    //private static void OnCreated(object sender, FileSystemEventArgs e)
    //    //{
    //    //    //ICapturarDatos capturarDatos = new CapturarDatosDesdeArchivo(configuracion);
    //    //    //    //capturarDatos.LeerInformacion();
    //    //    //    //CapturarDatosDesdeArchivo capturarDatos = new LeerArchivoPlano(configuracion);

    //    //    //    string value = $"Created: {e.FullPath}";
    //    //    //    Console.WriteLine(value);

    //    //    string value = $"Created: {e.FullPath}";
    //    //    Console.WriteLine(value);
    //    //}

    //    //private static void OnDeleted(object sender, FileSystemEventArgs e) =>
    //    //    Console.WriteLine($"Deleted: {e.FullPath}");

    //    //private static void OnRenamed(object sender, RenamedEventArgs e)
    //    //{
    //    //    Console.WriteLine($"Renamed:");
    //    //    Console.WriteLine($"    Old: {e.OldFullPath}");
    //    //    Console.WriteLine($"    New: {e.FullPath}");
    //    //}

    //    //private static void OnError(object sender, ErrorEventArgs e) =>
    //    //    PrintException(e.GetException());

    //    //private static void PrintException(Exception ex)
    //    //{
    //    //    if (ex != null)
    //    //    {
    //    //        Console.WriteLine($"Message: {ex.Message}");
    //    //        Console.WriteLine("Stacktrace:");
    //    //        Console.WriteLine(ex.StackTrace);
    //    //        Console.WriteLine();
    //    //        PrintException(ex.InnerException);
    //    //    }


    //    //}



    //}
}
