using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{
    public class clsTurno
    {
        private string turno;
        private bool suspendido;

        public bool Suspendido
        {
            get { return suspendido; }
            set { suspendido = value; }
        }

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public clsTurno() { }
        ~clsTurno() { }
    }
}