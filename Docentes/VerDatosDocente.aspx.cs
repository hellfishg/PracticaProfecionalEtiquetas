using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Docentes
{
    public partial class VerDatosDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion con = new Conexion();
                con.MostrarDatosDocentes(grdVerDocentes);
            }
        }
    }
}
