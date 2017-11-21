using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Carreras
{
    public partial class AgregarCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["TipoUsuario"] == "No" || this.Session["TipoUsuario"] == null || (string)this.Session["TipoUsuario"] == "Lec")
            {
                Response.Write("<script>window.alert('Usted no tiene permisos para ingresar a esta seccion.');window.location.href ='AdministrarCarreras.aspx';</script>");
                //Response.Redirect("~/Carreras/AdministrarCarreras.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool aux = true;
            Conexion cn = new Conexion();

            if (TextBoxCod.Text.ToString().Trim().Length > 3 || TextBoxCod.Text.ToString().Trim().Length < 1)
            {
                Response.Write("<script>window.alert('El codigo debe tener menos de 4 caracteres y mas de 1');</script>");
                aux = false;
            }

            if (cn.ValidarClaveCarrera(TextBoxCod.Text.ToString().Trim()) == true)
            {
                Response.Write("<script>window.alert('Codigo repetido');</script>");
                aux = false;
            }

            if (TextBox2.Text.ToString().Trim() == "")
            {
                Response.Write("<script>window.alert('La carrera debe tener un nombre');</script>");
                aux = false;
            }

            if (aux == true)
            {
                cn.AgregarCarrera(TextBoxCod.Text, TextBox2.Text);


                TextBoxCod.Text = null;
                TextBox2.Text = null;
            }
        }
    }
}