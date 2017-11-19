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
            if ((string)this.Session["TipoUsuario"] == "No" || this.Session["TipoUsuario"] == null || (string)this.Session["TipoUsuario"] == "Lec")
            {
                Response.Write("<script>window.alert('Usted no tiene permisos para ingresar a esta seccion.');window.location.href ='AdministrarPersonas.aspx';</script>");
                //Response.Redirect("~/Personas/AdministrarPersonas.aspx");
            }
        }

        protected void AgregarPRSNA_Click(object sender, EventArgs e)
        {
            ///pregunta si los controles de validacion no tiran error y tambien si se ingreso la misma clave que hay en BD
            Conexion cn = new Conexion();
            if (Page.IsValid && cn.ValidarClavePersonas(NroDoc.Text.ToString(), TipoDoc.SelectedItem.Text) == false)
            {
                cn.AgregarPersona(Convert.ToInt32(NroDoc.Text.ToString()), TipoDoc.SelectedItem.Text, Apellido.Text, Nombre.Text, Provincia.Text, Localidad.Text, Direccion.Text, Convert.ToInt32(Telefono.Text.ToString()), Convert.ToInt32(Celular.Text.ToString()), Email.Text, Sexo.SelectedItem.Value, EstadoCivil.SelectedItem.Text, Nacionalidad.Text);
                Response.Redirect("VerDatosPersona.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Numero de documento ya utilizado');</script>");
            }
           
        }

        protected void Direccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
