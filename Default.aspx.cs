using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["TipoUsuario"] == "Lec" || (string)this.Session["TipoUsuario"] == "Adm")
            {
                TextBox1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                TextBox2.Visible = false;
                Button1.Visible = false;
                Button2.Visible = true;
            }
            if (!IsPostBack)
            {
                if ((string)this.Session["ErrorTipoUsuario"] == "Si")
                {
                    Response.Write("<script>window.alert('Debe Iniciar Sesion');</script>");
                    this.Session["ErrorTipoUsuario"] = "No";
                }
            }
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            string aux = cn.ComprobarUsuario(TextBox1.Text, TextBox2.Text).ToString();
            if (aux != "Error")
            {
                Response.Write("<script>window.alert('Se ingreso con exito');</script>");
                TextBox1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                TextBox2.Visible = false;
                Button1.Visible = false;
                Button2.Visible = true;
                if (this.Session["TipoUsuario"] == null)
                {
                    this.Session["TipoUsuario"] = "No";
                }
                if (aux == "Administrador")
                {
                    this.Session["TipoUsuario"] = "Adm";
                }
                else
                {
                    this.Session["TipoUsuario"] = "Lec";
                }
            }
            else
            {
                Response.Write("<script>window.alert('Usuario o Contraseña no valida');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Session["TipoUsuario"] = "No";
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            Button1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Button2.Visible = false;
        }
    }
}