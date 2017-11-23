using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{
    public class clsDocente
    {
        private int idDocente;
        private string apellido;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int IdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }
        public clsDocente() { }
        ~clsDocente() { }
    }
}