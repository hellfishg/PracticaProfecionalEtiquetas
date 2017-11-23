using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{
    public class clsCurso
    {
        private string codCarrera;
        private string codMateria;
        private string turno;
        private int idDocente;
        private string anio;

        public string Anio
        {
            get { return anio; }
            set { anio = value; }
        }

        public int IdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string CodMateria
        {
            get { return codMateria; }
            set { codMateria = value; }
        }

        public string CodCarrera
        {
            get { return codCarrera; }
            set { codCarrera = value; }
        }

        public clsCurso() { }
        ~clsCurso() { }
    }
}