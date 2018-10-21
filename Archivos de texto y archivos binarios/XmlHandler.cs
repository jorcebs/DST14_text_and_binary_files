using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos_de_texto_y_archivos_binarios
{
    class XmlHandler
    {
        private string archivo;

        public XmlHandler(string archivo)
        {
            this.archivo = archivo;
        }

        public int getRegistros()
        {
            if (File.ReadLines(archivo).Count() > 3)
                return (File.ReadLines(archivo).Count() - 3) / 7;
            else
                return 0;
        }

        public void escribeEncabezado()
        {
            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            
            writer.WriteLine("<?xml version=\"1.0\"?>");
            writer.WriteLine("<catalog>");
            writer.WriteLine("</catalog>");

            writer.Close();
            stream.Close();
        }

        public void escribeContacto(Contacto contacto)
        {
            string[] lines = File.ReadAllLines(archivo);

            FileStream stream = new FileStream(archivo, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(stream);
            
            for (int i = 0; i < lines.Length - 1; i++)
                writer.WriteLine(lines[i]);
            
            writer.WriteLine("<contacto id=\"" + contacto.id.ToString() + "\">");
            writer.WriteLine("<nombre>" + contacto.nombre + "</nombre>");
            writer.WriteLine("<edad>" + contacto.edad.ToString() + "</edad>");
            writer.WriteLine("<correo>" + contacto.correo + "</correo>");
            writer.WriteLine("<celular>" + contacto.celular.ToString() + "</celular>");
            writer.WriteLine("<soltero>" + contacto.soltero.ToString() + "</soltero>");
            writer.WriteLine("</contacto>");
            writer.WriteLine("</catalog>");

            writer.Close();
            stream.Close();
        }

        public Contacto[] leerContactos()
        {
            string[] lines = File.ReadAllLines(archivo);
            
            Contacto[] contactos = new Contacto[getRegistros()];
            for (int i = 0; i < getRegistros(); i++)
            {
                string id, nombre, edad, correo, celular, soltero;
                id = lines[i * 7 + 2].Remove(0, lines[i * 7 + 2].IndexOf('"') + 1);
                id = id.Remove(id.IndexOf('"'));
                nombre = lines[i * 7 + 3].Remove(0, lines[i * 7 + 3].IndexOf('>') + 1);
                nombre = nombre.Remove(nombre.IndexOf('<'));
                edad = lines[i * 7 + 4].Remove(0, lines[i * 7 + 4].IndexOf('>') + 1);
                edad = edad.Remove(edad.IndexOf('<'));
                correo = lines[i * 7 + 5].Remove(0, lines[i * 7 + 5].IndexOf('>') + 1);
                correo = correo.Remove(correo.IndexOf('<'));
                celular = lines[i * 7 + 6].Remove(0, lines[i * 7 + 6].IndexOf('>') + 1);
                celular = celular.Remove(celular.IndexOf('<'));
                soltero = lines[i * 7 + 7].Remove(0, lines[i * 7 + 7].IndexOf('>') + 1);
                soltero = soltero.Remove(soltero.IndexOf('<'));
                contactos[i] = new Contacto(Convert.ToInt32(id), nombre, Convert.ToInt32(edad), correo, celular, (soltero == "True") ? true : false);
            }
            return contactos;
        }
    }
}