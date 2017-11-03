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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Conexion cn = new Conexion();
            cn.AgregarCarrera(TextBoxCod.Text, TextBox2.Text);

            TextBoxCod.Text = null;
            TextBox2.Text = null;

        }
    }
}