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
            Conexion cn = new Conexion();
           
            if (!IsPostBack)
            {
                cn.CargarDDLNroDoc(NroDoc, TipoDoc.SelectedItem.Text);
                cn.IdDocenteSiguiente(IdDocente);
            }
            
        }

        protected void AgregarDoc_Click(object sender, EventArgs e)
        {
            ///pregunta si los controles de validacion no tiran error y tambien si se ingreso la misma clave o legajo que hay en BD
            Conexion cn = new Conexion();
            if(Page.IsValid && cn.ValidarClaveDocentes(NroDoc.SelectedItem.Text, TipoDoc.SelectedItem.Text, Legajo.Text) == false)
            {
                cn.AgregarDocente(Convert.ToInt32(NroDoc.SelectedItem.Text.ToString()), TipoDoc.SelectedItem.Text, Convert.ToInt32(Legajo.Text.ToString()));
                Response.Redirect("VerDatosDocente.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Docente ya existe');</script>");
            }
        }

        protected void NroDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
    
        }

        protected void TipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.CargarDDLNroDoc(NroDoc, TipoDoc.SelectedItem.Text);
        }
    }
}
