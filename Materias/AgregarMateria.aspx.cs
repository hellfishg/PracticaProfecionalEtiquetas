using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Materias
{
    public partial class AgregarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.CargarDDLcursadas(ddlCursadas);
                cn.CargarDDLCarrera(ddlcarreras);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.AgregarMateria(ddlcarreras.SelectedItem.Text, txtCodigo.Text, txtNombre.Text, txtTipoPlan.Text, ddlCursadas.SelectedItem.Text);
            
        }
    }
}