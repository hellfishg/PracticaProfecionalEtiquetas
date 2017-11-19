using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Departamentos
{
    public partial class AgregarDepartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["TipoUsuario"] == "No" || this.Session["TipoUsuario"] == null || (string)this.Session["TipoUsuario"] == "Lec")
            {
                Response.Write("<script>window.alert('Usted no tiene permisos para ingresar a esta seccion.');window.location.href ='AdministrarDepartamentos.aspx';</script>");
                //Response.Redirect("~/Departamentos/AdministrarDepartamentos.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) && !cn.ValidarDepartamento(txtDescripcion.Text))
            {
                cn.AgregarDepartamento(txtDescripcion.Text);
            }
            else
            {
                Response.Write("<script>window.alert('Departamento ya existente');</script>");
            }
            
        }
    }
}