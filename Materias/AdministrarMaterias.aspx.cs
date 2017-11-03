using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Materias
{
    public partial class AdministrarMaterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosMaterias(GridView1);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Conexion cn = new Conexion();

            GridView1.EditIndex = e.NewEditIndex;

            cn.MostrarDatosDepartamentos(GridView1);

            TextBox CodigoCarrera = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[1].Controls[0];
            CodigoCarrera.ReadOnly = true;
            TextBox CodigoMateria = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[2].Controls[0];
            CodigoMateria.ReadOnly = true;



        }
    }
}