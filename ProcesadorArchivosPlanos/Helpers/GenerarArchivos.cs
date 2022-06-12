using OfficeOpenXml;
using ProcesadorArchivosPlanos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace ProcesadorArchivosPlanos.Helpers
{
    internal static class GenerarArchivos
    {

        public static void generarArchivoExcel(string rutaArchivo, DataSet dsDatos)
        {
            try
            {

                FileInfo file = new FileInfo(rutaArchivo);

                //FileInfo file = new FileInfo(Path.Combine(strDirectorio, strnombreArchivo));

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                //ExcelPackage.LicenseContext = LicenseContext.Commercial;
                string documentacionLicencia = "https://www.epplussoftware.com/Developers/LicenseException;";


                ExcelPackage libro = new ExcelPackage(file);
                using (libro)
                {

                    libro.Workbook.Properties.Author = "Elkin";
                    libro.Workbook.Properties.Company = "AdaSoft";
                    libro.Workbook.Properties.Keywords = "Excel,Epplus";

                    if (dsDatos.Tables.Count > 0)
                    {
                        //Asigna nombre a la Hoja
                        string strHoja = "Datos Filtrados";
                        ExcelWorksheet hoja = libro.Workbook.Worksheets.Add(strHoja);

                        int numColumna = 1;
                        foreach (DataColumn columna in dsDatos.Tables[0].Columns)
                        {
                            hoja.Cells[1, numColumna].Value = columna.ColumnName;
                            numColumna++;
                        }

                        int numFila = 2;
                        foreach (DataRow fila in dsDatos.Tables[0].Rows)
                        {
                            numColumna = 1;
                            foreach (DataColumn columna in dsDatos.Tables[0].Columns)
                            {
                                hoja.Cells[numFila, numColumna].Value = fila[columna.ColumnName].ToString();
                                numColumna++;
                            }
                            numFila++;
                        }

                        libro.Save(); //Save the workbook.

                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void guardarLog(string rutaPlanos, string lineainformacion)
        {

            string strNombreArchivo = $"Log_{DateTime.Now.ToString("yyyyMMddmmssff")}.txt";

            string rutaArchivo = $"{rutaPlanos}{strNombreArchivo}";
            //string rutaArchivo = $"D:\\Repositorios\\SS_Generador_de_Planos\\Generador_de_Planos_Lado_Servidor\\GeneradorPlanos\\wwwroot\\Planos\\plano.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }

                using (FileStream objfs = File.Create(rutaArchivo))
                {
                    Byte[] miInfo = new UTF8Encoding(true).GetBytes(lineainformacion);
                    objfs.Write(miInfo, 0, miInfo.Length);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void moverArchivo(string carpetaOrigen, string carpetaDestino,string nombreArchivo)
        {
            carpetaDestino += nombreArchivo;
            System.IO.File.Move(carpetaOrigen, carpetaDestino, true);

        }

    }
}
