using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{
    public class clsMateria
    {
        private string idCarrera;
        private string idMateria;
        private string materia;


        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        public string IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public string IdCarrera
        {
            get { return idCarrera; }
            set { idCarrera = value; }
        }
        

        
        public clsMateria() { }
        ~clsMateria() { }
    }
}