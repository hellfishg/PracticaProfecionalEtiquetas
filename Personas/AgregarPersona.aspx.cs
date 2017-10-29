using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Personas
{
    public partial class AgregarPersona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AgregarPRSNA_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.AgregarPersona(Convert.ToInt32(NroDoc.Text.ToString()), TipoDoc.Text, Apellido.Text, Nombre.Text, Provincia.Text, Localidad.Text, Direccion.Text, Convert.ToInt32(Telefono.Text.ToString()), Convert.ToInt32(Celular.Text.ToString()), Email.Text, Sexo.Text, EstadoCivil.Text, Nacionalidad.Text);
        }
    }
}
