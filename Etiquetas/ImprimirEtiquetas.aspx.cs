using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Etiquetas
{
    public partial class ImprimirEtiquetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["TipoUsuario"] == "No" || this.Session["TipoUsuario"] == null)
            {
                this.Session["ErrorTipoUsuario"] = "Si";
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}