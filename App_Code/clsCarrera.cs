using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{
    public class clsCarrera
    {
        private string idCarrera;
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public string IdCarrera
        {
            get { return idCarrera; }
            set { idCarrera = value; }
        }

        public clsCarrera() { }
        ~clsCarrera() { }
    }
}