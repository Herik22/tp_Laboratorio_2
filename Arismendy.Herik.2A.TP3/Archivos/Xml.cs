using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml <T> : IArchivo <T>
    {
        #region IMPLEMENTACION IARCHIVO

        /// <summary>
        /// Permite serializar y escribir en un archivo XML cualquier dato. 
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar (string archivo , T datos)
        {
            bool rta = false;
            try
            {
                
                using (TextWriter tw = new StreamWriter(archivo))
                {
                    XmlSerializer serializadorXml = new XmlSerializer(typeof(T));
                    serializadorXml.Serialize(tw, datos);
                    rta = true;
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e); 
            }
            return rta;
        }

        /// <summary>
        /// Permite deserializar  archivos en formato XML de cualquier dato. 
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer (string archivo, out T datos)
        {
            bool rta = false;
            try
            {
                
                using (TextReader tR = new StreamReader(archivo))
                {
                    XmlSerializer serializadorXml = new XmlSerializer(typeof(T));
                    datos = (T)serializadorXml.Deserialize(tR);
                    rta = true;
                }
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
            return rta;
        }
        #endregion
    }
}
