using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_de_texto_y_archivos_binarios
{
    public class Contacto
    {
        public int id;
        public string nombre;
        public int edad;
        public string correo;
        public string celular;
        public bool soltero;

        public Contacto(int id, string nombre, int edad, string correo, string celular, bool soltero)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;
            this.celular = celular;
            this.soltero = soltero;
        }
    }
}
