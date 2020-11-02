using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;


namespace Archivos
{
    public class Texto : IArchivo <string>
    {
        #region Implemtencacion IArchivo

        /// <summary>
        /// Permite guardar en archivos de texto datos de  cualquier tipo.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar (string ruta,string datos)
        {
            bool rta = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(datos);
                    rta = true;
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e); // lanzo excepcion de archivos.
            }
            return rta;
        }

        /// <summary>
        /// Implementacion de la interfaz de archivos que permite leer desde un ruta especificada un archivo de texto,
        /// y guardarlo en el parametro recibido.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer (string ruta,out string  datos )
        {
            bool rta = false;
            //datos = null;
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    datos = sr.ReadToEnd();
                    rta = true;
                }
            }
            catch (Exception e )
            {

                throw new ArchivosException(e); 
            }
            return rta;
        }

        #endregion
    }
}
