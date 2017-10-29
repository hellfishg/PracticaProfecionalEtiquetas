using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Docentes
{
    public partial class AgregarDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.IdDocenteSiguiente(IdDocente);
                IdDocente.ReadOnly = true;
            }
        }

        protected void AgregarDoc_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.AgregarDocente(Convert.ToInt32(NroDoc.Text.ToString()), TipoDoc.Text.ToString(), Convert.ToInt32(Legajo.Text.ToString()));

        }
    }
}
